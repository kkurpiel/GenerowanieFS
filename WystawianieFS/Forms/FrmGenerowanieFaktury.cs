using NLog;
using WystawianieFS.Forms;
using WystawianieFS.Models;
using WystawianieFS.Models.DBModels;
using WystawianieFS.Services;

namespace WystawianieFS
{
    public partial class FrmGenerowanieFaktury : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public List<PozycjeNaFakturzeView> IlosciTowarow = new List<PozycjeNaFakturzeView>();
        List<PozycjeNaFakturzeView> WybraneTowaryCeny = new List<PozycjeNaFakturzeView>();
        private DbService dbService = new DbService();
        public bool IsAdmin;
        public FrmGenerowanieFaktury(bool IsAdmin)
        {
            try
            {
                this.IsAdmin = IsAdmin;
                InitializeComponent();
                binSrc_wystawiajacy.DataSource = dbService.GetFirma();
                binSrc_kontrahenci.DataSource = dbService.GetKontrahenci();
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        private void cmbBx_firma_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBx_firma.SelectedItem != null)
                {
                    var wybranaFirma = cmbBx_firma.SelectedItem as Firma;
                    if (wybranaFirma != null)
                    {
                        txtBx_wystNazwa.Text = wybranaFirma.Nazwa;
                        txtBx_wystNIP.Text = wybranaFirma.NIP;
                        txtBx_wystAdres.Text = wybranaFirma.Ulica + " " + wybranaFirma.Miasto + " " + wybranaFirma.KodPocztowy;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void cmbBx_kontrahenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBx_kontrahenci.SelectedItem != null)
                {
                    var wybranyKontrahent = cmbBx_kontrahenci.SelectedItem as Kontrahent;
                    if (wybranyKontrahent != null)
                    {
                        txtBx_kontrNazwa.Text = wybranyKontrahent.Nazwa;
                        txtBx_kontrNIP.Text = wybranyKontrahent.NIP;
                        txtBx_kontrAdres.Text = wybranyKontrahent.Ulica + " " + wybranyKontrahent.Miasto + " " + wybranyKontrahent.KodPocztowy;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_kontrDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDodajKontrahenta frmDodajKontrahenta = new FrmDodajKontrahenta();
                frmDodajKontrahenta.ShowDialog();
                binSrc_kontrahenci.DataSource = null;
                binSrc_kontrahenci.DataSource = dbService.GetKontrahenci();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private async void btn_dodajTowar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDodajTowary frmDodajTowary = new FrmDodajTowary(IlosciTowarow);
                if (frmDodajTowary.ShowDialog() == DialogResult.OK)
                {
                    this.IlosciTowarow = frmDodajTowary.WybraneTowary;
                    WybraneTowaryCeny = new List<PozycjeNaFakturzeView>();

                    foreach (var el in IlosciTowarow)
                    {
                        WybraneTowaryCeny.AddRange(await dbService.GetTowaryCenyViews(el, dTP_dataSprz.Value));
                    }
                    binSrc_wybraneTowary.DataSource = WybraneTowaryCeny;
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_usunTowar_Click(object sender, EventArgs e)
        {
            try
            {
                var towaryDoUsuniecia = new List<PozycjeNaFakturzeView>();
                var ilosciDoUsuniecia = new List<PozycjeNaFakturzeView>();
                foreach (var towar in WybraneTowaryCeny)
                {
                    if (towar.IsClicked)
                    {
                        var ilTwr = IlosciTowarow.FirstOrDefault(x => x.Kod == towar.Kod);
                        if (ilTwr != null)
                        {
                            towaryDoUsuniecia.Add(towar);
                            if (!ilosciDoUsuniecia.Any(i => i.Kod == ilTwr.Kod))
                                ilosciDoUsuniecia.Add(ilTwr);
                        }
                    }
                }
                foreach (var towar in towaryDoUsuniecia)
                {
                    WybraneTowaryCeny.Remove(towar);
                }
                foreach (var ilosc in ilosciDoUsuniecia)
                {
                    IlosciTowarow.Remove(ilosc);
                }
                binSrc_wybraneTowary.DataSource = null;
                binSrc_wybraneTowary.DataSource = WybraneTowaryCeny;
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        private void dGV_towary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dGV_towary.Columns[e.ColumnIndex].Name == "IsClicked")
                {
                    bool isChecked = (bool)dGV_towary.Rows[e.RowIndex].Cells["IsClicked"].Value;
                    string kodTowaru = dGV_towary.Rows[e.RowIndex].Cells["kodDataGridViewTextBoxColumn"].Value.ToString();

                    foreach (DataGridViewRow row in dGV_towary.Rows)
                    {
                        if (row.Cells["kodDataGridViewTextBoxColumn"].Value.ToString() == kodTowaru)
                        {
                            row.Cells["IsClicked"].Value = isChecked;
                        }
                    }
                    foreach (var towar in WybraneTowaryCeny)
                    {
                        if (towar.Kod == kodTowaru)
                        {
                            towar.IsClicked = isChecked;
                        }
                    }
                    dGV_towary.Refresh();
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void dGV_towary_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dGV_towary.IsCurrentCellDirty && dGV_towary.CurrentCell is DataGridViewCheckBoxCell)
                {
                    dGV_towary.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private async void dTP_dataWyst_ValueChanged(object sender, EventArgs e)
        {
            dTP_dataWyst.Enabled = false;

            try
            {
                var noweTowaryCeny = new List<PozycjeNaFakturzeView>();

                foreach (var el in WybraneTowaryCeny)
                {
                    var noweCeny = await dbService.GetTowaryCenyViews(el, dTP_dataWyst.Value);
                    noweTowaryCeny.AddRange(noweCeny);
                }
                WybraneTowaryCeny.Clear();
                WybraneTowaryCeny.AddRange(noweTowaryCeny);

                binSrc_wybraneTowary.DataSource = null;
                binSrc_wybraneTowary.DataSource = WybraneTowaryCeny;
                dGV_towary.ClearSelection();
                dGV_towary.Refresh();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Błąd podczas aktualizacji kursów walut");
                MessageBox.Show("Wystąpił problem podczas aktualizacji cen. Spróbuj ponownie.");
            }
            finally
            {
                dTP_dataWyst.Enabled = true;
            }
        }
        private void btn_generujFakture_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBx_kontrNIP.Text)
                    || string.IsNullOrEmpty(txtBx_wystNIP.Text)
                    || WybraneTowaryCeny.Count <= 0)
                {
                    MessageBox.Show("Uzupełnij dane wymagane do stworzenia faktury.", "Brak danych!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var numerFaktury = dbService.GenerujFaktureDB(txtBx_wystNIP.Text, txtBx_kontrNIP.Text, dTP_dataWyst.Value, dTP_dataSprz.Value, WybraneTowaryCeny);
                    cmbBx_firma.SelectedIndex = 0;
                    cmbBx_kontrahenci.SelectedIndex = 0;
                    WybraneTowaryCeny.Clear();
                    IlosciTowarow.Clear();
                    binSrc_wybraneTowary.DataSource = null;
                    binSrc_wybraneTowary.DataSource = WybraneTowaryCeny;
                    var czyStworzycFakture = MessageBox.Show("Czy chcesz wygenerować plik .pdf zawierający stworzoną fakturę?", "Sukces", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(czyStworzycFakture == DialogResult.Yes)
                    {
                        dbService.GenerujFakturePdf(numerFaktury);
                        logger.Info("Wygenerowano fakturę o nr: "+numerFaktury);
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            try
            {
                var czyWyjsc = MessageBox.Show("Czy na pewno chcesz zamknąć formularz?", "Zamykanie formularza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (czyWyjsc == DialogResult.Yes)
                {
                    FrmMenu frmMenu = new FrmMenu(IsAdmin);
                    frmMenu.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
