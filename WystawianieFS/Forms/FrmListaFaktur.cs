using NLog;
using WystawianieFS.Models.DBModels;
using WystawianieFS.Services;

namespace WystawianieFS
{
    public partial class FrmListaFaktur : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public bool IsAdmin;
        private DbService dbService = new DbService();
        public FrmListaFaktur(bool IsAdmin)
        {
            try
            {
                this.IsAdmin = IsAdmin;
                InitializeComponent();
                binSrc_listaFaktur.DataSource = dbService.GetAllFS();
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenu frmMenu = new FrmMenu(IsAdmin);
                frmMenu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void FrmListaFaktur_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dGV_listaFaktur.Rows)
                {
                    row.Cells["GenerujFSCol"].Value = "Generuj";
                    row.Cells["WyslijCol"].Value = "Wyślij";
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void dGV_listaFaktur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dGV_listaFaktur.Columns["GenerujFSCol"].Index && e.RowIndex >= 0)
                {
                    string fsNr = (string)dGV_listaFaktur.Rows[e.RowIndex].Cells["numerFakturyDataGridViewTextBoxColumn"].Value;
                    var fs = dbService.GetFS(fsNr);
                    if (fs != null)
                    {
                        dbService.GenerujFakturePdf(fs.NumerFaktury);
                        logger.Info("Wygenerowano kopię faktury o nr: "+fs.NumerFaktury);
                        MessageBox.Show("Plik został utworzony w Dokumentach.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (e.ColumnIndex == dGV_listaFaktur.Columns["WyslijCol"].Index && e.RowIndex >= 0)
                {
                    string fsNr = (string)dGV_listaFaktur.Rows[e.RowIndex].Cells["numerFakturyDataGridViewTextBoxColumn"].Value;
                    var fs = dbService.GetFS(fsNr);
                    if (fs != null)
                    {
                        string nazwaPliku = $"{fs.Nazwa} {fs.NumerFaktury.Replace("/", "-")}.pdf";
                        string sciezkaPliku = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nazwaPliku);
                        if (!File.Exists(sciezkaPliku))
                        {
                            dbService.GenerujFakturePdf(fs.NumerFaktury);
                            dbService.WyslijFakture(fs.NumerFaktury);
                            File.Delete(sciezkaPliku);
                            logger.Info("Wysłano kontrahentowi fakturę o nr: "+ fs.NumerFaktury);
                            MessageBox.Show($"Faktura {fs.NumerFaktury} została przesłana do kontrahenta.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dbService.WyslijFakture(fs.NumerFaktury);
                            logger.Info("Wysłano kontrahentowi fakturę o nr: " + fs.NumerFaktury);
                            MessageBox.Show($"Faktura {fs.NumerFaktury} została przesłana do kontrahenta.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Nie znaleziono faktury: {fs.NumerFaktury}.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_szukaj_Click(object sender, EventArgs e)
        {
            try
            {
                var szukaj = txtBx_szukaj.Text;
                if (!string.IsNullOrEmpty(szukaj))
                {
                    binSrc_listaFaktur.DataSource = dbService.SzukajFS(szukaj);
                    FrmListaFaktur_Load(sender, e);
                }
                else
                {
                    binSrc_listaFaktur.DataSource = dbService.GetAllFS();
                    FrmListaFaktur_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
