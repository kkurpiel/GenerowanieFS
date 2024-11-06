namespace WystawianieFS.Forms
{
    partial class FrmDodajTowary
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajTowary));
            dGV_towary = new DataGridView();
            binSrc_towary = new BindingSource(components);
            btn_dodaj = new Button();
            btn_anuluj = new Button();
            lbl_waluta = new Label();
            cmbBx_waluta = new ComboBox();
            btn_dodajNowyTowar = new Button();
            nazwaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vATDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Waluta = new DataGridViewTextBoxColumn();
            Ilosc = new DataGridViewTextBoxColumn();
            JM = new DataGridViewTextBoxColumn();
            WymaganaIlosc = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dGV_towary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binSrc_towary).BeginInit();
            SuspendLayout();
            // 
            // dGV_towary
            // 
            dGV_towary.AllowUserToAddRows = false;
            dGV_towary.AllowUserToDeleteRows = false;
            dGV_towary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dGV_towary.AutoGenerateColumns = false;
            dGV_towary.BackgroundColor = Color.MintCream;
            dGV_towary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_towary.Columns.AddRange(new DataGridViewColumn[] { nazwaDataGridViewTextBoxColumn, kodDataGridViewTextBoxColumn, vATDataGridViewTextBoxColumn, Waluta, Ilosc, JM, WymaganaIlosc });
            dGV_towary.DataSource = binSrc_towary;
            dGV_towary.GridColor = SystemColors.ControlText;
            dGV_towary.Location = new Point(0, 49);
            dGV_towary.Margin = new Padding(4);
            dGV_towary.Name = "dGV_towary";
            dGV_towary.RowHeadersWidth = 51;
            dGV_towary.Size = new Size(1262, 559);
            dGV_towary.TabIndex = 0;
            // 
            // binSrc_towary
            // 
            binSrc_towary.DataSource = typeof(Models.PozycjeNaFakturzeView);
            // 
            // btn_dodaj
            // 
            btn_dodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_dodaj.BackColor = Color.LightGreen;
            btn_dodaj.Location = new Point(1102, 615);
            btn_dodaj.Name = "btn_dodaj";
            btn_dodaj.Size = new Size(148, 46);
            btn_dodaj.TabIndex = 1;
            btn_dodaj.Text = "Dodaj";
            btn_dodaj.UseVisualStyleBackColor = false;
            btn_dodaj.Click += btn_dodaj_Click;
            // 
            // btn_anuluj
            // 
            btn_anuluj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_anuluj.BackColor = Color.Tomato;
            btn_anuluj.Location = new Point(948, 615);
            btn_anuluj.Name = "btn_anuluj";
            btn_anuluj.Size = new Size(148, 46);
            btn_anuluj.TabIndex = 2;
            btn_anuluj.Text = "Anuluj";
            btn_anuluj.UseVisualStyleBackColor = false;
            btn_anuluj.Click += btn_anuluj_Click;
            // 
            // lbl_waluta
            // 
            lbl_waluta.AutoSize = true;
            lbl_waluta.Location = new Point(12, 9);
            lbl_waluta.Name = "lbl_waluta";
            lbl_waluta.Size = new Size(77, 28);
            lbl_waluta.TabIndex = 3;
            lbl_waluta.Text = "Waluta:";
            // 
            // cmbBx_waluta
            // 
            cmbBx_waluta.FormattingEnabled = true;
            cmbBx_waluta.Location = new Point(95, 6);
            cmbBx_waluta.Name = "cmbBx_waluta";
            cmbBx_waluta.Size = new Size(151, 36);
            cmbBx_waluta.TabIndex = 4;
            cmbBx_waluta.SelectedIndexChanged += cmbBx_waluta_SelectedIndexChanged;
            // 
            // btn_dodajNowyTowar
            // 
            btn_dodajNowyTowar.BackColor = Color.LightGreen;
            btn_dodajNowyTowar.Location = new Point(948, 6);
            btn_dodajNowyTowar.Name = "btn_dodajNowyTowar";
            btn_dodajNowyTowar.Size = new Size(302, 36);
            btn_dodajNowyTowar.TabIndex = 5;
            btn_dodajNowyTowar.Text = "Dodaj nowy towar";
            btn_dodajNowyTowar.UseVisualStyleBackColor = false;
            btn_dodajNowyTowar.Click += btn_dodajNowyTowar_Click;
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
            kodDataGridViewTextBoxColumn.Width = 125;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            dataGridViewCellStyle3.BackColor = Color.MintCream;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            vATDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            vATDataGridViewTextBoxColumn.HeaderText = "VAT [%]";
            vATDataGridViewTextBoxColumn.MinimumWidth = 6;
            vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            vATDataGridViewTextBoxColumn.ReadOnly = true;
            vATDataGridViewTextBoxColumn.Width = 125;
            // 
            // Waluta
            // 
            Waluta.DataPropertyName = "Waluta";
            dataGridViewCellStyle4.BackColor = Color.MintCream;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            Waluta.DefaultCellStyle = dataGridViewCellStyle4;
            Waluta.HeaderText = "Waluta";
            Waluta.MinimumWidth = 6;
            Waluta.Name = "Waluta";
            Waluta.ReadOnly = true;
            Waluta.Width = 125;
            // 
            // Ilosc
            // 
            Ilosc.DataPropertyName = "Ilosc";
            dataGridViewCellStyle5.BackColor = Color.MintCream;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            Ilosc.DefaultCellStyle = dataGridViewCellStyle5;
            Ilosc.HeaderText = "Dost. ilość";
            Ilosc.MinimumWidth = 6;
            Ilosc.Name = "Ilosc";
            Ilosc.ReadOnly = true;
            Ilosc.Width = 150;
            // 
            // JM
            // 
            JM.DataPropertyName = "JM";
            dataGridViewCellStyle6.BackColor = Color.MintCream;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            JM.DefaultCellStyle = dataGridViewCellStyle6;
            JM.HeaderText = "JM";
            JM.MinimumWidth = 6;
            JM.Name = "JM";
            JM.ReadOnly = true;
            JM.Width = 125;
            // 
            // WymaganaIlosc
            // 
            WymaganaIlosc.DataPropertyName = "WymaganaIlosc";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.MintCream;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            WymaganaIlosc.DefaultCellStyle = dataGridViewCellStyle7;
            WymaganaIlosc.HeaderText = "Ilość";
            WymaganaIlosc.MinimumWidth = 6;
            WymaganaIlosc.Name = "WymaganaIlosc";
            WymaganaIlosc.Width = 200;
            // 
            // FrmDodajTowary
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1262, 673);
            Controls.Add(btn_dodajNowyTowar);
            Controls.Add(cmbBx_waluta);
            Controls.Add(lbl_waluta);
            Controls.Add(btn_anuluj);
            Controls.Add(btn_dodaj);
            Controls.Add(dGV_towary);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmDodajTowary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj towary";
            ((System.ComponentModel.ISupportInitialize)dGV_towary).EndInit();
            ((System.ComponentModel.ISupportInitialize)binSrc_towary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGV_towary;
        private Button btn_dodaj;
        private BindingSource binSrc_towary;
        private Button btn_anuluj;
        private Label lbl_waluta;
        private ComboBox cmbBx_waluta;
        private Button btn_dodajNowyTowar;
        private DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Waluta;
        private DataGridViewTextBoxColumn Ilosc;
        private DataGridViewTextBoxColumn JM;
        private DataGridViewTextBoxColumn WymaganaIlosc;
    }
}