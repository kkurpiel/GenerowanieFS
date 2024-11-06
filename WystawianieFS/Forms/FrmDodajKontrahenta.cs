using NLog;
using System.Text.RegularExpressions;
using WystawianieFS.Models.DBModels;
using WystawianieFS.Services;

namespace WystawianieFS.Forms
{
    public partial class FrmDodajKontrahenta : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        private DbService dbService = new DbService();
        public FrmDodajKontrahenta()
        {
            InitializeComponent();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtBx_nazwa.Text) &&
                    !string.IsNullOrWhiteSpace(txtBx_akronim.Text) && (txtBx_akronim.Text.Length <= 7) &&
                    !string.IsNullOrWhiteSpace(txtBx_nip.Text) && (txtBx_nip.Text.Length == 10) &&
                    !string.IsNullOrWhiteSpace(txtBx_miasto.Text) &&
                    !string.IsNullOrWhiteSpace(txtBx_ulica.Text) &&
                    !string.IsNullOrWhiteSpace(txtBx_kodPocztowy.Text) && (txtBx_kodPocztowy.Text.Length == 6) &&
                    !string.IsNullOrWhiteSpace(txtBx_email.Text) && CzyPoprawnyEmail(txtBx_email.Text))
                {
                    var kontrahent = new Kontrahent()
                    {
                        Nazwa = txtBx_nazwa.Text,
                        Akronim = txtBx_akronim.Text,
                        NIP = txtBx_nip.Text,
                        Miasto = txtBx_miasto.Text,
                        Ulica = txtBx_ulica.Text,
                        KodPocztowy = txtBx_kodPocztowy.Text,
                        Email = txtBx_email.Text
                    };
                    dbService.AddKontrahent(kontrahent);
                    logger.Info("Dodano nowego kontrahenta: "+ kontrahent.Akronim);
                    MessageBox.Show("Pomyślnie dodano nowego kontrahenta.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wprowadzono błędne dane lub nie wprowadzono wszystkich danych.", "Brakujące dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        private bool CzyPoprawnyEmail(string email)
        {
            string wzorEmail = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(wzorEmail);
            return regex.IsMatch(email);
        }
    }
}
