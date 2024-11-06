using iText.IO.Font.Constants;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using NLog;
using WystawianieFS.Models;
using WystawianieFS.Models.DBModels;
using System.Text;

namespace WystawianieFS.Services
{
    public class PdfService
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void GenerujFakture(Firma wyst, Kontrahent knt, FS fs, List<PozycjeNaFakturzeView> pozycje)
        {
            try
            {
                string fileName = $"{fs.Nazwa} {fs.NumerFaktury.Replace("/", "-")}.pdf";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    PdfFont font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN, PdfEncodings.CP1250);
                    document.SetFont(font);

                    Table daty = new Table(UnitValue.CreatePercentArray(new float[] { 40, 30, 30 })).UseAllAvailableWidth();
                    daty.AddCell(new Cell(2, 1)
                        .SetBorder(Border.NO_BORDER)
                        .Add(new Paragraph("")));
                    daty.AddCell(new Cell(2, 1)
                        .SetBorder(Border.NO_BORDER)
                        .Add(new Paragraph($"Data wystawienia: ").SetTextAlignment(TextAlignment.RIGHT))
                        .Add(new Paragraph($"Data sprzedaży: ").SetTextAlignment(TextAlignment.RIGHT))
                        .Add(new Paragraph($"Miejsce wystawienia: ").SetTextAlignment(TextAlignment.RIGHT)));
                    daty.AddCell(new Cell(2, 1)
                        .SetBorder(Border.NO_BORDER)
                        .Add(new Paragraph($"{fs.DataWystawienia.ToShortDateString()}r").SetTextAlignment(TextAlignment.LEFT))
                        .Add(new Paragraph($"{fs.DataSprzedazy.ToShortDateString()}r").SetTextAlignment(TextAlignment.LEFT))
                        .Add(new Paragraph($"{wyst.Miasto}, \nul.{wyst.Ulica}").SetTextAlignment(TextAlignment.LEFT)));
                    document.Add(daty);
                    document.Add(new Paragraph("\n\n"));

                    Table sprzNab = new Table(UnitValue.CreatePercentArray(new float[] { 50, 50 })).UseAllAvailableWidth();
                    sprzNab.AddCell(new Cell(2, 1)
                        .SetBorder(Border.NO_BORDER)
                        .Add(new Paragraph("SPRZEDAWCA:"))
                        .Add(new Paragraph($"{wyst.Nazwa}"))
                        .Add(new Paragraph($"{wyst.Miasto}, ul.{wyst.Ulica}"))
                        .Add(new Paragraph($"{wyst.KodPocztowy}, {wyst.Miasto}"))
                        .Add(new Paragraph($"NIP: {wyst.NIP}")));
                    sprzNab.AddCell(new Cell(2, 1)
                        .SetBorder(Border.NO_BORDER)
                        .Add(new Paragraph("NABYWCA:"))
                        .Add(new Paragraph($"{knt.Nazwa}"))
                        .Add(new Paragraph($"{knt.Miasto}, ul.{knt.Ulica}"))
                        .Add(new Paragraph($"{knt.KodPocztowy}, {knt.Miasto}"))
                        .Add(new Paragraph($"NIP: {knt.NIP}")));
                    document.Add(sprzNab);
                    document.Add(new Paragraph("\n\n"));

                    document.Add(new Paragraph($"{fs.Nazwa} {fs.NumerFaktury}")
                            .SetFontSize(20)
                            .SetBold()
                            .SetTextAlignment(TextAlignment.CENTER));
                    document.Add(new Paragraph("\n"));

                    Table produkty = new Table(new float[] { 1, 3, 1, 2, 2, 2, 2, 2, 3 }).UseAllAvailableWidth();
                    produkty.AddHeaderCell("LP");
                    produkty.AddHeaderCell("Nazwa");
                    produkty.AddHeaderCell("JM");
                    produkty.AddHeaderCell("Ilość");
                    produkty.AddHeaderCell("Waluta");
                    produkty.AddHeaderCell("Wartość Netto");
                    produkty.AddHeaderCell("VAT [%]");
                    produkty.AddHeaderCell("Wartość Brutto");
                    produkty.AddHeaderCell("Razem");

                    for (int i = 0; i < pozycje.Count; i++)
                    {
                        if (pozycje[i].Waluta == "PLN")
                        {
                            produkty.AddCell((i + 1).ToString());
                            produkty.AddCell(pozycje[i].Nazwa);
                            produkty.AddCell(pozycje[i].JM);
                            produkty.AddCell($"{Math.Round(pozycje[i].Ilosc, 2)}");
                            produkty.AddCell(pozycje[i].Waluta);
                            produkty.AddCell(($"{Math.Round(pozycje[i].CenaNetto, 2)}"));
                            produkty.AddCell(pozycje[i].VAT.ToString());
                            produkty.AddCell(($"{Math.Round(pozycje[i].CenaBrutto ?? 0, 2)}"));
                            produkty.AddCell($"{Math.Round(pozycje[i].CenaBrutto * pozycje[i].Ilosc ?? 0, 2)}");
                        }
                        else
                        {
                            produkty.AddCell((i + 1).ToString());
                            produkty.AddCell(pozycje[i].Nazwa);
                            produkty.AddCell(pozycje[i].JM);
                            produkty.AddCell($"{Math.Round(pozycje[i].Ilosc, 2)}");
                            produkty.AddCell("PLN");
                            produkty.AddCell(($"{Math.Round(pozycje[i].CNprzelicz ?? 0, 2)}"));
                            produkty.AddCell(pozycje[i].VAT.ToString());
                            produkty.AddCell(($"{Math.Round(pozycje[i].CBprzelicz ?? 0, 2)}"));
                            produkty.AddCell($"{Math.Round(pozycje[i].CBprzelicz * pozycje[i].Ilosc ?? 0, 2)}");
                        }
                    }
                    document.Add(produkty).SetBorder(Border.NO_BORDER);
                    document.Add(new Paragraph("\n"));

                    Table podsWS = new Table(UnitValue.CreatePercentArray(new float[] { 30, 70 })).UseAllAvailableWidth();
                    podsWS.AddCell(new Cell(2, 1)
                        .SetBorder(Border.NO_BORDER)
                        .Add(new Paragraph("")));
                    Table podsumowanie = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1 })).UseAllAvailableWidth();
                    podsumowanie.AddHeaderCell("Stawka VAT[%]");
                    podsumowanie.AddHeaderCell("Wartość Netto");
                    podsumowanie.AddHeaderCell("Kwota VAT");
                    podsumowanie.AddHeaderCell("Wartość brutto");

                    var podsum = pozycje.GroupBy(x => x.VAT).Select(grupa =>
                    {
                        var wartoscNetto = grupa.Sum(x => x.CNprzelicz * x.Ilosc ?? x.CenaNetto * x.Ilosc);
                        var wartoscBrutto = grupa.Sum(x => x.CBprzelicz * x.Ilosc ?? x.CenaBrutto * x.Ilosc);
                        var kwotaVAT = wartoscBrutto - wartoscNetto;

                        

                        return new
                        {
                            VAT = grupa.Key,
                            WartoscNetto = wartoscNetto,
                            KwotaVAT = kwotaVAT,
                            WartoscBrutto = wartoscBrutto,
                        };
                    });

                    foreach (var pds in podsum)
                    {
                        podsumowanie.AddCell(pds.VAT.ToString());
                        podsumowanie.AddCell($"{Math.Round(pds.WartoscNetto, 2)}");
                        podsumowanie.AddCell($"{Math.Round(pds.KwotaVAT ?? 0, 2)}");
                        podsumowanie.AddCell($"{Math.Round(pds.WartoscBrutto ?? 0, 2)}");
                    }
                    podsWS.AddCell(new Cell(2, 1).SetBorder(Border.NO_BORDER).Add(podsumowanie));
                    document.Add(podsWS);

                    var razem = podsum.Sum(x => x.WartoscBrutto);
                    document.Add(new Paragraph($"Razem do zapłaty: {Math.Round(razem ?? 0, 2)} ")
                        .SetBorder(Border.NO_BORDER)
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetBold());
                    document.Add(new Paragraph($"Słownie: {KwotaNaSlowa(razem)}")
                        .SetBorder(Border.NO_BORDER)
                        .SetTextAlignment(TextAlignment.RIGHT));
                    document.Add(new Paragraph("\n\n\n"));

                    Table podpisy = new Table(UnitValue.CreatePercentArray(new float[] { 50, 50 })).UseAllAvailableWidth();
                    podpisy.AddCell(new Cell().Add(new Paragraph("Wystawił(a): ..............................").SetTextAlignment(TextAlignment.CENTER))
                        .SetBorder(Border.NO_BORDER));
                    podpisy.AddCell(new Cell().Add(new Paragraph("Odebrał(a): ..............................").SetTextAlignment(TextAlignment.CENTER))
                        .SetBorder(Border.NO_BORDER));
                    document.Add(podpisy);
                    document.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Error("Szablon faktury: " + ex.Message);
            }
        }
        private string ZamienLiczbeNaSlowa(int liczba)
        {
            string[] jednosci = { "", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };
            string[] nastki = { "dziesięć", "jedenaście", "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście" };
            string[] dziesiatki = { "", "", "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt" };
            string[] setki = { "", "sto", "dwieście", "trzysta", "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset" };
            string[] tysiac = { "tysiąc", "tysiące", "tysięcy" };

            var sb = new StringBuilder();

            if (liczba / 1000 > 0)
            {
                sb.Append($"{ZamienLiczbeNaSlowa(liczba / 1000)} {tysiac[OdmianaTysiaca(liczba / 1000)]} ");
                liczba %= 1000;
            }

            if (liczba / 100 > 0)
            {
                sb.Append($"{setki[liczba / 100]} ");
                liczba %= 100;
            }

            if (liczba >= 10 && liczba < 20)
            {
                sb.Append($"{nastki[liczba - 10]} ");
            }
            else
            {
                if (liczba / 10 > 0)
                {
                    sb.Append($"{dziesiatki[liczba / 10]} ");
                }
                if (liczba % 10 > 0)
                {
                    sb.Append($"{jednosci[liczba % 10]} ");
                }
            }

            return sb.ToString().Trim();
        }

        private int OdmianaTysiaca(int liczba)
        {
            if (liczba == 1) return 0; // tysiąc
            if (liczba % 10 >= 2 && liczba % 10 <= 4 && (liczba % 100 < 10 || liczba % 100 >= 20)) return 1; // tysiące
            return 2; // tysięcy
        }

        public string KwotaNaSlowa(decimal? suma)
        {
            try
            {
                if (suma != null)
                {
                    int zlote = (int)Math.Floor(suma ?? 0);
                    int grosze = (int)((suma - zlote) * 100);

                    if (zlote == 0) return "zero zł " + grosze.ToString("00") + " gr";

                    var sb = new StringBuilder();
                    sb.Append(ZamienLiczbeNaSlowa(zlote)).Append(" zł ");
                    sb.Append(grosze.ToString("00")).Append(" gr");

                    return sb.ToString().Trim();
                }
                else
                {
                    logger.Error("Nie podano kwoty do zapisu słownego");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return string.Empty;
            }
        }

    }
}

