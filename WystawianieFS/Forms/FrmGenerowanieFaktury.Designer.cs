using WystawianieFS.Models;
using WystawianieFS.Models.DBModels;

namespace WystawianieFS
{
    partial class FrmGenerowanieFaktury
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerowanieFaktury));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            cmbBx_firma = new ComboBox();
            binSrc_wystawiajacy = new BindingSource(components);
            cmbBx_kontrahenci = new ComboBox();
            binSrc_kontrahenci = new BindingSource(components);
            lbl_wystawiający = new Label();
            txtBx_wystNazwa = new TextBox();
            txtBx_wystAdres = new TextBox();
            txtBx_wystNIP = new TextBox();
            lbl_wystNazwa = new Label();
            lbl_wystNIP = new Label();
            lbl_wystAdres = new Label();
            lbl_kontrahent = new Label();
            btn_kontrDodaj = new Button();
            lbl_kontrAdres = new Label();
            lbl_kontrNIP = new Label();
            lbl_kontrNazwa = new Label();
            txtBx_kontrNIP = new TextBox();
            txtBx_kontrAdres = new TextBox();
            txtBx_kontrNazwa = new TextBox();
            dGV_towary = new DataGridView();
            nazwaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataNabycia = new DataGridViewTextBoxColumn();
            vATDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CenaNetto = new DataGridViewTextBoxColumn();
            CenaBrutto = new DataGridViewTextBoxColumn();
            Waluta = new DataGridViewTextBoxColumn();
            CNprzelicz = new DataGridViewTextBoxColumn();
            CBprzelicz = new DataGridViewTextBoxColumn();
            jMDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Ilosc = new DataGridViewTextBoxColumn();
            IsClicked = new DataGridViewCheckBoxColumn();
            binSrc_wybraneTowary = new BindingSource(components);
            btn_dodajTowar = new Button();
            btn_usunTowar = new Button();
            btn_generujFakture = new Button();
            lbl_dataWyst = new Label();
            lbl_dataSprz = new Label();
            dTP_dataWyst = new DateTimePicker();
            dTP_dataSprz = new DateTimePicker();
            btn_menu = new Button();
            ((System.ComponentModel.ISupportInitialize)binSrc_wystawiajacy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binSrc_kontrahenci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGV_towary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binSrc_wybraneTowary).BeginInit();
            SuspendLayout();
            // 
            // cmbBx_firma
            // 
            cmbBx_firma.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbBx_firma.DataSource = binSrc_wystawiajacy;
            cmbBx_firma.DisplayMember = "CmbBx_firma";
            cmbBx_firma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBx_firma.FormattingEnabled = true;
            cmbBx_firma.Location = new Point(152, 6);
            cmbBx_firma.Margin = new Padding(4);
            cmbBx_firma.Name = "cmbBx_firma";
            cmbBx_firma.Size = new Size(1317, 36);
            cmbBx_firma.TabIndex = 0;
            cmbBx_firma.SelectedIndexChanged += cmbBx_firma_SelectedIndexChanged;
            // 
            // binSrc_wystawiajacy
            // 
            binSrc_wystawiajacy.DataSource = typeof(Firma);
            // 
            // cmbBx_kontrahenci
            // 
            cmbBx_kontrahenci.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbBx_kontrahenci.DataSource = binSrc_kontrahenci;
            cmbBx_kontrahenci.DisplayMember = "CmbBx_kontrahenci";
            cmbBx_kontrahenci.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBx_kontrahenci.FormattingEnabled = true;
            cmbBx_kontrahenci.Location = new Point(152, 134);
            cmbBx_kontrahenci.Margin = new Padding(4);
            cmbBx_kontrahenci.Name = "cmbBx_kontrahenci";
            cmbBx_kontrahenci.Size = new Size(1271, 36);
            cmbBx_kontrahenci.TabIndex = 1;
            cmbBx_kontrahenci.SelectedIndexChanged += cmbBx_kontrahenci_SelectedIndexChanged;
            // 
            // binSrc_kontrahenci
            // 
            binSrc_kontrahenci.DataSource = typeof(Kontrahent);
            // 
            // lbl_wystawiający
            // 
            lbl_wystawiający.AutoSize = true;
            lbl_wystawiający.Location = new Point(12, 6);
            lbl_wystawiający.Name = "lbl_wystawiający";
            lbl_wystawiający.Size = new Size(133, 28);
            lbl_wystawiający.TabIndex = 2;
            lbl_wystawiający.Text = "Wystawiający:";
            // 
            // txtBx_wystNazwa
            // 
            txtBx_wystNazwa.BackColor = Color.MintCream;
            txtBx_wystNazwa.Location = new Point(226, 49);
            txtBx_wystNazwa.Name = "txtBx_wystNazwa";
            txtBx_wystNazwa.ReadOnly = true;
            txtBx_wystNazwa.Size = new Size(362, 34);
            txtBx_wystNazwa.TabIndex = 3;
            // 
            // txtBx_wystAdres
            // 
            txtBx_wystAdres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBx_wystAdres.BackColor = Color.MintCream;
            txtBx_wystAdres.Location = new Point(226, 93);
            txtBx_wystAdres.Name = "txtBx_wystAdres";
            txtBx_wystAdres.ReadOnly = true;
            txtBx_wystAdres.Size = new Size(1243, 34);
            txtBx_wystAdres.TabIndex = 4;
            // 
            // txtBx_wystNIP
            // 
            txtBx_wystNIP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_wystNIP.BackColor = Color.MintCream;
            txtBx_wystNIP.Location = new Point(1119, 49);
            txtBx_wystNIP.Name = "txtBx_wystNIP";
            txtBx_wystNIP.ReadOnly = true;
            txtBx_wystNIP.Size = new Size(350, 34);
            txtBx_wystNIP.TabIndex = 7;
            // 
            // lbl_wystNazwa
            // 
            lbl_wystNazwa.AutoSize = true;
            lbl_wystNazwa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_wystNazwa.Location = new Point(152, 55);
            lbl_wystNazwa.Name = "lbl_wystNazwa";
            lbl_wystNazwa.Size = new Size(68, 25);
            lbl_wystNazwa.TabIndex = 8;
            lbl_wystNazwa.Text = "Nazwa:";
            // 
            // lbl_wystNIP
            // 
            lbl_wystNIP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_wystNIP.AutoSize = true;
            lbl_wystNIP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_wystNIP.Location = new Point(1070, 55);
            lbl_wystNIP.Name = "lbl_wystNIP";
            lbl_wystNIP.Size = new Size(44, 25);
            lbl_wystNIP.TabIndex = 9;
            lbl_wystNIP.Text = "NIP:";
            // 
            // lbl_wystAdres
            // 
            lbl_wystAdres.AutoSize = true;
            lbl_wystAdres.Location = new Point(154, 96);
            lbl_wystAdres.Name = "lbl_wystAdres";
            lbl_wystAdres.Size = new Size(66, 28);
            lbl_wystAdres.TabIndex = 10;
            lbl_wystAdres.Text = "Adres:";
            // 
            // lbl_kontrahent
            // 
            lbl_kontrahent.AutoSize = true;
            lbl_kontrahent.Location = new Point(12, 137);
            lbl_kontrahent.Name = "lbl_kontrahent";
            lbl_kontrahent.Size = new Size(114, 28);
            lbl_kontrahent.TabIndex = 11;
            lbl_kontrahent.Text = "Kontrahent:";
            // 
            // btn_kontrDodaj
            // 
            btn_kontrDodaj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_kontrDodaj.BackColor = Color.LightGreen;
            btn_kontrDodaj.Image = (Image)resources.GetObject("btn_kontrDodaj.Image");
            btn_kontrDodaj.Location = new Point(1430, 134);
            btn_kontrDodaj.Name = "btn_kontrDodaj";
            btn_kontrDodaj.Size = new Size(40, 36);
            btn_kontrDodaj.TabIndex = 12;
            btn_kontrDodaj.UseVisualStyleBackColor = false;
            btn_kontrDodaj.Click += btn_kontrDodaj_Click;
            // 
            // lbl_kontrAdres
            // 
            lbl_kontrAdres.AutoSize = true;
            lbl_kontrAdres.Location = new Point(152, 224);
            lbl_kontrAdres.Name = "lbl_kontrAdres";
            lbl_kontrAdres.Size = new Size(66, 28);
            lbl_kontrAdres.TabIndex = 18;
            lbl_kontrAdres.Text = "Adres:";
            // 
            // lbl_kontrNIP
            // 
            lbl_kontrNIP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_kontrNIP.AutoSize = true;
            lbl_kontrNIP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_kontrNIP.Location = new Point(1070, 183);
            lbl_kontrNIP.Name = "lbl_kontrNIP";
            lbl_kontrNIP.Size = new Size(44, 25);
            lbl_kontrNIP.TabIndex = 17;
            lbl_kontrNIP.Text = "NIP:";
            // 
            // lbl_kontrNazwa
            // 
            lbl_kontrNazwa.AutoSize = true;
            lbl_kontrNazwa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_kontrNazwa.Location = new Point(152, 183);
            lbl_kontrNazwa.Name = "lbl_kontrNazwa";
            lbl_kontrNazwa.Size = new Size(68, 25);
            lbl_kontrNazwa.TabIndex = 16;
            lbl_kontrNazwa.Text = "Nazwa:";
            // 
            // txtBx_kontrNIP
            // 
            txtBx_kontrNIP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_kontrNIP.BackColor = Color.MintCream;
            txtBx_kontrNIP.Location = new Point(1119, 177);
            txtBx_kontrNIP.Name = "txtBx_kontrNIP";
            txtBx_kontrNIP.ReadOnly = true;
            txtBx_kontrNIP.Size = new Size(350, 34);
            txtBx_kontrNIP.TabIndex = 15;
            // 
            // txtBx_kontrAdres
            // 
            txtBx_kontrAdres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBx_kontrAdres.BackColor = Color.MintCream;
            txtBx_kontrAdres.Location = new Point(226, 221);
            txtBx_kontrAdres.Name = "txtBx_kontrAdres";
            txtBx_kontrAdres.ReadOnly = true;
            txtBx_kontrAdres.Size = new Size(1243, 34);
            txtBx_kontrAdres.TabIndex = 14;
            // 
            // txtBx_kontrNazwa
            // 
            txtBx_kontrNazwa.BackColor = Color.MintCream;
            txtBx_kontrNazwa.Location = new Point(226, 177);
            txtBx_kontrNazwa.Name = "txtBx_kontrNazwa";
            txtBx_kontrNazwa.ReadOnly = true;
            txtBx_kontrNazwa.Size = new Size(362, 34);
            txtBx_kontrNazwa.TabIndex = 13;
            // 
            // dGV_towary
            // 
            dGV_towary.AllowUserToAddRows = false;
            dGV_towary.AllowUserToDeleteRows = false;
            dGV_towary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dGV_towary.AutoGenerateColumns = false;
            dGV_towary.BackgroundColor = Color.MintCream;
            dGV_towary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_towary.Columns.AddRange(new DataGridViewColumn[] { nazwaDataGridViewTextBoxColumn, kodDataGridViewTextBoxColumn, DataNabycia, vATDataGridViewTextBoxColumn, CenaNetto, CenaBrutto, Waluta, CNprzelicz, CBprzelicz, jMDataGridViewTextBoxColumn, Ilosc, IsClicked });
            dGV_towary.DataSource = binSrc_wybraneTowary;
            dGV_towary.Location = new Point(12, 261);
            dGV_towary.Name = "dGV_towary";
            dGV_towary.RowHeadersWidth = 51;
            dGV_towary.Size = new Size(1458, 462);
            dGV_towary.TabIndex = 19;
            dGV_towary.CellValueChanged += dGV_towary_CellValueChanged;
            dGV_towary.CurrentCellDirtyStateChanged += dGV_towary_CurrentCellDirtyStateChanged;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            nazwaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            dataGridViewCellStyle1.BackColor = Color.MintCream;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            nazwaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            nazwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            kodDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            dataGridViewCellStyle2.BackColor = Color.MintCream;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            kodDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            kodDataGridViewTextBoxColumn.MinimumWidth = 6;
            kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            kodDataGridViewTextBoxColumn.ReadOnly = true;
            kodDataGridViewTextBoxColumn.Width = 110;
            // 
            // DataNabycia
            // 
            DataNabycia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataNabycia.DataPropertyName = "DataNabycia";
            dataGridViewCellStyle3.BackColor = Color.MintCream;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            DataNabycia.DefaultCellStyle = dataGridViewCellStyle3;
            DataNabycia.HeaderText = "Data nab.";
            DataNabycia.MinimumWidth = 6;
            DataNabycia.Name = "DataNabycia";
            DataNabycia.ReadOnly = true;
            DataNabycia.Width = 125;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            vATDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            dataGridViewCellStyle4.BackColor = Color.MintCream;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            vATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            vATDataGridViewTextBoxColumn.HeaderText = "VAT [%]";
            vATDataGridViewTextBoxColumn.MinimumWidth = 6;
            vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            vATDataGridViewTextBoxColumn.ReadOnly = true;
            vATDataGridViewTextBoxColumn.Width = 110;
            // 
            // CenaNetto
            // 
            CenaNetto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CenaNetto.DataPropertyName = "CenaNetto";
            dataGridViewCellStyle5.BackColor = Color.MintCream;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            CenaNetto.DefaultCellStyle = dataGridViewCellStyle5;
            CenaNetto.HeaderText = "C. Netto";
            CenaNetto.MinimumWidth = 6;
            CenaNetto.Name = "CenaNetto";
            CenaNetto.ReadOnly = true;
            CenaNetto.Width = 120;
            // 
            // CenaBrutto
            // 
            CenaBrutto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CenaBrutto.DataPropertyName = "CenaBrutto";
            dataGridViewCellStyle6.BackColor = Color.MintCream;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            CenaBrutto.DefaultCellStyle = dataGridViewCellStyle6;
            CenaBrutto.HeaderText = "C. Brutto";
            CenaBrutto.MinimumWidth = 6;
            CenaBrutto.Name = "CenaBrutto";
            CenaBrutto.ReadOnly = true;
            CenaBrutto.Width = 120;
            // 
            // Waluta
            // 
            Waluta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Waluta.DataPropertyName = "Waluta";
            dataGridViewCellStyle7.BackColor = Color.MintCream;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            Waluta.DefaultCellStyle = dataGridViewCellStyle7;
            Waluta.HeaderText = "Waluta";
            Waluta.MinimumWidth = 6;
            Waluta.Name = "Waluta";
            Waluta.ReadOnly = true;
            Waluta.Width = 75;
            // 
            // CNprzelicz
            // 
            CNprzelicz.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CNprzelicz.DataPropertyName = "CNprzelicz";
            dataGridViewCellStyle8.BackColor = Color.MintCream;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            CNprzelicz.DefaultCellStyle = dataGridViewCellStyle8;
            CNprzelicz.HeaderText = "C.N. przel.";
            CNprzelicz.MinimumWidth = 6;
            CNprzelicz.Name = "CNprzelicz";
            CNprzelicz.ReadOnly = true;
            CNprzelicz.Width = 130;
            // 
            // CBprzelicz
            // 
            CBprzelicz.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CBprzelicz.DataPropertyName = "CBprzelicz";
            dataGridViewCellStyle9.BackColor = Color.MintCream;
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            CBprzelicz.DefaultCellStyle = dataGridViewCellStyle9;
            CBprzelicz.HeaderText = "C.B. przel.";
            CBprzelicz.MinimumWidth = 6;
            CBprzelicz.Name = "CBprzelicz";
            CBprzelicz.ReadOnly = true;
            CBprzelicz.Width = 130;
            // 
            // jMDataGridViewTextBoxColumn
            // 
            jMDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            jMDataGridViewTextBoxColumn.DataPropertyName = "JM";
            dataGridViewCellStyle10.BackColor = Color.MintCream;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            jMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            jMDataGridViewTextBoxColumn.HeaderText = "JM";
            jMDataGridViewTextBoxColumn.MinimumWidth = 6;
            jMDataGridViewTextBoxColumn.Name = "jMDataGridViewTextBoxColumn";
            jMDataGridViewTextBoxColumn.ReadOnly = true;
            jMDataGridViewTextBoxColumn.Width = 60;
            // 
            // Ilosc
            // 
            Ilosc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ilosc.DataPropertyName = "Ilosc";
            dataGridViewCellStyle11.BackColor = Color.MintCream;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.Format = "N3";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            Ilosc.DefaultCellStyle = dataGridViewCellStyle11;
            Ilosc.HeaderText = "Ilość";
            Ilosc.MinimumWidth = 6;
            Ilosc.Name = "Ilosc";
            Ilosc.ReadOnly = true;
            Ilosc.Width = 110;
            // 
            // IsClicked
            // 
            IsClicked.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IsClicked.DataPropertyName = "IsClicked";
            IsClicked.HeaderText = "Wybr.";
            IsClicked.MinimumWidth = 6;
            IsClicked.Name = "IsClicked";
            IsClicked.Width = 75;
            // 
            // binSrc_wybraneTowary
            // 
            binSrc_wybraneTowary.DataSource = typeof(PozycjeNaFakturzeView);
            // 
            // btn_dodajTowar
            // 
            btn_dodajTowar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_dodajTowar.BackColor = Color.LightGreen;
            btn_dodajTowar.Image = (Image)resources.GetObject("btn_dodajTowar.Image");
            btn_dodajTowar.Location = new Point(1430, 724);
            btn_dodajTowar.Name = "btn_dodajTowar";
            btn_dodajTowar.Size = new Size(36, 36);
            btn_dodajTowar.TabIndex = 20;
            btn_dodajTowar.UseVisualStyleBackColor = false;
            btn_dodajTowar.Click += btn_dodajTowar_Click;
            // 
            // btn_usunTowar
            // 
            btn_usunTowar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_usunTowar.BackColor = Color.Tomato;
            btn_usunTowar.Image = (Image)resources.GetObject("btn_usunTowar.Image");
            btn_usunTowar.Location = new Point(1387, 724);
            btn_usunTowar.Name = "btn_usunTowar";
            btn_usunTowar.Size = new Size(36, 36);
            btn_usunTowar.TabIndex = 21;
            btn_usunTowar.UseVisualStyleBackColor = false;
            btn_usunTowar.Click += btn_usunTowar_Click;
            // 
            // btn_generujFakture
            // 
            btn_generujFakture.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_generujFakture.BackColor = Color.LimeGreen;
            btn_generujFakture.Image = (Image)resources.GetObject("btn_generujFakture.Image");
            btn_generujFakture.ImageAlign = ContentAlignment.MiddleLeft;
            btn_generujFakture.Location = new Point(1120, 766);
            btn_generujFakture.Name = "btn_generujFakture";
            btn_generujFakture.Size = new Size(350, 55);
            btn_generujFakture.TabIndex = 22;
            btn_generujFakture.Text = "Generuj fakturę";
            btn_generujFakture.UseVisualStyleBackColor = false;
            btn_generujFakture.Click += btn_generujFakture_Click;
            // 
            // lbl_dataWyst
            // 
            lbl_dataWyst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_dataWyst.AutoSize = true;
            lbl_dataWyst.Location = new Point(11, 753);
            lbl_dataWyst.Name = "lbl_dataWyst";
            lbl_dataWyst.Size = new Size(166, 28);
            lbl_dataWyst.TabIndex = 23;
            lbl_dataWyst.Text = "Data wystawienia:";
            // 
            // lbl_dataSprz
            // 
            lbl_dataSprz.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_dataSprz.AutoSize = true;
            lbl_dataSprz.Location = new Point(12, 793);
            lbl_dataSprz.Name = "lbl_dataSprz";
            lbl_dataSprz.Size = new Size(149, 28);
            lbl_dataSprz.TabIndex = 25;
            lbl_dataSprz.Text = "Data sprzedaży:";
            // 
            // dTP_dataWyst
            // 
            dTP_dataWyst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dTP_dataWyst.Format = DateTimePickerFormat.Short;
            dTP_dataWyst.Location = new Point(207, 748);
            dTP_dataWyst.Name = "dTP_dataWyst";
            dTP_dataWyst.Size = new Size(185, 34);
            dTP_dataWyst.TabIndex = 26;
            dTP_dataWyst.ValueChanged += dTP_dataWyst_ValueChanged;
            // 
            // dTP_dataSprz
            // 
            dTP_dataSprz.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dTP_dataSprz.Format = DateTimePickerFormat.Short;
            dTP_dataSprz.Location = new Point(207, 788);
            dTP_dataSprz.Name = "dTP_dataSprz";
            dTP_dataSprz.Size = new Size(185, 34);
            dTP_dataSprz.TabIndex = 27;
            // 
            // btn_menu
            // 
            btn_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_menu.BackColor = Color.LightGreen;
            btn_menu.Location = new Point(917, 766);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(200, 55);
            btn_menu.TabIndex = 28;
            btn_menu.Text = "Menu";
            btn_menu.UseVisualStyleBackColor = false;
            btn_menu.Click += btn_menu_Click;
            // 
            // FrmGenerowanieFaktury
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1482, 833);
            Controls.Add(btn_menu);
            Controls.Add(dTP_dataSprz);
            Controls.Add(dTP_dataWyst);
            Controls.Add(lbl_dataSprz);
            Controls.Add(lbl_dataWyst);
            Controls.Add(btn_generujFakture);
            Controls.Add(btn_usunTowar);
            Controls.Add(btn_dodajTowar);
            Controls.Add(dGV_towary);
            Controls.Add(lbl_kontrAdres);
            Controls.Add(lbl_kontrNIP);
            Controls.Add(lbl_kontrNazwa);
            Controls.Add(txtBx_kontrNIP);
            Controls.Add(txtBx_kontrAdres);
            Controls.Add(txtBx_kontrNazwa);
            Controls.Add(btn_kontrDodaj);
            Controls.Add(lbl_kontrahent);
            Controls.Add(lbl_wystAdres);
            Controls.Add(lbl_wystNIP);
            Controls.Add(lbl_wystNazwa);
            Controls.Add(txtBx_wystNIP);
            Controls.Add(txtBx_wystAdres);
            Controls.Add(txtBx_wystNazwa);
            Controls.Add(lbl_wystawiający);
            Controls.Add(cmbBx_kontrahenci);
            Controls.Add(cmbBx_firma);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmGenerowanieFaktury";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generowanie Faktury";
            ((System.ComponentModel.ISupportInitialize)binSrc_wystawiajacy).EndInit();
            ((System.ComponentModel.ISupportInitialize)binSrc_kontrahenci).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGV_towary).EndInit();
            ((System.ComponentModel.ISupportInitialize)binSrc_wybraneTowary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBx_firma;
        private ComboBox cmbBx_kontrahenci;
        private Label lbl_wystawiający;
        private TextBox txtBx_wystNazwa;
        private TextBox txtBx_wystAdres;
        private TextBox txtBx_wystNIP;
        private Label lbl_wystNazwa;
        private Label lbl_wystNIP;
        private Label lbl_wystAdres;
        private Label lbl_kontrahent;
        private Button btn_kontrDodaj;
        private Label lbl_kontrAdres;
        private Label lbl_kontrNIP;
        private Label lbl_kontrNazwa;
        private TextBox txtBx_kontrNIP;
        private TextBox txtBx_kontrAdres;
        private TextBox txtBx_kontrNazwa;
        private DataGridView dGV_towary;
        private Button btn_dodajTowar;
        private Button btn_usunTowar;
        private Button btn_generujFakture;
        private BindingSource binSrc_wybraneTowary;
        private BindingSource binSrc_wystawiajacy;
        private BindingSource binSrc_kontrahenci;
        private Label lbl_dataWyst;
        private Label lbl_dataSprz;
        private DateTimePicker dTP_dataWyst;
        private DateTimePicker dTP_dataSprz;
        private DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DataNabycia;
        private DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CenaNetto;
        private DataGridViewTextBoxColumn CenaBrutto;
        private DataGridViewTextBoxColumn Waluta;
        private DataGridViewTextBoxColumn CNprzelicz;
        private DataGridViewTextBoxColumn CBprzelicz;
        private DataGridViewTextBoxColumn jMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Ilosc;
        private DataGridViewCheckBoxColumn IsClicked;
        private Button btn_menu;
    }
}