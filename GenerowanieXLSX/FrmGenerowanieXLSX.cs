using ClosedXML.Excel;
using NLog;
using System.Linq.Expressions;

namespace GenerowanieXLSX
{
    public partial class FrmGenerowanieXLSX : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmGenerowanieXLSX()
        {
            try
            {
                InitializeComponent();
                txtBx_nazwa.Enabled = false;
                txtBx_akronim.Enabled = false;
                txtBx_adres.Enabled = false;
                txtBx_ulica.Enabled = false;
                txtBx_kodPocztowy.Enabled = false;
                txtBx_email.Enabled = false;
                txtBx_kod.Enabled = false;
                dateTimePicker2.Enabled = false;
                txtBx_cenaNetto.Enabled = false;
                cmbBx_waluta.Enabled = false;
                numUpDwn_ilosc.Enabled = false;
                cmbBx_jm.Enabled = false;
                txtBx_vat.Enabled = false;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        private async void btn_generujDane_Click(object sender, EventArgs e)
        {
            try 
            { 
                var arkusz = cmbBx_rodzajDanych.Text;
                var iloscDanych = (int)numUpDwn_iloscDanych.Value;
                var indeksPoczatkowy = (int)numUpDwn_start.Value;
                string nazwaPliku = arkusz + ".xlsx";
                var dane = new List<List<string>>();
                switch (arkusz)
                {
                    case "Kontrahenci":
                        var NaglowekKontrahenci = new List<string> { "Nazwa", "Akronim", "NIP", "Miasto", "Ulica", "KodPocztowy", "Email" };
                        for (int i = indeksPoczatkowy; i < indeksPoczatkowy+iloscDanych; i++)
                        {
                            var dana = new List<string>
                            {
                                txtBx_nazwa.Text+i.ToString("D3"),
                                txtBx_akronim.Text+"-"+i.ToString("D3"),
                                i.ToString("D10"),
                                txtBx_adres.Text,
                                txtBx_ulica.Text,
                                txtBx_kodPocztowy.Text,
                                txtBx_email.Text
                            };
                            dane.Add(dana);
                        }
                        await GenerowanieDanychAsynch(arkusz, NaglowekKontrahenci, nazwaPliku, dane);
                        break;

                    case "Ceny":
                        var NaglowekCeny = new List<string> { "TowarID", "DataNabycia", "CenaNetto", "Waluta", "Ilosc" };
                        for (int i = indeksPoczatkowy; i < indeksPoczatkowy + iloscDanych; i++)
                        {
                            var dana = new List<string>
                        {
                            txtBx_kod.Text,
                            dateTimePicker2.Text,
                            txtBx_cenaNetto.Text,
                            cmbBx_waluta.Text,
                            numUpDwn_ilosc.Value.ToString()
                        };
                            dane.Add(dana);
                        }
                        await GenerowanieDanychAsynch(arkusz, NaglowekCeny, nazwaPliku, dane);
                        break;

                    case "Towary":
                        var NaglowekTowary = new List<string> { "Nazwa", "Kod", "JM", "VAT" };
                        for (int i = indeksPoczatkowy; i < indeksPoczatkowy + iloscDanych; i++)
                        {
                            var dana = new List<string>
                        {
                            txtBx_nazwa.Text + i.ToString("D3"),
                            txtBx_kod.Text + i.ToString("D3"),
                            cmbBx_jm.Text,
                            txtBx_vat.Text
                        };
                            dane.Add(dana);
                        }
                        await GenerowanieDanychAsynch(arkusz, NaglowekTowary, nazwaPliku, dane);
                        break;
                }
                
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        private async Task GenerowanieDanychAsynch(string arkusz, List<string> naglowek, string nazwaPliku, List<List<string>> dane)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add(arkusz);
                    int kolumna = 1;
                    foreach (var nag in naglowek)
                    {
                        worksheet.Cell(1, kolumna).Value = nag;
                        kolumna++;
                    }
                    for (int i = 0; i < dane.Count; i++)
                    {
                        for (int j = 0; j < dane[i].Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dane[i][j];
                        }

                    }
                    await Task.Run(() =>
                        workbook.SaveAs(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nazwaPliku))
                    );
                    MessageBox.Show("Wygenerowano dane: " + cmbBx_rodzajDanych.Text, "Wygenerowano dane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Wygenerowano dane: " + cmbBx_rodzajDanych.Text);
                }
            }
            catch(Exception ex) 
            { 
                logger.Error(ex.Message);
            }
        }

        private void cmbBx_rodzajDanych_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var arkusz = cmbBx_rodzajDanych.Text;
                switch (arkusz)
                {
                    case "Kontrahenci":
                        txtBx_nazwa.Enabled = true;
                        txtBx_akronim.Enabled = true;
                        txtBx_adres.Enabled = true;
                        txtBx_ulica.Enabled = true;
                        txtBx_kodPocztowy.Enabled = true;
                        txtBx_email.Enabled = true;
                        txtBx_kod.Enabled = false;
                        dateTimePicker2.Enabled = false;
                        txtBx_cenaNetto.Enabled = false;
                        cmbBx_waluta.Enabled = false;
                        numUpDwn_ilosc.Enabled = false;
                        cmbBx_jm.Enabled = false;
                        txtBx_vat.Enabled = false;

                        break;
                    case "Ceny":
                        txtBx_nazwa.Enabled = false;
                        txtBx_akronim.Enabled = false;
                        txtBx_adres.Enabled = false;
                        txtBx_ulica.Enabled = false;
                        txtBx_kodPocztowy.Enabled = false;
                        txtBx_email.Enabled = false;
                        txtBx_kod.Enabled = true;
                        dateTimePicker2.Enabled = true;
                        txtBx_cenaNetto.Enabled = true;
                        cmbBx_waluta.Enabled = true;
                        numUpDwn_ilosc.Enabled = true;
                        cmbBx_jm.Enabled = false;
                        txtBx_vat.Enabled = false;
                        break;
                    case "Towary":
                        txtBx_nazwa.Enabled = true;
                        txtBx_akronim.Enabled = false;
                        txtBx_adres.Enabled = false;
                        txtBx_ulica.Enabled = false;
                        txtBx_kodPocztowy.Enabled = false;
                        txtBx_email.Enabled = false;
                        txtBx_kod.Enabled = true;
                        dateTimePicker2.Enabled = false;
                        txtBx_cenaNetto.Enabled = false;
                        cmbBx_waluta.Enabled = false;
                        numUpDwn_ilosc.Enabled = false;
                        cmbBx_jm.Enabled = true;
                        txtBx_vat.Enabled = true;
                        break;
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }

}
