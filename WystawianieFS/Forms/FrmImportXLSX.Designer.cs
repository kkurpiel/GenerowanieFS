namespace WystawianieFS
{
    partial class FrmImportXLSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportXLSX));
            btn_importXLSX = new Button();
            cmbBx_importXLSX = new ComboBox();
            pan1 = new Panel();
            lbl_warning = new Label();
            lbl_wybierztyp = new Label();
            btn_pobierzSzablon = new Button();
            lbl_wskazówki = new Label();
            opFlDlg_szablonXLSX = new OpenFileDialog();
            SuspendLayout();
            // 
            // btn_importXLSX
            // 
            btn_importXLSX.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_importXLSX.Location = new Point(12, 326);
            btn_importXLSX.Name = "btn_importXLSX";
            btn_importXLSX.Size = new Size(558, 65);
            btn_importXLSX.TabIndex = 0;
            btn_importXLSX.Text = "Importuj dane";
            btn_importXLSX.UseVisualStyleBackColor = true;
            btn_importXLSX.Click += btn_importXLSX_Click;
            // 
            // cmbBx_importXLSX
            // 
            cmbBx_importXLSX.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbBx_importXLSX.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBx_importXLSX.FormattingEnabled = true;
            cmbBx_importXLSX.Items.AddRange(new object[] { "", "Kontrahenci", "Towary", "Ceny", "Firmy" });
            cmbBx_importXLSX.Location = new Point(12, 170);
            cmbBx_importXLSX.Name = "cmbBx_importXLSX";
            cmbBx_importXLSX.Size = new Size(558, 39);
            cmbBx_importXLSX.TabIndex = 1;
            // 
            // pan1
            // 
            pan1.BackgroundImage = (Image)resources.GetObject("pan1.BackgroundImage");
            pan1.Location = new Point(12, 12);
            pan1.Name = "pan1";
            pan1.Size = new Size(96, 91);
            pan1.TabIndex = 2;
            // 
            // lbl_warning
            // 
            lbl_warning.AutoSize = true;
            lbl_warning.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_warning.Location = new Point(129, 28);
            lbl_warning.Name = "lbl_warning";
            lbl_warning.Size = new Size(441, 75);
            lbl_warning.TabIndex = 3;
            lbl_warning.Text = "Uwaga!\r\nCzynność którą podejmujesz modyfikuje bazę danych.\r\nZachowaj ostrożność.";
            // 
            // lbl_wybierztyp
            // 
            lbl_wybierztyp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_wybierztyp.AutoSize = true;
            lbl_wybierztyp.Location = new Point(12, 136);
            lbl_wybierztyp.Name = "lbl_wybierztyp";
            lbl_wybierztyp.Size = new Size(258, 31);
            lbl_wybierztyp.TabIndex = 4;
            lbl_wybierztyp.Text = "Wybierz typ dokumentu";
            // 
            // btn_pobierzSzablon
            // 
            btn_pobierzSzablon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_pobierzSzablon.Location = new Point(12, 215);
            btn_pobierzSzablon.Name = "btn_pobierzSzablon";
            btn_pobierzSzablon.Size = new Size(558, 49);
            btn_pobierzSzablon.TabIndex = 5;
            btn_pobierzSzablon.Text = "Pobierz szablon";
            btn_pobierzSzablon.UseVisualStyleBackColor = true;
            btn_pobierzSzablon.Click += btn_pobierzSzablon_Click;
            // 
            // lbl_wskazówki
            // 
            lbl_wskazówki.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_wskazówki.AutoSize = true;
            lbl_wskazówki.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_wskazówki.Location = new Point(12, 280);
            lbl_wskazówki.Name = "lbl_wskazówki";
            lbl_wskazówki.Size = new Size(384, 28);
            lbl_wskazówki.TabIndex = 6;
            lbl_wskazówki.Text = "Uzupełnij pobrany szablon i importuj dane";
            // 
            // opFlDlg_szablonXLSX
            // 
            opFlDlg_szablonXLSX.Filter = "Excel Files|*.xls;*xlsx";
            opFlDlg_szablonXLSX.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
            opFlDlg_szablonXLSX.RestoreDirectory = true;
            // 
            // FrmImportXLSX
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(582, 403);
            Controls.Add(lbl_wskazówki);
            Controls.Add(btn_pobierzSzablon);
            Controls.Add(lbl_wybierztyp);
            Controls.Add(lbl_warning);
            Controls.Add(pan1);
            Controls.Add(cmbBx_importXLSX);
            Controls.Add(btn_importXLSX);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FrmImportXLSX";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Import danych z pliku .xlsx";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_importXLSX;
        private ComboBox cmbBx_importXLSX;
        private Panel pan1;
        private Label lbl_warning;
        private Label lbl_wybierztyp;
        private Button btn_pobierzSzablon;
        private Label lbl_wskazówki;
        private OpenFileDialog opFlDlg_szablonXLSX;
    }
}