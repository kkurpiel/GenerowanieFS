namespace WystawianieFS
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pan1 = new Panel();
            btn_Zaloguj = new Button();
            chkBx_pokazPIN = new CheckBox();
            lbl_pin = new Label();
            txtBx_pin = new TextBox();
            pan2 = new Panel();
            label1 = new Label();
            lab1 = new Label();
            panel2 = new Panel();
            pan1.SuspendLayout();
            pan2.SuspendLayout();
            SuspendLayout();
            // 
            // pan1
            // 
            pan1.BackColor = Color.MintCream;
            pan1.Controls.Add(btn_Zaloguj);
            pan1.Controls.Add(chkBx_pokazPIN);
            pan1.Controls.Add(lbl_pin);
            pan1.Controls.Add(txtBx_pin);
            pan1.Controls.Add(pan2);
            pan1.Dock = DockStyle.Fill;
            pan1.Location = new Point(0, 0);
            pan1.Name = "pan1";
            pan1.Size = new Size(582, 353);
            pan1.TabIndex = 0;
            // 
            // btn_Zaloguj
            // 
            btn_Zaloguj.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_Zaloguj.Location = new Point(296, 191);
            btn_Zaloguj.Name = "btn_Zaloguj";
            btn_Zaloguj.Size = new Size(231, 52);
            btn_Zaloguj.TabIndex = 5;
            btn_Zaloguj.Text = "Zaloguj się";
            btn_Zaloguj.UseVisualStyleBackColor = true;
            btn_Zaloguj.Click += btn_Zaloguj_Click;
            // 
            // chkBx_pokazPIN
            // 
            chkBx_pokazPIN.AutoSize = true;
            chkBx_pokazPIN.Location = new Point(431, 161);
            chkBx_pokazPIN.Name = "chkBx_pokazPIN";
            chkBx_pokazPIN.RightToLeft = RightToLeft.Yes;
            chkBx_pokazPIN.Size = new Size(96, 24);
            chkBx_pokazPIN.TabIndex = 4;
            chkBx_pokazPIN.Text = "Pokaż PIN";
            chkBx_pokazPIN.UseVisualStyleBackColor = true;
            chkBx_pokazPIN.CheckedChanged += chkBx_pokazPIN_CheckedChanged;
            // 
            // lbl_pin
            // 
            lbl_pin.AutoSize = true;
            lbl_pin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_pin.Location = new Point(296, 124);
            lbl_pin.Name = "lbl_pin";
            lbl_pin.Size = new Size(47, 28);
            lbl_pin.TabIndex = 2;
            lbl_pin.Text = "PIN:";
            // 
            // txtBx_pin
            // 
            txtBx_pin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtBx_pin.Location = new Point(349, 121);
            txtBx_pin.Name = "txtBx_pin";
            txtBx_pin.PasswordChar = '-';
            txtBx_pin.Size = new Size(178, 34);
            txtBx_pin.TabIndex = 1;
            txtBx_pin.TextAlign = HorizontalAlignment.Center;
            txtBx_pin.KeyPress += txtBx_pin_KeyPress;
            // 
            // pan2
            // 
            pan2.BackColor = Color.LightGreen;
            pan2.Controls.Add(label1);
            pan2.Controls.Add(lab1);
            pan2.Controls.Add(panel2);
            pan2.Dock = DockStyle.Left;
            pan2.Location = new Point(0, 0);
            pan2.Name = "pan2";
            pan2.Size = new Size(250, 353);
            pan2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(31, 89);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 2;
            label1.Text = "Faktur Sprzedaży";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lab1.Location = new Point(52, 58);
            lab1.Name = "lab1";
            lab1.Size = new Size(148, 31);
            lab1.TabIndex = 1;
            lab1.Text = "Generowanie";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(50, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 150);
            panel2.TabIndex = 0;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(pan1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generowanie Faktur - logowanie";
            KeyPress += txtBx_pin_KeyPress;
            pan1.ResumeLayout(false);
            pan1.PerformLayout();
            pan2.ResumeLayout(false);
            pan2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pan1;
        private Panel pan2;
        private Label lbl_pin;
        private TextBox txtBx_pin;
        private Label label1;
        private Label lab1;
        private Panel panel2;
        private Button btn_Zaloguj;
        private CheckBox chkBx_pokazPIN;
    }
}
