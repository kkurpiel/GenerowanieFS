namespace GenerowanieXLSX
{
    partial class FrmGenerowanieXLSX
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbBx_rodzajDanych = new ComboBox();
            btn_generujDane = new Button();
            numUpDwn_iloscDanych = new NumericUpDown();
            lbl_iloscDanych = new Label();
            txtBx_kodPocztowy = new TextBox();
            lbl_kodPocztowy = new Label();
            txtBx_ulica = new TextBox();
            lbl_ulica = new Label();
            txtBx_adres = new TextBox();
            lbl_adres = new Label();
            txtBx_akronim = new TextBox();
            lbl_akronim = new Label();
            txtBx_nazwa = new TextBox();
            lbl_nazwa = new Label();
            txtBx_kod = new TextBox();
            lbl_kod = new Label();
            dateTimePicker2 = new DateTimePicker();
            lbl_dataNabycia = new Label();
            txtBx_cenaNetto = new TextBox();
            lbl_cenaNetto = new Label();
            lbl_waluta = new Label();
            cmbBx_waluta = new ComboBox();
            lbl_ilosc = new Label();
            numUpDwn_ilosc = new NumericUpDown();
            cmbBx_jm = new ComboBox();
            lbl_jm = new Label();
            txtBx_vat = new TextBox();
            lbl_vat = new Label();
            txtBx_email = new TextBox();
            lbl_email = new Label();
            lbl_start = new Label();
            numUpDwn_start = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numUpDwn_iloscDanych).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDwn_ilosc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDwn_start).BeginInit();
            SuspendLayout();
            // 
            // cmbBx_rodzajDanych
            // 
            cmbBx_rodzajDanych.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbBx_rodzajDanych.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBx_rodzajDanych.FormattingEnabled = true;
            cmbBx_rodzajDanych.Items.AddRange(new object[] { "Kontrahenci", "Ceny", "Towary" });
            cmbBx_rodzajDanych.Location = new Point(12, 12);
            cmbBx_rodzajDanych.Name = "cmbBx_rodzajDanych";
            cmbBx_rodzajDanych.Size = new Size(658, 28);
            cmbBx_rodzajDanych.TabIndex = 0;
            cmbBx_rodzajDanych.SelectedIndexChanged += cmbBx_rodzajDanych_SelectedIndexChanged;
            // 
            // btn_generujDane
            // 
            btn_generujDane.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_generujDane.Location = new Point(12, 295);
            btn_generujDane.Name = "btn_generujDane";
            btn_generujDane.Size = new Size(658, 50);
            btn_generujDane.TabIndex = 1;
            btn_generujDane.Text = "Generuj dane";
            btn_generujDane.UseVisualStyleBackColor = true;
            btn_generujDane.Click += btn_generujDane_Click;
            // 
            // numUpDwn_iloscDanych
            // 
            numUpDwn_iloscDanych.Location = new Point(111, 46);
            numUpDwn_iloscDanych.Name = "numUpDwn_iloscDanych";
            numUpDwn_iloscDanych.Size = new Size(70, 27);
            numUpDwn_iloscDanych.TabIndex = 2;
            // 
            // lbl_iloscDanych
            // 
            lbl_iloscDanych.AutoSize = true;
            lbl_iloscDanych.Location = new Point(12, 48);
            lbl_iloscDanych.Name = "lbl_iloscDanych";
            lbl_iloscDanych.Size = new Size(93, 20);
            lbl_iloscDanych.TabIndex = 3;
            lbl_iloscDanych.Text = "Ilość danych:";
            // 
            // txtBx_kodPocztowy
            // 
            txtBx_kodPocztowy.Location = new Point(125, 206);
            txtBx_kodPocztowy.Name = "txtBx_kodPocztowy";
            txtBx_kodPocztowy.Size = new Size(201, 27);
            txtBx_kodPocztowy.TabIndex = 21;
            // 
            // lbl_kodPocztowy
            // 
            lbl_kodPocztowy.AutoSize = true;
            lbl_kodPocztowy.Location = new Point(12, 209);
            lbl_kodPocztowy.Name = "lbl_kodPocztowy";
            lbl_kodPocztowy.Size = new Size(107, 20);
            lbl_kodPocztowy.TabIndex = 20;
            lbl_kodPocztowy.Text = "Kod pocztowy:";
            // 
            // txtBx_ulica
            // 
            txtBx_ulica.Location = new Point(63, 175);
            txtBx_ulica.Name = "txtBx_ulica";
            txtBx_ulica.Size = new Size(263, 27);
            txtBx_ulica.TabIndex = 19;
            // 
            // lbl_ulica
            // 
            lbl_ulica.AutoSize = true;
            lbl_ulica.Location = new Point(12, 178);
            lbl_ulica.Name = "lbl_ulica";
            lbl_ulica.Size = new Size(45, 20);
            lbl_ulica.TabIndex = 18;
            lbl_ulica.Text = "Ulica:";
            // 
            // txtBx_adres
            // 
            txtBx_adres.Location = new Point(68, 145);
            txtBx_adres.Name = "txtBx_adres";
            txtBx_adres.Size = new Size(258, 27);
            txtBx_adres.TabIndex = 17;
            // 
            // lbl_adres
            // 
            lbl_adres.AutoSize = true;
            lbl_adres.Location = new Point(12, 148);
            lbl_adres.Name = "lbl_adres";
            lbl_adres.Size = new Size(50, 20);
            lbl_adres.TabIndex = 16;
            lbl_adres.Text = "Adres:";
            // 
            // txtBx_akronim
            // 
            txtBx_akronim.Location = new Point(86, 112);
            txtBx_akronim.Name = "txtBx_akronim";
            txtBx_akronim.Size = new Size(240, 27);
            txtBx_akronim.TabIndex = 15;
            // 
            // lbl_akronim
            // 
            lbl_akronim.AutoSize = true;
            lbl_akronim.Location = new Point(12, 115);
            lbl_akronim.Name = "lbl_akronim";
            lbl_akronim.Size = new Size(68, 20);
            lbl_akronim.TabIndex = 14;
            lbl_akronim.Text = "Akronim:";
            // 
            // txtBx_nazwa
            // 
            txtBx_nazwa.Location = new Point(75, 79);
            txtBx_nazwa.Name = "txtBx_nazwa";
            txtBx_nazwa.Size = new Size(251, 27);
            txtBx_nazwa.TabIndex = 13;
            // 
            // lbl_nazwa
            // 
            lbl_nazwa.AutoSize = true;
            lbl_nazwa.Location = new Point(12, 82);
            lbl_nazwa.Name = "lbl_nazwa";
            lbl_nazwa.Size = new Size(57, 20);
            lbl_nazwa.TabIndex = 12;
            lbl_nazwa.Text = "Nazwa:";
            // 
            // txtBx_kod
            // 
            txtBx_kod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_kod.Location = new Point(443, 48);
            txtBx_kod.Name = "txtBx_kod";
            txtBx_kod.Size = new Size(227, 27);
            txtBx_kod.TabIndex = 23;
            // 
            // lbl_kod
            // 
            lbl_kod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_kod.AutoSize = true;
            lbl_kod.Location = new Point(398, 53);
            lbl_kod.Name = "lbl_kod";
            lbl_kod.Size = new Size(39, 20);
            lbl_kod.TabIndex = 22;
            lbl_kod.Text = "Kod:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(443, 82);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(227, 27);
            dateTimePicker2.TabIndex = 25;
            // 
            // lbl_dataNabycia
            // 
            lbl_dataNabycia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_dataNabycia.AutoSize = true;
            lbl_dataNabycia.Location = new Point(361, 82);
            lbl_dataNabycia.Name = "lbl_dataNabycia";
            lbl_dataNabycia.Size = new Size(76, 20);
            lbl_dataNabycia.TabIndex = 26;
            lbl_dataNabycia.Text = "Data nab.:";
            // 
            // txtBx_cenaNetto
            // 
            txtBx_cenaNetto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_cenaNetto.Location = new Point(443, 112);
            txtBx_cenaNetto.Name = "txtBx_cenaNetto";
            txtBx_cenaNetto.Size = new Size(227, 27);
            txtBx_cenaNetto.TabIndex = 28;
            // 
            // lbl_cenaNetto
            // 
            lbl_cenaNetto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_cenaNetto.AutoSize = true;
            lbl_cenaNetto.Location = new Point(350, 115);
            lbl_cenaNetto.Name = "lbl_cenaNetto";
            lbl_cenaNetto.Size = new Size(87, 20);
            lbl_cenaNetto.TabIndex = 27;
            lbl_cenaNetto.Text = "Cena Netto:";
            // 
            // lbl_waluta
            // 
            lbl_waluta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_waluta.AutoSize = true;
            lbl_waluta.Location = new Point(379, 148);
            lbl_waluta.Name = "lbl_waluta";
            lbl_waluta.Size = new Size(58, 20);
            lbl_waluta.TabIndex = 29;
            lbl_waluta.Text = "Waluta:";
            // 
            // cmbBx_waluta
            // 
            cmbBx_waluta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbBx_waluta.FormattingEnabled = true;
            cmbBx_waluta.Items.AddRange(new object[] { "", "PLN", "EUR", "GBP", "USD", "HUF", "UAH", "CHF" });
            cmbBx_waluta.Location = new Point(443, 144);
            cmbBx_waluta.Name = "cmbBx_waluta";
            cmbBx_waluta.Size = new Size(227, 28);
            cmbBx_waluta.TabIndex = 30;
            // 
            // lbl_ilosc
            // 
            lbl_ilosc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_ilosc.AutoSize = true;
            lbl_ilosc.Location = new Point(395, 182);
            lbl_ilosc.Name = "lbl_ilosc";
            lbl_ilosc.Size = new Size(42, 20);
            lbl_ilosc.TabIndex = 32;
            lbl_ilosc.Text = "Ilość:";
            // 
            // numUpDwn_ilosc
            // 
            numUpDwn_ilosc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numUpDwn_ilosc.Location = new Point(443, 180);
            numUpDwn_ilosc.Name = "numUpDwn_ilosc";
            numUpDwn_ilosc.Size = new Size(227, 27);
            numUpDwn_ilosc.TabIndex = 31;
            // 
            // cmbBx_jm
            // 
            cmbBx_jm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbBx_jm.FormattingEnabled = true;
            cmbBx_jm.Items.AddRange(new object[] { "", "szt", "kg", "usł" });
            cmbBx_jm.Location = new Point(443, 213);
            cmbBx_jm.Name = "cmbBx_jm";
            cmbBx_jm.Size = new Size(227, 28);
            cmbBx_jm.TabIndex = 34;
            // 
            // lbl_jm
            // 
            lbl_jm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_jm.AutoSize = true;
            lbl_jm.Location = new Point(407, 216);
            lbl_jm.Name = "lbl_jm";
            lbl_jm.Size = new Size(30, 20);
            lbl_jm.TabIndex = 33;
            lbl_jm.Text = "JM:";
            // 
            // txtBx_vat
            // 
            txtBx_vat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_vat.Location = new Point(443, 247);
            txtBx_vat.Name = "txtBx_vat";
            txtBx_vat.Size = new Size(227, 27);
            txtBx_vat.TabIndex = 36;
            // 
            // lbl_vat
            // 
            lbl_vat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_vat.AutoSize = true;
            lbl_vat.Location = new Point(374, 250);
            lbl_vat.Name = "lbl_vat";
            lbl_vat.Size = new Size(63, 20);
            lbl_vat.TabIndex = 35;
            lbl_vat.Text = "VAT [%]:";
            // 
            // txtBx_email
            // 
            txtBx_email.Location = new Point(77, 239);
            txtBx_email.Name = "txtBx_email";
            txtBx_email.Size = new Size(249, 27);
            txtBx_email.TabIndex = 38;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(12, 242);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(59, 20);
            lbl_email.TabIndex = 37;
            lbl_email.Text = "E- mail:";
            // 
            // lbl_start
            // 
            lbl_start.AutoSize = true;
            lbl_start.Location = new Point(187, 48);
            lbl_start.Name = "lbl_start";
            lbl_start.Size = new Size(114, 20);
            lbl_start.TabIndex = 39;
            lbl_start.Text = "Pierwszy indeks:";
            // 
            // numUpDwn_start
            // 
            numUpDwn_start.Location = new Point(307, 46);
            numUpDwn_start.Name = "numUpDwn_start";
            numUpDwn_start.Size = new Size(70, 27);
            numUpDwn_start.TabIndex = 40;
            // 
            // FrmGenerowanieXLSX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 353);
            Controls.Add(numUpDwn_start);
            Controls.Add(lbl_start);
            Controls.Add(txtBx_email);
            Controls.Add(lbl_email);
            Controls.Add(txtBx_vat);
            Controls.Add(lbl_vat);
            Controls.Add(cmbBx_jm);
            Controls.Add(lbl_jm);
            Controls.Add(lbl_ilosc);
            Controls.Add(numUpDwn_ilosc);
            Controls.Add(cmbBx_waluta);
            Controls.Add(lbl_waluta);
            Controls.Add(txtBx_cenaNetto);
            Controls.Add(lbl_cenaNetto);
            Controls.Add(lbl_dataNabycia);
            Controls.Add(dateTimePicker2);
            Controls.Add(txtBx_kod);
            Controls.Add(lbl_kod);
            Controls.Add(txtBx_kodPocztowy);
            Controls.Add(lbl_kodPocztowy);
            Controls.Add(txtBx_ulica);
            Controls.Add(lbl_ulica);
            Controls.Add(txtBx_adres);
            Controls.Add(lbl_adres);
            Controls.Add(txtBx_akronim);
            Controls.Add(lbl_akronim);
            Controls.Add(txtBx_nazwa);
            Controls.Add(lbl_nazwa);
            Controls.Add(lbl_iloscDanych);
            Controls.Add(numUpDwn_iloscDanych);
            Controls.Add(btn_generujDane);
            Controls.Add(cmbBx_rodzajDanych);
            Name = "FrmGenerowanieXLSX";
            Text = "Generowanie danych XLSX";
            ((System.ComponentModel.ISupportInitialize)numUpDwn_iloscDanych).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDwn_ilosc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDwn_start).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBx_rodzajDanych;
        private Button btn_generujDane;
        private NumericUpDown numUpDwn_iloscDanych;
        private Label lbl_iloscDanych;
        private TextBox txtBx_kodPocztowy;
        private Label lbl_kodPocztowy;
        private TextBox txtBx_ulica;
        private Label lbl_ulica;
        private TextBox txtBx_adres;
        private Label lbl_adres;
        private TextBox txtBx_akronim;
        private Label lbl_akronim;
        private TextBox txtBx_nazwa;
        private Label lbl_nazwa;
        private TextBox txtBx_kod;
        private Label lbl_kod;
        private DateTimePicker dateTimePicker2;
        private Label lbl_dataNabycia;
        private TextBox txtBx_cenaNetto;
        private Label lbl_cenaNetto;
        private Label lbl_waluta;
        private ComboBox cmbBx_waluta;
        private Label lbl_ilosc;
        private NumericUpDown numUpDwn_ilosc;
        private ComboBox cmbBx_jm;
        private Label lbl_jm;
        private TextBox txtBx_vat;
        private Label lbl_vat;
        private TextBox txtBx_email;
        private Label lbl_email;
        private Label lbl_start;
        private NumericUpDown numUpDwn_start;
    }
}
