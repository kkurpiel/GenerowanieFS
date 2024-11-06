using NLog;
using WystawianieFS.Models;
using WystawianieFS.Services;

namespace WystawianieFS.Forms
{
    public partial class FrmDodajTowary : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public List<PozycjeNaFakturzeView> WybraneTowary { get; private set; } = new List<PozycjeNaFakturzeView>();
        private DbService dbService= new DbService();
        public FrmDodajTowary(List<PozycjeNaFakturzeView> WybraneTowary)
        {
            try
            {
                this.WybraneTowary = WybraneTowary;
                InitializeComponent();
                var waluty = dbService.GetUniqWaluty();
                cmbBx_waluta.Items.Clear();
                cmbBx_waluta.Items.AddRange(waluty.ToArray());
                OdswiezListeTowarow();
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

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                WybraneTowary.Clear();
                foreach (DataGridViewRow row in dGV_towary.Rows)
                {
                    decimal wymaganaIlosc = Convert.ToDecimal(row.Cells["WymaganaIlosc"].Value);
                    if (wymaganaIlosc > 0)
                    {
                        PozycjeNaFakturzeView wiersz = row.DataBoundItem as PozycjeNaFakturzeView;

                        if (wiersz != null)
                        {
                            if (wiersz.Ilosc < wiersz.WymaganaIlosc)
                            {
                                MessageBox.Show("Wprowadzono błędną wymaganą ilość towaru: " + wiersz.Kod, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                continue;
                            }
                            WybraneTowary.Add(wiersz);
                        }
                    }
                }
                var towars = WybraneTowary;
                this.DialogResult = DialogResult.OK;
                logger.Info("Dodano "+towars.Count + " towarów.");
                this.Close();
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void cmbBx_waluta_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdswiezListeTowarow();
        }

        private void OdswiezListeTowarow()
        {
            try
            {
                var waluta = cmbBx_waluta.SelectedItem as string;
                var towary = dbService.GetTowarDodaj(waluta);
                foreach (var towar in towary)
                {
                    var wybranyTowar = WybraneTowary.FirstOrDefault(w => w.Kod == towar.Kod && w.Waluta == towar.Waluta);
                    if (wybranyTowar != null)
                    {
                        towar.WymaganaIlosc = wybranyTowar.WymaganaIlosc;
                    }
                }
                binSrc_towary.DataSource = null;
                binSrc_towary.DataSource = towary;
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_dodajNowyTowar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDodajNowyTowar frmDodajNowyTowar = new FrmDodajNowyTowar();
                frmDodajNowyTowar.ShowDialog();
                OdswiezListeTowarow();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
