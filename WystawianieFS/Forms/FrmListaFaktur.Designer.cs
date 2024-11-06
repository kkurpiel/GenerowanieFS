namespace WystawianieFS
{
    partial class FrmListaFaktur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaFaktur));
            dGV_listaFaktur = new DataGridView();
            nazwaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numerFakturyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataWystawieniaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            WyslijCol = new DataGridViewButtonColumn();
            GenerujFSCol = new DataGridViewButtonColumn();
            binSrc_listaFaktur = new BindingSource(components);
            btn_menu = new Button();
            lbl_Szukaj = new Label();
            txtBx_szukaj = new TextBox();
            btn_szukaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dGV_listaFaktur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binSrc_listaFaktur).BeginInit();
            SuspendLayout();
            // 
            // dGV_listaFaktur
            // 
            dGV_listaFaktur.AllowUserToAddRows = false;
            dGV_listaFaktur.AllowUserToDeleteRows = false;
            dGV_listaFaktur.AutoGenerateColumns = false;
            dGV_listaFaktur.BackgroundColor = Color.MintCream;
            dGV_listaFaktur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_listaFaktur.Columns.AddRange(new DataGridViewColumn[] { nazwaDataGridViewTextBoxColumn, numerFakturyDataGridViewTextBoxColumn, dataWystawieniaDataGridViewTextBoxColumn, WyslijCol, GenerujFSCol });
            dGV_listaFaktur.DataSource = binSrc_listaFaktur;
            dGV_listaFaktur.Dock = DockStyle.Bottom;
            dGV_listaFaktur.GridColor = Color.Black;
            dGV_listaFaktur.Location = new Point(0, 60);
            dGV_listaFaktur.Margin = new Padding(4);
            dGV_listaFaktur.Name = "dGV_listaFaktur";
            dGV_listaFaktur.ReadOnly = true;
            dGV_listaFaktur.RowHeadersWidth = 51;
            dGV_listaFaktur.Size = new Size(982, 643);
            dGV_listaFaktur.TabIndex = 0;
            dGV_listaFaktur.CellContentClick += dGV_listaFaktur_CellContentClick;
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
            // numerFakturyDataGridViewTextBoxColumn
            // 
            numerFakturyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            numerFakturyDataGridViewTextBoxColumn.DataPropertyName = "NumerFaktury";
            dataGridViewCellStyle2.BackColor = Color.MintCream;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            numerFakturyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            numerFakturyDataGridViewTextBoxColumn.HeaderText = "NumerFaktury";
            numerFakturyDataGridViewTextBoxColumn.MinimumWidth = 6;
            numerFakturyDataGridViewTextBoxColumn.Name = "numerFakturyDataGridViewTextBoxColumn";
            numerFakturyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataWystawieniaDataGridViewTextBoxColumn
            // 
            dataWystawieniaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataWystawieniaDataGridViewTextBoxColumn.DataPropertyName = "DataWystawienia";
            dataGridViewCellStyle3.BackColor = Color.MintCream;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataWystawieniaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            dataWystawieniaDataGridViewTextBoxColumn.HeaderText = "DataWystawienia";
            dataWystawieniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataWystawieniaDataGridViewTextBoxColumn.Name = "dataWystawieniaDataGridViewTextBoxColumn";
            dataWystawieniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WyslijCol
            // 
            WyslijCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.MintCream;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            WyslijCol.DefaultCellStyle = dataGridViewCellStyle4;
            WyslijCol.HeaderText = "Wyślij";
            WyslijCol.MinimumWidth = 6;
            WyslijCol.Name = "WyslijCol";
            WyslijCol.ReadOnly = true;
            WyslijCol.Text = "Wyślij";
            // 
            // GenerujFSCol
            // 
            GenerujFSCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MintCream;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            GenerujFSCol.DefaultCellStyle = dataGridViewCellStyle5;
            GenerujFSCol.HeaderText = "Generuj";
            GenerujFSCol.MinimumWidth = 6;
            GenerujFSCol.Name = "GenerujFSCol";
            GenerujFSCol.ReadOnly = true;
            GenerujFSCol.Text = "Generuj";
            // 
            // binSrc_listaFaktur
            // 
            binSrc_listaFaktur.DataSource = typeof(Models.DBModels.FS);
            // 
            // btn_menu
            // 
            btn_menu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_menu.BackColor = Color.LightGreen;
            btn_menu.Location = new Point(840, 12);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(130, 41);
            btn_menu.TabIndex = 1;
            btn_menu.Text = "Menu";
            btn_menu.UseVisualStyleBackColor = false;
            btn_menu.Click += btn_menu_Click;
            // 
            // lbl_Szukaj
            // 
            lbl_Szukaj.AutoSize = true;
            lbl_Szukaj.Location = new Point(12, 15);
            lbl_Szukaj.Name = "lbl_Szukaj";
            lbl_Szukaj.Size = new Size(71, 28);
            lbl_Szukaj.TabIndex = 2;
            lbl_Szukaj.Text = "Szukaj:";
            // 
            // txtBx_szukaj
            // 
            txtBx_szukaj.Location = new Point(89, 12);
            txtBx_szukaj.Name = "txtBx_szukaj";
            txtBx_szukaj.Size = new Size(250, 34);
            txtBx_szukaj.TabIndex = 3;
            // 
            // btn_szukaj
            // 
            btn_szukaj.BackColor = Color.LightGreen;
            btn_szukaj.Image = (Image)resources.GetObject("btn_szukaj.Image");
            btn_szukaj.Location = new Point(345, 6);
            btn_szukaj.Name = "btn_szukaj";
            btn_szukaj.Size = new Size(45, 45);
            btn_szukaj.TabIndex = 4;
            btn_szukaj.UseVisualStyleBackColor = false;
            btn_szukaj.Click += btn_szukaj_Click;
            // 
            // FrmListaFaktur
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(982, 703);
            Controls.Add(btn_szukaj);
            Controls.Add(txtBx_szukaj);
            Controls.Add(lbl_Szukaj);
            Controls.Add(btn_menu);
            Controls.Add(dGV_listaFaktur);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmListaFaktur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Faktur";
            Load += FrmListaFaktur_Load;
            ((System.ComponentModel.ISupportInitialize)dGV_listaFaktur).EndInit();
            ((System.ComponentModel.ISupportInitialize)binSrc_listaFaktur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGV_listaFaktur;
        private Button btn_menu;
        private BindingSource binSrc_listaFaktur;
        private Label lbl_Szukaj;
        private TextBox txtBx_szukaj;
        private Button btn_szukaj;
        private DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numerFakturyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataWystawieniaDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn WyslijCol;
        private DataGridViewButtonColumn GenerujFSCol;
    }
}