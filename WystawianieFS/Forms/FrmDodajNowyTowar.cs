using NLog;
using System.Data;
using WystawianieFS.Models.DBModels;
using WystawianieFS.Services;

namespace WystawianieFS.Forms
{
    public partial class FrmDodajNowyTowar : Form
    {
        private DbService dbService = new DbService();
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public FrmDodajNowyTowar()
        {
            try
            {
                InitializeComponent();
                OdswiezCmbBx_TowarID();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dodajC_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBx_cenaNetto.Text)
                    && !string.IsNullOrEmpty(txtBx_ilosc.Text)
                    && !string.IsNullOrEmpty(cmbBx_waluta.Text)
                    && decimal.TryParse(txtBx_cenaNetto.Text, out decimal cn)
                    && decimal.TryParse(txtBx_ilosc.Text, out decimal ilosc))
                {
                    var selItem = cmbBx_towar.SelectedItem;
                    if (selItem != null)
                    {
                        var wybranyTowar = dbService.GetTowar(selItem.ToString());
                        if (wybranyTowar != null)
                        {
                            var cena = new Cena()
                            {
                                Towar = wybranyTowar,
                                DataNabycia = dTP_dataNab.Value,
                                CenaNetto = cn,
                                Waluta = cmbBx_waluta.Text,
                                Ilosc = ilosc
                            };
                            MessageBox.Show("Dodano nową cenę: " + cena.CenaNetto + cena.Waluta, "Pomyślnie dodano cenę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dbService.AddCena(cena);
                            OdswiezCmbBx_TowarID();
                            logger.Info($"Dodano nową cenę o ID {cena.ID}");
                            txtBx_cenaNetto.Text = string.Empty;
                            txtBx_ilosc.Text = string.Empty;
                            cmbBx_waluta.SelectedIndex = 0;
                            cmbBx_towar.SelectedIndex = 0;
                            dTP_dataNab.Value = DateTime.Today;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Uzupełnij dane wymagane do dodania nowej ceny.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        public void OdswiezCmbBx_TowarID()
        {
            try
            {
                var uniqTowary = dbService.GetUniqTowarID();
                cmbBx_towar.Items.Clear();
                cmbBx_towar.Items.AddRange(uniqTowary.Select(x => x.Kod).ToArray());
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_dodajTwr_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBx_nazwa.Text)
                    && !string.IsNullOrEmpty(txtBx_kod.Text) && txtBx_kod.Text.Length <= 8
                    && !string.IsNullOrEmpty(txtBx_jm.Text)
                    && !string.IsNullOrEmpty(txtBx_vat.Text) && int.TryParse(txtBx_vat.Text, out int vat))
                {
                    var towar = new Towar()
                    {
                        Nazwa = txtBx_nazwa.Text,
                        Kod = txtBx_kod.Text,
                        JM = txtBx_jm.Text,
                        VAT = vat
                    };
                    dbService.AddTowar(towar);
                    OdswiezCmbBx_TowarID();
                    logger.Info($"Dodano nowy towar {towar.Kod}");
                    txtBx_nazwa.Text = string.Empty;
                    txtBx_kod.Text = string.Empty;
                    txtBx_jm.Text = string.Empty;
                    txtBx_vat.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Uzupełnij dane dotyczące towaru.", "Uzupełnij dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
