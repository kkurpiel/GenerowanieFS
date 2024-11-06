namespace WystawianieFS.Forms
{
    partial class FrmDodajNowyTowar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajNowyTowar));
            lbl_nazwa = new Label();
            lbl_kod = new Label();
            lbl_jm = new Label();
            lbl_vat = new Label();
            txtBx_nazwa = new TextBox();
            txtBx_kod = new TextBox();
            txtBx_jm = new TextBox();
            txtBx_vat = new TextBox();
            btn_dodajC = new Button();
            btn_anuluj = new Button();
            lbl_nowytowar = new Label();
            lbl_cena = new Label();
            cmbBx_towar = new ComboBox();
            lbl_towarID = new Label();
            lbl_dataNab = new Label();
            dTP_dataNab = new DateTimePicker();
            lbl_cenaNetto = new Label();
            txtBx_cenaNetto = new TextBox();
            lbl_waluta = new Label();
            lbl_ilosc = new Label();
            txtBx_ilosc = new TextBox();
            btn_dodajTwr = new Button();
            cmbBx_waluta = new ComboBox();
            SuspendLayout();
            // 
            // lbl_nazwa
            // 
            lbl_nazwa.AutoSize = true;
            lbl_nazwa.Location = new Point(53, 57);
            lbl_nazwa.Margin = new Padding(4, 0, 4, 0);
            lbl_nazwa.Name = "lbl_nazwa";
            lbl_nazwa.Size = new Size(74, 28);
            lbl_nazwa.TabIndex = 0;
            lbl_nazwa.Text = "Nazwa:";
            // 
            // lbl_kod
            // 
            lbl_kod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_kod.AutoSize = true;
            lbl_kod.Location = new Point(466, 57);
            lbl_kod.Name = "lbl_kod";
            lbl_kod.Size = new Size(52, 28);
            lbl_kod.TabIndex = 1;
            lbl_kod.Text = "Kod:";
            // 
            // lbl_jm
            // 
            lbl_jm.AutoSize = true;
            lbl_jm.Location = new Point(12, 97);
            lbl_jm.Name = "lbl_jm";
            lbl_jm.Size = new Size(115, 28);
            lbl_jm.TabIndex = 2;
            lbl_jm.Text = "Jedn. Miary:";
            // 
            // lbl_vat
            // 
            lbl_vat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_vat.AutoSize = true;
            lbl_vat.Location = new Point(436, 97);
            lbl_vat.Name = "lbl_vat";
            lbl_vat.Size = new Size(82, 28);
            lbl_vat.TabIndex = 3;
            lbl_vat.Text = "VAT [%]:";
            // 
            // txtBx_nazwa
            // 
            txtBx_nazwa.Location = new Point(135, 54);
            txtBx_nazwa.Name = "txtBx_nazwa";
            txtBx_nazwa.Size = new Size(250, 34);
            txtBx_nazwa.TabIndex = 4;
            // 
            // txtBx_kod
            // 
            txtBx_kod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_kod.Location = new Point(526, 54);
            txtBx_kod.Name = "txtBx_kod";
            txtBx_kod.Size = new Size(250, 34);
            txtBx_kod.TabIndex = 5;
            // 
            // txtBx_jm
            // 
            txtBx_jm.Location = new Point(135, 94);
            txtBx_jm.Name = "txtBx_jm";
            txtBx_jm.Size = new Size(250, 34);
            txtBx_jm.TabIndex = 6;
            // 
            // txtBx_vat
            // 
            txtBx_vat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_vat.Location = new Point(526, 94);
            txtBx_vat.Name = "txtBx_vat";
            txtBx_vat.Size = new Size(250, 34);
            txtBx_vat.TabIndex = 7;
            // 
            // btn_dodajC
            // 
            btn_dodajC.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_dodajC.BackColor = Color.LightGreen;
            btn_dodajC.Location = new Point(526, 291);
            btn_dodajC.Name = "btn_dodajC";
            btn_dodajC.Size = new Size(250, 42);
            btn_dodajC.TabIndex = 8;
            btn_dodajC.Text = "Dodaj cenę";
            btn_dodajC.UseVisualStyleBackColor = false;
            btn_dodajC.Click += btn_dodajC_Click;
            // 
            // btn_anuluj
            // 
            btn_anuluj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_anuluj.BackColor = Color.Tomato;
            btn_anuluj.Location = new Point(403, 291);
            btn_anuluj.Name = "btn_anuluj";
            btn_anuluj.Size = new Size(117, 42);
            btn_anuluj.TabIndex = 9;
            btn_anuluj.Text = "Anuluj";
            btn_anuluj.UseVisualStyleBackColor = false;
            btn_anuluj.Click += btn_anuluj_Click;
            // 
            // lbl_nowytowar
            // 
            lbl_nowytowar.AutoSize = true;
            lbl_nowytowar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_nowytowar.Location = new Point(12, 9);
            lbl_nowytowar.Name = "lbl_nowytowar";
            lbl_nowytowar.Size = new Size(165, 38);
            lbl_nowytowar.TabIndex = 10;
            lbl_nowytowar.Text = "Nowy towar";
            // 
            // lbl_cena
            // 
            lbl_cena.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_cena.AutoSize = true;
            lbl_cena.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_cena.Location = new Point(12, 154);
            lbl_cena.Name = "lbl_cena";
            lbl_cena.Size = new Size(154, 38);
            lbl_cena.TabIndex = 11;
            lbl_cena.Text = "Nowa cena";
            // 
            // cmbBx_towar
            // 
            cmbBx_towar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbBx_towar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBx_towar.FormattingEnabled = true;
            cmbBx_towar.Location = new Point(135, 201);
            cmbBx_towar.Name = "cmbBx_towar";
            cmbBx_towar.Size = new Size(250, 36);
            cmbBx_towar.TabIndex = 12;
            // 
            // lbl_towarID
            // 
            lbl_towarID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_towarID.AutoSize = true;
            lbl_towarID.Location = new Point(62, 204);
            lbl_towarID.Name = "lbl_towarID";
            lbl_towarID.Size = new Size(67, 28);
            lbl_towarID.TabIndex = 13;
            lbl_towarID.Text = "Towar:";
            // 
            // lbl_dataNab
            // 
            lbl_dataNab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_dataNab.AutoSize = true;
            lbl_dataNab.Location = new Point(391, 204);
            lbl_dataNab.Name = "lbl_dataNab";
            lbl_dataNab.Size = new Size(129, 28);
            lbl_dataNab.TabIndex = 14;
            lbl_dataNab.Text = "Data nabycia:";
            // 
            // dTP_dataNab
            // 
            dTP_dataNab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dTP_dataNab.Format = DateTimePickerFormat.Short;
            dTP_dataNab.Location = new Point(526, 199);
            dTP_dataNab.Name = "dTP_dataNab";
            dTP_dataNab.Size = new Size(250, 34);
            dTP_dataNab.TabIndex = 15;
            // 
            // lbl_cenaNetto
            // 
            lbl_cenaNetto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_cenaNetto.AutoSize = true;
            lbl_cenaNetto.Location = new Point(14, 254);
            lbl_cenaNetto.Name = "lbl_cenaNetto";
            lbl_cenaNetto.Size = new Size(115, 28);
            lbl_cenaNetto.TabIndex = 16;
            lbl_cenaNetto.Text = "Cena Netto:";
            // 
            // txtBx_cenaNetto
            // 
            txtBx_cenaNetto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBx_cenaNetto.Location = new Point(135, 251);
            txtBx_cenaNetto.Name = "txtBx_cenaNetto";
            txtBx_cenaNetto.Size = new Size(250, 34);
            txtBx_cenaNetto.TabIndex = 17;
            // 
            // lbl_waluta
            // 
            lbl_waluta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_waluta.AutoSize = true;
            lbl_waluta.Location = new Point(443, 254);
            lbl_waluta.Name = "lbl_waluta";
            lbl_waluta.Size = new Size(77, 28);
            lbl_waluta.TabIndex = 19;
            lbl_waluta.Text = "Waluta:";
            // 
            // lbl_ilosc
            // 
            lbl_ilosc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_ilosc.AutoSize = true;
            lbl_ilosc.Location = new Point(72, 299);
            lbl_ilosc.Name = "lbl_ilosc";
            lbl_ilosc.Size = new Size(55, 28);
            lbl_ilosc.TabIndex = 20;
            lbl_ilosc.Text = "Ilość:";
            // 
            // txtBx_ilosc
            // 
            txtBx_ilosc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBx_ilosc.Location = new Point(135, 296);
            txtBx_ilosc.Name = "txtBx_ilosc";
            txtBx_ilosc.Size = new Size(250, 34);
            txtBx_ilosc.TabIndex = 21;
            // 
            // btn_dodajTwr
            // 
            btn_dodajTwr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_dodajTwr.BackColor = Color.LightGreen;
            btn_dodajTwr.Location = new Point(526, 134);
            btn_dodajTwr.Name = "btn_dodajTwr";
            btn_dodajTwr.Size = new Size(250, 42);
            btn_dodajTwr.TabIndex = 22;
            btn_dodajTwr.Text = "Dodaj towar";
            btn_dodajTwr.UseVisualStyleBackColor = false;
            btn_dodajTwr.Click += btn_dodajTwr_Click;
            // 
            // cmbBx_waluta
            // 
            cmbBx_waluta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbBx_waluta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBx_waluta.FormattingEnabled = true;
            cmbBx_waluta.Items.AddRange(new object[] { "PLN", "EUR", "USD", "HUF", "GBP" });
            cmbBx_waluta.Location = new Point(526, 251);
            cmbBx_waluta.Name = "cmbBx_waluta";
            cmbBx_waluta.Size = new Size(250, 36);
            cmbBx_waluta.TabIndex = 23;
            // 
            // FrmDodajNowyTowar
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(782, 353);
            Controls.Add(cmbBx_waluta);
            Controls.Add(btn_dodajTwr);
            Controls.Add(txtBx_ilosc);
            Controls.Add(lbl_ilosc);
            Controls.Add(lbl_waluta);
            Controls.Add(txtBx_cenaNetto);
            Controls.Add(lbl_cenaNetto);
            Controls.Add(dTP_dataNab);
            Controls.Add(lbl_dataNab);
            Controls.Add(lbl_towarID);
            Controls.Add(cmbBx_towar);
            Controls.Add(lbl_cena);
            Controls.Add(lbl_nowytowar);
            Controls.Add(btn_anuluj);
            Controls.Add(btn_dodajC);
            Controls.Add(txtBx_vat);
            Controls.Add(txtBx_jm);
            Controls.Add(txtBx_kod);
            Controls.Add(txtBx_nazwa);
            Controls.Add(lbl_vat);
            Controls.Add(lbl_jm);
            Controls.Add(lbl_kod);
            Controls.Add(lbl_nazwa);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmDodajNowyTowar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj nowy towar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nazwa;
        private Label lbl_kod;
        private Label lbl_jm;
        private Label lbl_vat;
        private TextBox txtBx_nazwa;
        private TextBox txtBx_kod;
        private TextBox txtBx_jm;
        private TextBox txtBx_vat;
        private Button btn_dodajC;
        private Button btn_anuluj;
        private Label lbl_nowytowar;
        private Label lbl_cena;
        private ComboBox cmbBx_towar;
        private Label lbl_towarID;
        private Label lbl_dataNab;
        private DateTimePicker dTP_dataNab;
        private Label lbl_cenaNetto;
        private TextBox txtBx_cenaNetto;
        private Label lbl_waluta;
        private Label lbl_ilosc;
        private TextBox txtBx_ilosc;
        private Button btn_dodajTwr;
        private ComboBox cmbBx_waluta;
    }
}