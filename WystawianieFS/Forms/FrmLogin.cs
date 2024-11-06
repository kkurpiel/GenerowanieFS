using NLog;
using System.Security.Cryptography.X509Certificates;
using WystawianieFS.Models;
using WystawianieFS.Services;

namespace WystawianieFS
{
    public partial class FrmLogin : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        private DbService dbService = new DbService();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Zaloguj_Click(object sender, EventArgs e)
        {
            try
            {
                var user = dbService.Zaloguj(txtBx_pin.Text);
                if (user != null)
                {
                    FrmMenu frmMenu = new FrmMenu(user.IsAdmin);
                    frmMenu.Show();
                    logger.Info("Zalogowano pomyœlnie");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("B³êdny PIN. Spróbuj ponownie.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBx_pin.Text = string.Empty;
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void chkBx_pokazPIN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkBx_pokazPIN.Checked)
                {
                    txtBx_pin.PasswordChar = '\0';
                }
                else
                {
                    txtBx_pin.PasswordChar = '-';
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void txtBx_pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            catch (Exception ex) 
            {
                logger.Error(ex.Message);
            }
        }
    }
}
