namespace E_ugostiteljstvo
{
    partial class MainForm
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
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.btnCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbUser
            // 
            this.pcbUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbUser.Location = new System.Drawing.Point(46, 129);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(359, 285);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbUser.TabIndex = 0;
            this.pcbUser.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(179, 431);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 28);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Login";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(706, 212);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(693, 268);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(116, 30);
            this.btnRegistracija.TabIndex = 3;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click_1);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(469, 282);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(16, 16);
            this.lblOr.TabIndex = 4;
            this.lblOr.Text = "ili";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(586, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "e-mail:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(581, 173);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(52, 16);
            this.lblLozinka.TabIndex = 6;
            this.lblLozinka.Text = "lozinka:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(649, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(649, 173);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(196, 22);
            this.txtLozinka.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(430, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 38);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Prijava";
            // 
            // cboDevices
            // 
            this.cboDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(46, 78);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(208, 24);
            this.cboDevices.TabIndex = 10;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(260, 78);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(145, 23);
            this.btnCapture.TabIndex = 11;
            this.btnCapture.Text = "Uključi kameru";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 596);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.pcbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.Button btnCapture;
    }
}

