using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WystawianieFS.Models;

namespace WystawianieFS
{
    public partial class FrmMenu : Form
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        private Size formSize;
        private Rectangle recBtn_wyloguj;
        private Rectangle recBtn_wyjdz;
        private Rectangle recBtn_generujFakture;
        private Rectangle recBtn_importTXT;
        private Rectangle recBtn_importXLS;
        private bool IsAdmin;
        public FrmMenu(bool IsAdmin)
        {
            try
            {
                this.IsAdmin = IsAdmin;
                InitializeComponent();
                this.Resize += FrmMenu_Resize;
                formSize = this.Size;
                recBtn_wyloguj = new Rectangle(btn_wyloguj.Location, btn_wyloguj.Size);
                recBtn_wyjdz = new Rectangle(btn_wyjdz.Location, btn_wyjdz.Size);
                recBtn_generujFakture = new Rectangle(btn_generujFakture.Location, btn_generujFakture.Size);
                recBtn_importTXT = new Rectangle(btn_listaFaktur.Location, btn_listaFaktur.Size);
                recBtn_importXLS = new Rectangle(btn_importXLSX.Location, btn_importXLSX.Size);
            }
            catch (Exception ex)
            {
                logger.Error("FrmMenu Init: " + ex.Message);
            }
        }

        private void btn_wyloguj_Click(object sender, EventArgs e)
        {
            try
            {
                var CzyWylogowac = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wyloguj się", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (CzyWylogowac == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin();
                    logger.Info("Wylogowano pomyślnie");
                    frmLogin.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_listaFaktur_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListaFaktur frmListaFaktur = new FrmListaFaktur(IsAdmin);
                frmListaFaktur.Show();
                logger.Info("Pozycja w menu: Lista Faktur");
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_importXLSX_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsAdmin)
                {
                    FrmImportXLSX frmImportXLSX = new FrmImportXLSX();
                    frmImportXLSX.ShowDialog();
                    logger.Info("Pozycja w menu: Import Plików .xlsx");
                }
                else
                {
                    MessageBox.Show("Import danych z szablonu kalkulacyjnego dostępny jest tylko dla administratora.", "Odmowa dostępu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_generujFakture_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGenerowanieFaktury frmGenerowanieFaktury = new FrmGenerowanieFaktury(IsAdmin);
                frmGenerowanieFaktury.Show();
                logger.Info("Pozycja w menu: Generowanie Faktur");
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            try
            {
                resize_Control(btn_wyloguj, recBtn_wyloguj);
                resize_Control(btn_wyjdz, recBtn_wyjdz);
                resize_Control(btn_generujFakture, recBtn_generujFakture);
                resize_Control(btn_listaFaktur, recBtn_importTXT);
                resize_Control(btn_importXLSX, recBtn_importXLS);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
        private void resize_Control(Control c, Rectangle r)
        {
            try
            {
                float xRatio = (float)(this.Width) / (float)(formSize.Width);
                float yRatio = (float)(this.Height) / (float)(formSize.Height);
                int newX = (int)(r.X * xRatio);
                int newY = (int)(r.Y * yRatio);

                int newWidth = (int)(r.Width * xRatio);
                int newHeight = (int)(r.Height * yRatio);

                c.Location = new Point(newX, newY);
                c.Size = new Size(newWidth, newHeight);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        private void btn_wyjdz_Click(object sender, EventArgs e)
        {
            try
            {
                var czyWyjsc = MessageBox.Show("Czy na pewno chcesz opuścić aplikację?", "Wyjdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (czyWyjsc == DialogResult.Yes)
                {
                    logger.Info("Zamknięcie aplikacji");
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
