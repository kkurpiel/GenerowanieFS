namespace WystawianieFS
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            btn_importXLSX = new Button();
            btn_listaFaktur = new Button();
            btn_generujFakture = new Button();
            btn_wyloguj = new Button();
            btn_wyjdz = new Button();
            SuspendLayout();
            // 
            // btn_importXLSX
            // 
            btn_importXLSX.BackColor = Color.LightGreen;
            btn_importXLSX.Image = (Image)resources.GetObject("btn_importXLSX.Image");
            btn_importXLSX.Location = new Point(395, 12);
            btn_importXLSX.Name = "btn_importXLSX";
            btn_importXLSX.Size = new Size(375, 177);
            btn_importXLSX.TabIndex = 0;
            btn_importXLSX.Text = "Import danych .xlsx";
            btn_importXLSX.TextAlign = ContentAlignment.BottomCenter;
            btn_importXLSX.UseVisualStyleBackColor = false;
            btn_importXLSX.Click += btn_importXLSX_Click;
            // 
            // btn_listaFaktur
            // 
            btn_listaFaktur.BackColor = Color.LightGreen;
            btn_listaFaktur.Image = (Image)resources.GetObject("btn_listaFaktur.Image");
            btn_listaFaktur.Location = new Point(395, 195);
            btn_listaFaktur.Name = "btn_listaFaktur";
            btn_listaFaktur.Size = new Size(375, 263);
            btn_listaFaktur.TabIndex = 1;
            btn_listaFaktur.Text = "Lista faktur";
            btn_listaFaktur.TextAlign = ContentAlignment.BottomCenter;
            btn_listaFaktur.UseVisualStyleBackColor = false;
            btn_listaFaktur.Click += btn_listaFaktur_Click;
            // 
            // btn_generujFakture
            // 
            btn_generujFakture.BackColor = Color.LightGreen;
            btn_generujFakture.Image = (Image)resources.GetObject("btn_generujFakture.Image");
            btn_generujFakture.Location = new Point(12, 12);
            btn_generujFakture.Name = "btn_generujFakture";
            btn_generujFakture.Size = new Size(375, 446);
            btn_generujFakture.TabIndex = 2;
            btn_generujFakture.Text = "Generowanie Faktury";
            btn_generujFakture.TextAlign = ContentAlignment.BottomCenter;
            btn_generujFakture.UseVisualStyleBackColor = false;
            btn_generujFakture.Click += btn_generujFakture_Click;
            // 
            // btn_wyloguj
            // 
            btn_wyloguj.BackColor = Color.LightGreen;
            btn_wyloguj.Location = new Point(12, 464);
            btn_wyloguj.Name = "btn_wyloguj";
            btn_wyloguj.Size = new Size(375, 70);
            btn_wyloguj.TabIndex = 3;
            btn_wyloguj.Text = "Wyloguj się";
            btn_wyloguj.UseVisualStyleBackColor = false;
            btn_wyloguj.Click += btn_wyloguj_Click;
            // 
            // btn_wyjdz
            // 
            btn_wyjdz.BackColor = Color.LightGreen;
            btn_wyjdz.Location = new Point(393, 464);
            btn_wyjdz.Name = "btn_wyjdz";
            btn_wyjdz.Size = new Size(375, 70);
            btn_wyjdz.TabIndex = 4;
            btn_wyjdz.Text = "Wyjdź";
            btn_wyjdz.UseVisualStyleBackColor = false;
            btn_wyjdz.Click += btn_wyjdz_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(782, 553);
            Controls.Add(btn_wyjdz);
            Controls.Add(btn_wyloguj);
            Controls.Add(btn_generujFakture);
            Controls.Add(btn_listaFaktur);
            Controls.Add(btn_importXLSX);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Generowanie Faktur - menu";
            Resize += FrmMenu_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_listaFaktur;
        private Button btn_wyloguj;
        private Button btn_generujFakture;
        private Button btn_importXLSX;
        private Button btn_wyjdz;
    }
}