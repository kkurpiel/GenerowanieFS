using NHibernate.Linq;
using NLog;
using System.Diagnostics;
using WystawianieFS.Models;
using WystawianieFS.Models.DBModels;

namespace WystawianieFS.Services
{
    public class DbService
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public Logowanie? Zaloguj(string pin)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var user = session.Query<Logowanie>()
                        .Where(x => x.Kod == pin)
                        .FirstOrDefault();
                    if (user != null)
                    {
                        logger.Info("Zalogowano pomyślnie");
                        return (user);
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }
        // Dodawanie danych w FrmImportXLSX
        public async Task DodajKontrahenta(List<string> lista)
        {
            try
            {
                var kontrahent = new Kontrahent
                {
                    Nazwa = lista[0],
                    Akronim = lista[1],
                    NIP = lista[2],
                    Miasto = lista[3],
                    Ulica = lista[4],
                    KodPocztowy = lista[5],
                    Email = lista[6]
                };
                await Task.Run(() =>
                {
                    using (var session = NH_Service.OpenSession())
                    {
                        var czyIstnieje = session.Query<Kontrahent>()
                            .Where(x => x.Akronim == kontrahent.Akronim && x.NIP == kontrahent.NIP).Any();
                        if (!czyIstnieje)
                        {
                            using (var transaction = session.BeginTransaction())
                            {
                                session.Save(kontrahent);
                                transaction.Commit();
                                logger.Info("Dodano nowego kontrahenta: "+ kontrahent.Akronim);
                            }
                        }
                    }
                });
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        public async Task DodajCeny(List<string> lista)
        {
            try
            {
                await Task.Run(() =>
                {
                    using (var session = NH_Service.OpenSession())
                    {
                        var cena = new Cena
                        {
                            Towar = session.Query<Towar>().Where(x => x.Kod == lista[0]).First(),
                            DataNabycia = DateTime.Parse(lista[1]),
                            CenaNetto = decimal.Parse(lista[2]),
                            Waluta = lista[3],
                            Aktualny = false,
                            Ilosc = decimal.Parse(lista[4])
                        };
                        using (var transaction = session.BeginTransaction())
                        {
                            session.Save(cena);
                            transaction.Commit();
                            logger.Info("Dodano nową cenę " + cena.ID);
                        }
                    }
                });
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        public async Task DodajTowary(List<string> lista)
        {
            try
            {
                var towar = new Towar
                {
                    Nazwa = lista[0],
                    Kod = lista[1],
                    JM = lista[2],
                    VAT = int.Parse(lista[3])
                };
                await Task.Run(() =>
                {
                    using (var session = NH_Service.OpenSession())
                    {
                        var czyIstnieje = session.Query<Towar>().
                            Where(x => x.Kod == towar.Kod).Any();
                        if (!czyIstnieje)
                        {
                            using (var transaction = session.BeginTransaction())
                            {
                                session.Save(towar);
                                transaction.Commit();
                                logger.Info("Dodano nowy towar: " + towar.Kod);
                            }
                        }
                    }
                });
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        public async Task DodajFirme(List<string> lista)
        {
            try
            {
                var firma = new Firma
                {
                    Nazwa = lista[0],
                    NIP = lista[1],
                    Miasto = lista[2],
                    Ulica = lista[3],
                    KodPocztowy = lista[4],
                    Email = lista[5]
                };
                await Task.Run(() =>
                {
                    using (var session = NH_Service.OpenSession())
                    {
                        var czyIstnieje = session.Query<Firma>()
                            .Where(x => x.NIP == firma.NIP).Any();
                        if (!czyIstnieje)
                        {
                            using (var transaction = session.BeginTransaction())
                            {
                                session.Save(firma);
                                transaction.Commit();
                                logger.Info("Dodano nową firmę: " + firma.ID);
                            }
                        }
                    }
                });
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        ///////////////////////////////
        public List<Firma> GetFirma()
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var firma = session.Query<Firma>()
                        .ToList();
                    firma.Insert(0, new Firma());
                    return firma;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<Firma>();
            }
        }

        public List<Kontrahent> GetKontrahenci()
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var kontrahenci = session.Query<Kontrahent>()
                        .ToList();
                    kontrahenci.Insert(0, new Kontrahent());
                    return kontrahenci;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<Kontrahent>();
            }
        }
        public List <PozycjeNaFakturzeView> GetTowarDodaj(string? waluta)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var towaryCenyQuery = session.Query<Towar>()
                        .FetchMany(t => t.Ceny)
                        .SelectMany(t => t.Ceny, (t, c) => new { Towar = t, Cena = c })
                        .GroupBy(tc => new { tc.Towar.Nazwa, tc.Towar.Kod, tc.Towar.JM, tc.Towar.VAT, tc.Cena.Waluta })
                        .Where(g => (string.IsNullOrEmpty(waluta) || g.Key.Waluta == waluta))
                        .Select(g => new PozycjeNaFakturzeView
                        {
                            Nazwa = g.Key.Nazwa,
                            Kod = g.Key.Kod,
                            JM = g.Key.JM,
                            VAT = g.Key.VAT,
                            Waluta = g.Key.Waluta,
                            Ilosc = g.Sum(tc => tc.Cena.Ilosc),
                            WymaganaIlosc = 0
                        })
                        .ToList();

                    return towaryCenyQuery;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<PozycjeNaFakturzeView>();
            }
        }
        public List<string> GetUniqWaluty()
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var uqWaluty = session.Query<Cena>()
                        .Select(c => c.Waluta)
                        .Distinct()
                        .ToList();
                    uqWaluty.Insert(0, "");
                    return uqWaluty;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<string>();
            }
        }
        public void AddKontrahent(Kontrahent kontrahent)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var czyIstnieje = session.Query<Kontrahent>()
                        .Where(x => x.NIP == kontrahent.NIP || x.Akronim == kontrahent.Akronim).Any();
                    if (!czyIstnieje)
                    {
                        using (var transaction = session.BeginTransaction())
                        {
                            session.Save(kontrahent);
                            transaction.Commit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kontrahent o podanych danych już istnieje.", "Kontrahent już istnieje.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            { 
                logger.Error(ex.Message);
            }
        }
        public void AddTowar(Towar towar)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        if (towar != null)
                        {
                            var czyIstnieje = session.Query<Towar>()
                                .Where(x => x.Kod == towar.Kod).Any();

                            if (!czyIstnieje)
                            {
                                session.Save(towar);
                                transaction.Commit();
                                MessageBox.Show("Dodano nowy towar: " + towar.Nazwa, "Pomyślnie dodano towar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Towar o podanym kodzie już istnieje.", "Towar już istnieje.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        public void AddCena(Cena cena)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        if (cena != null)
                        {
                            session.Save(cena);
                            transaction.Commit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public List<Towar> GetUniqTowarID()
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var uqTowary = session.Query<Towar>()
                        .Distinct()
                        .ToList();
                    return uqTowary;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<Towar>();
            }
        }
        public async Task<List<PozycjeNaFakturzeView>> GetTowaryCenyViews(PozycjeNaFakturzeView? towar, DateTime dataWyst)
        {
            try
            {
                if (towar != null)
                {
                    using (var session = NH_Service.OpenSession())
                    {
                        HttpService httpService = new HttpService();
                        var cenyList = new List<PozycjeNaFakturzeView>();
                        decimal sumIlosc = 0;
                        decimal? cnPrzel = null;
                        decimal? cbPrzel = null;

                        var wszystkieCeny = session.Query<Cena>()
                            .Where(x => x.Towar.Kod == towar.Kod && x.Waluta == towar.Waluta)
                            .OrderBy(x => x.DataNabycia)
                            .ToList();                      

                        foreach (var cena in wszystkieCeny)
                        {
                            if(cena.Waluta != "PLN")
                            {
                                var kurs = await httpService.PobierzKursyWalut(dataWyst, cena.Waluta);
                                if (kurs != null)
                                {
                                    cnPrzel = cena.CenaNetto * kurs.Mid;
                                    cbPrzel = cena.CenaBrutto * kurs.Mid;
                                }
                            }

                            var aktualnaIlosc = Math.Min(cena.Ilosc, (decimal)(towar.WymaganaIlosc - sumIlosc));
                            cenyList.Add(new PozycjeNaFakturzeView
                            {
                                Nazwa = cena.Towar.Nazwa,
                                Kod = cena.Towar.Kod,
                                JM = cena.Towar.JM,
                                VAT = cena.Towar.VAT,
                                IDCeny = cena.ID,
                                DataNabycia = cena.DataNabycia,
                                CenaNetto = cena.CenaNetto,
                                CenaBrutto = cena.CenaBrutto,
                                CNprzelicz = cnPrzel,
                                CBprzelicz = cbPrzel,
                                Waluta = cena.Waluta,
                                Aktualny = cena.Aktualny,
                                Ilosc = aktualnaIlosc,
                                WymaganaIlosc = towar.WymaganaIlosc,
                                IsClicked = false
                            });

                            sumIlosc += aktualnaIlosc;

                            if (sumIlosc >= towar.WymaganaIlosc)
                            {
                                break;
                            }
                        }
                        return cenyList;
                    }
                }
                else
                {
                    return new List<PozycjeNaFakturzeView>();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<PozycjeNaFakturzeView>();
            }
        }
        public string GenerujFaktureDB(string wystNIP, string kntNIP, DateTime DataWyst, DateTime DataSprz, List<PozycjeNaFakturzeView> pozycjeNaFakturze)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var kontrahent = session.Query<Kontrahent>().FirstOrDefault(x => x.NIP == kntNIP);
                    var firma = session.Query<Firma>().FirstOrDefault(x => x.NIP == wystNIP);
                    if (kontrahent != null && firma != null)
                    {
                        using (var transaction = session.BeginTransaction())
                        {
                            try
                            {
                                var numerWMies = session.Query<FS>()
                                    .Where(x => x.DataWystawienia.Month == DateTime.Today.Month && x.DataWystawienia.Year == DateTime.Today.Year)
                                    .Count() + 1;
                                var fs = new FS()
                                {
                                    Kontrahent = kontrahent,
                                    Firma = firma,
                                    Nazwa = "Faktura VAT",
                                    NumerFaktury = numerWMies.ToString() + "/" + DateTime.Today.Month.ToString("D2") + "/" + DateTime.Today.Year.ToString("D4"),
                                    DataWystawienia = DataWyst,
                                    DataSprzedazy = DataSprz,
                                    MiejsceWystawienia = firma.Miasto + ", " + firma.Ulica,
                                };
                                session.Save(fs);
                                foreach (var pozycja in pozycjeNaFakturze)
                                {
                                    var cena = session.Query<Cena>()
                                        .FirstOrDefault(x => x.ID == pozycja.IDCeny && x.Aktualny == true);
                                    if (cena != null)
                                    {
                                        var fsCena = new FS_Cena()
                                        {
                                            FS = fs,
                                            Cena = cena,
                                            CNprzelicz = pozycja.CNprzelicz,
                                            CBprzelicz = pozycja.CBprzelicz,
                                            IloscTowaru = pozycja.Ilosc

                                        };
                                        session.Save(fsCena);
                                        cena.Ilosc -= pozycja.Ilosc;
                                        session.Update(cena);
                                    }
                                }
                                transaction.Commit();
                                return fs.NumerFaktury;
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                logger.Error("Rollback podzcas dodawania faktury do bazy danych. " + ex.Message);
                                return string.Empty;
                            }
                        }
                    }
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return string.Empty;
            }
        }
        public void GenerujFakturePdf(string nr)
        {
            try
            {
                var pdfService = new PdfService();
                using (var session = NH_Service.OpenSession())
                {
                    var faktura = session.Query<FS>().FirstOrDefault(x => x.NumerFaktury == nr);
                    if (faktura != null)
                    {
                        var fsCeny = session.Query<FS_Cena>().Where(x => x.FS == faktura).ToList();
                        var pozycjeNaFakturze = new List<PozycjeNaFakturzeView>();
                        foreach (var fsCena in fsCeny)
                        {
                            if (fsCena.Cena != null)
                            {
                                var pozycja = new PozycjeNaFakturzeView()
                                {
                                    Nazwa = fsCena.Cena.Towar.Nazwa,
                                    JM = fsCena.Cena.Towar.JM,
                                    VAT = fsCena.Cena.Towar.VAT,
                                    IDCeny = fsCena.Cena.ID,
                                    DataNabycia = fsCena.Cena.DataNabycia,
                                    CenaNetto = fsCena.Cena.CenaNetto,
                                    CenaBrutto = fsCena.Cena.CenaBrutto,
                                    Waluta = fsCena.Cena.Waluta,
                                    Aktualny = fsCena.Cena.Aktualny,
                                    Ilosc = fsCena.IloscTowaru,
                                    CNprzelicz = fsCena.CNprzelicz,
                                    CBprzelicz = fsCena.CBprzelicz
                                    
                                };
                                pozycjeNaFakturze.Add(pozycja);
                            }
                            else if (fsCena.ArchiwumCen != null)
                            {
                                var pozycja = new PozycjeNaFakturzeView()
                                {
                                    Nazwa = fsCena.ArchiwumCen.Towar.Nazwa,
                                    JM = fsCena.ArchiwumCen.Towar.JM,
                                    VAT = fsCena.ArchiwumCen.Towar.VAT,
                                    IDCeny = fsCena.ArchiwumCen.ID,
                                    DataNabycia = fsCena.ArchiwumCen.DataNabycia,
                                    CenaNetto = fsCena.ArchiwumCen.CenaNetto,
                                    CenaBrutto = fsCena.ArchiwumCen.CenaBrutto,
                                    Waluta = fsCena.ArchiwumCen.Waluta,
                                    Aktualny = fsCena.ArchiwumCen.Aktualny,
                                    Ilosc = fsCena.IloscTowaru,
                                    CNprzelicz = fsCena.CNprzelicz,
                                    CBprzelicz = fsCena.CBprzelicz
                                };
                                pozycjeNaFakturze.Add(pozycja);
                            }
                        }

                        pdfService.GenerujFakture(faktura.Firma, faktura.Kontrahent, faktura, pozycjeNaFakturze);
                        string nazwaPliku = $"{faktura.Nazwa} {faktura.NumerFaktury.Replace("/", "-")}.pdf";
                        string sciezkaPliku = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nazwaPliku);
                        if (File.Exists(sciezkaPliku))
                        {
                            Process.Start(new ProcessStartInfo(sciezkaPliku) { UseShellExecute = true });
                            logger.Info("Znaleziono i otworzono fakturę");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        public List<FS>GetAllFS()
        {
            using (var session = NH_Service.OpenSession())
            {
                try
                {
                    var fs = session.Query<FS>().ToList();
                    return fs;
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return new List<FS>();
                }
            }
        }
        public List<FS> SzukajFS(string szukaj)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var znalezione = session.Query<FS>()
                        .Where(x => x.NumerFaktury == szukaj)
                        .ToList();
                    return znalezione;

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return new List<FS>();
            }
        }
        public void WyslijFakture(string nr)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var emailWyst = session.Query<FS>().Where(x => x.NumerFaktury == nr).Select(x => x.Firma.Email).FirstOrDefault();
                    var emailKnt = session.Query<FS>().Where(x => x.NumerFaktury == nr).Select(x => x.Kontrahent.Email).FirstOrDefault();
                    var fs = session.Query<FS>().FirstOrDefault(x => x.NumerFaktury == nr);
                    if (emailWyst != null && emailKnt != null && fs != null)
                    {
                        var httpService = new HttpService();
                        httpService.WyslijEmail(emailWyst, emailKnt, fs);
                    }
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        public FS? GetFS(string nr)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var fs = session.Query<FS>().FirstOrDefault(x => x.NumerFaktury == nr);
                    return fs;
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }
        public Towar? GetTowar(string nr)
        {
            try
            {
                using (var session = NH_Service.OpenSession())
                {
                    var twr = session.Query<Towar>().FirstOrDefault(x => x.Kod == nr);
                    return twr;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }
    }
}
