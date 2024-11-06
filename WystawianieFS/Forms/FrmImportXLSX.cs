using ClosedXML.Excel;
using NLog;
using System.Data;
using WystawianieFS.Services;
using System.IO;

namespace WystawianieFS
{
    public partial class FrmImportXLSX : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        private DbService dbService = new DbService();
        public FrmImportXLSX()
        {
            InitializeComponent();
        }

        private void btn_pobierzSzablon_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbBx_importXLSX.Text)
                {
                    case "Kontrahenci":
                        pobierzSzablonXLS("Szablon_kontrahenci.xlsx");
                        break;
                    case "Ceny":
                        pobierzSzablonXLS("Szablon_ceny.xlsx");
                        break;
                    case "Towary":
                        pobierzSzablonXLS("Szablon_towary.xlsx");
                        break;
                    case "Firmy":
                        pobierzSzablonXLS("Szablon_firmy.xlsx");
                        break;
                    default:
                        MessageBox.Show("Nie wybrano żadnej z dostępnych pozycji.", "Wybierz opcję", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
                
        }

        private async void btn_importXLSX_Click(object sender, EventArgs e)
        {
            try
            {
                //  SZABLONY Z NAGŁÓWKAMI TABEL
                var SzablonKontrahenci = new List<string> { "Nazwa", "Akronim", "NIP", "Miasto", "Ulica", "KodPocztowy", "Email" };
                var SzablonCeny = new List<string> { "TowarID", "DataNabycia", "CenaNetto", "Waluta", "Ilosc" };
                var SzablonTowary = new List<string> { "Nazwa", "Kod", "JM", "VAT" };
                var SzablonFirmy = new List<string> { "Nazwa", "NIP", "Miasto", "Ulica", "KodPocztowy", "Email" };

                if (opFlDlg_szablonXLSX.ShowDialog() == DialogResult.OK)
                {
                    string sciezka = opFlDlg_szablonXLSX.FileName;
                    using (var workbook = new XLWorkbook(sciezka))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var naglowki = worksheet.FirstRow().CellsUsed().Select(c => c.GetString()).ToList();
                        var ostatniaKolumna = worksheet.LastColumnUsed().ColumnNumber();
                        var ostatniWiersz = worksheet.LastRowUsed().RowNumber();
                        var ListaRekordow = new List<List<string>>();
                        for (int row = 2; row <= ostatniWiersz; row++)
                        {
                            var rekordy = new List<string>();
                            for (int col = 1; col <= ostatniaKolumna; col++)
                            {
                                var rekord = worksheet.Cell(row, col).Value.ToString();
                                rekordy.Add(rekord);
                            }
                            ListaRekordow.Add(rekordy);
                        }   
                        if (naglowki.SequenceEqual(SzablonKontrahenci))
                        {
                            foreach (var rek in ListaRekordow)
                            {
                                await dbService.DodajKontrahenta(rek);
                            }
                            MessageBox.Show("Dodano nowych kontrahentów", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (naglowki.SequenceEqual(SzablonCeny))
                        {
                            foreach (var rek in ListaRekordow)
                            {
                                await dbService.DodajCeny(rek);
                            }
                            MessageBox.Show("Dodano nowe ceny", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (naglowki.SequenceEqual(SzablonTowary))
                        {
                            foreach (var rek in ListaRekordow)
                            {
                                await dbService.DodajTowary(rek);
                            }
                            MessageBox.Show("Dodano nowe towary", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (naglowki.SequenceEqual(SzablonFirmy))
                        {
                            foreach (var rek in ListaRekordow)
                            {
                                await dbService.DodajFirme(rek);
                            }
                            MessageBox.Show("Dodano nowe firmy", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nie rozpoznano szablonu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            { 
                logger.Error(ex.Message);
            }
        }
        private void pobierzSzablonXLS(string nazwa)
        {
            try
            {
                string sciezkaSzablonu = Path.Combine(Application.StartupPath, "SzablonyXLSX/"+nazwa);
                string dokumentyFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nazwa);
                if (File.Exists(sciezkaSzablonu))
                {
                    File.Copy(sciezkaSzablonu, dokumentyFolder, true);
                    MessageBox.Show("Szablon został pobrany i znajduje się w folderze Dokumenty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nie znaleziono szablonu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Nie znaleziono szablonu");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
