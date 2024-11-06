namespace WystawianieFS.Forms
{
    partial class FrmDodajKontrahenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajKontrahenta));
            lbl_nazwa = new Label();
            lbl_akronim = new Label();
            lbl_nip = new Label();
            lbl_miasto = new Label();
            lbl_ulica = new Label();
            lbl_kodPocztowy = new Label();
            txtBx_kodPocztowy = new TextBox();
            txtBx_ulica = new TextBox();
            txtBx_miasto = new TextBox();
            txtBx_nip = new TextBox();
            txtBx_akronim = new TextBox();
            txtBx_nazwa = new TextBox();
            btn_dodaj = new Button();
            btn_anuluj = new Button();
            txtBx_email = new TextBox();
            lbl_email = new Label();
            SuspendLayout();
            // 
            // lbl_nazwa
            // 
            lbl_nazwa.AutoSize = true;
            lbl_nazwa.Location = new Point(80, 15);
            lbl_nazwa.Name = "lbl_nazwa";
            lbl_nazwa.Size = new Size(74, 28);
            lbl_nazwa.TabIndex = 0;
            lbl_nazwa.Text = "Nazwa:";
            // 
            // lbl_akronim
            // 
            lbl_akronim.AutoSize = true;
            lbl_akronim.Location = new Point(63, 55);
            lbl_akronim.Name = "lbl_akronim";
            lbl_akronim.Size = new Size(91, 28);
            lbl_akronim.TabIndex = 1;
            lbl_akronim.Text = "Akronim:";
            // 
            // lbl_nip
            // 
            lbl_nip.AutoSize = true;
            lbl_nip.Location = new Point(102, 95);
            lbl_nip.Name = "lbl_nip";
            lbl_nip.Size = new Size(52, 28);
            lbl_nip.TabIndex = 2;
            lbl_nip.Text = "NIP: ";
            // 
            // lbl_miasto
            // 
            lbl_miasto.AutoSize = true;
            lbl_miasto.Location = new Point(78, 135);
            lbl_miasto.Name = "lbl_miasto";
            lbl_miasto.Size = new Size(76, 28);
            lbl_miasto.TabIndex = 3;
            lbl_miasto.Text = "Miasto:";
            // 
            // lbl_ulica
            // 
            lbl_ulica.AutoSize = true;
            lbl_ulica.Location = new Point(95, 175);
            lbl_ulica.Name = "lbl_ulica";
            lbl_ulica.Size = new Size(59, 28);
            lbl_ulica.TabIndex = 4;
            lbl_ulica.Text = "Ulica:";
            // 
            // lbl_kodPocztowy
            // 
            lbl_kodPocztowy.AutoSize = true;
            lbl_kodPocztowy.Location = new Point(12, 215);
            lbl_kodPocztowy.Name = "lbl_kodPocztowy";
            lbl_kodPocztowy.Size = new Size(142, 28);
            lbl_kodPocztowy.TabIndex = 5;
            lbl_kodPocztowy.Text = "Kod pocztowy:";
            // 
            // txtBx_kodPocztowy
            // 
            txtBx_kodPocztowy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_kodPocztowy.Location = new Point(160, 212);
            txtBx_kodPocztowy.Name = "txtBx_kodPocztowy";
            txtBx_kodPocztowy.Size = new Size(250, 34);
            txtBx_kodPocztowy.TabIndex = 6;
            // 
            // txtBx_ulica
            // 
            txtBx_ulica.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_ulica.Location = new Point(160, 172);
            txtBx_ulica.Name = "txtBx_ulica";
            txtBx_ulica.Size = new Size(250, 34);
            txtBx_ulica.TabIndex = 7;
            // 
            // txtBx_miasto
            // 
            txtBx_miasto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_miasto.Location = new Point(160, 132);
            txtBx_miasto.Name = "txtBx_miasto";
            txtBx_miasto.Size = new Size(250, 34);
            txtBx_miasto.TabIndex = 8;
            // 
            // txtBx_nip
            // 
            txtBx_nip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_nip.Location = new Point(160, 92);
            txtBx_nip.Name = "txtBx_nip";
            txtBx_nip.Size = new Size(250, 34);
            txtBx_nip.TabIndex = 9;
            // 
            // txtBx_akronim
            // 
            txtBx_akronim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_akronim.Location = new Point(160, 52);
            txtBx_akronim.Name = "txtBx_akronim";
            txtBx_akronim.Size = new Size(250, 34);
            txtBx_akronim.TabIndex = 10;
            // 
            // txtBx_nazwa
            // 
            txtBx_nazwa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_nazwa.Location = new Point(160, 12);
            txtBx_nazwa.Name = "txtBx_nazwa";
            txtBx_nazwa.Size = new Size(250, 34);
            txtBx_nazwa.TabIndex = 11;
            // 
            // btn_dodaj
            // 
            btn_dodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_dodaj.BackColor = Color.LightGreen;
            btn_dodaj.Location = new Point(160, 293);
            btn_dodaj.Name = "btn_dodaj";
            btn_dodaj.Size = new Size(250, 39);
            btn_dodaj.TabIndex = 12;
            btn_dodaj.Text = "Dodaj";
            btn_dodaj.UseVisualStyleBackColor = false;
            btn_dodaj.Click += btn_dodaj_Click;
            // 
            // btn_anuluj
            // 
            btn_anuluj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_anuluj.BackColor = Color.Tomato;
            btn_anuluj.Location = new Point(12, 293);
            btn_anuluj.Name = "btn_anuluj";
            btn_anuluj.Size = new Size(142, 39);
            btn_anuluj.TabIndex = 13;
            btn_anuluj.Text = "Anuluj";
            btn_anuluj.UseVisualStyleBackColor = false;
            btn_anuluj.Click += btn_anuluj_Click;
            // 
            // txtBx_email
            // 
            txtBx_email.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBx_email.Location = new Point(160, 252);
            txtBx_email.Name = "txtBx_email";
            txtBx_email.Size = new Size(250, 34);
            txtBx_email.TabIndex = 15;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(83, 255);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(67, 28);
            lbl_email.TabIndex = 14;
            lbl_email.Text = "E-mail";
            // 
            // FrmDodajKontrahenta
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(432, 344);
            Controls.Add(txtBx_email);
            Controls.Add(lbl_email);
            Controls.Add(btn_anuluj);
            Controls.Add(btn_dodaj);
            Controls.Add(txtBx_nazwa);
            Controls.Add(txtBx_akronim);
            Controls.Add(txtBx_nip);
            Controls.Add(txtBx_miasto);
            Controls.Add(txtBx_ulica);
            Controls.Add(txtBx_kodPocztowy);
            Controls.Add(lbl_kodPocztowy);
            Controls.Add(lbl_ulica);
            Controls.Add(lbl_miasto);
            Controls.Add(lbl_nip);
            Controls.Add(lbl_akronim);
            Controls.Add(lbl_nazwa);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmDodajKontrahenta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj kontrahenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nazwa;
        private Label lbl_akronim;
        private Label lbl_nip;
        private Label lbl_miasto;
        private Label lbl_ulica;
        private Label lbl_kodPocztowy;
        private TextBox txtBx_kodPocztowy;
        private TextBox txtBx_ulica;
        private TextBox txtBx_miasto;
        private TextBox txtBx_nip;
        private TextBox txtBx_akronim;
        private TextBox txtBx_nazwa;
        private Button btn_dodaj;
        private Button btn_anuluj;
        private TextBox txtBx_email;
        private Label lbl_email;
    }
}