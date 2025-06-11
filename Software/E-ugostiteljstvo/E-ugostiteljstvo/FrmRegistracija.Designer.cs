namespace E_ugostiteljstvo
{
    partial class FrmRegistracija
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
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.btnSlikaj = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cmbRadnoMjesto = new System.Windows.Forms.ComboBox();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.btnUkljuci = new System.Windows.Forms.Button();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pcbSlika2 = new System.Windows.Forms.PictureBox();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSlika
            // 
            this.pcbSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbSlika.Location = new System.Drawing.Point(37, 198);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(427, 317);
            this.pcbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSlika.TabIndex = 0;
            this.pcbSlika.TabStop = false;
            // 
            // btnSlikaj
            // 
            this.btnSlikaj.Location = new System.Drawing.Point(389, 521);
            this.btnSlikaj.Name = "btnSlikaj";
            this.btnSlikaj.Size = new System.Drawing.Size(75, 44);
            this.btnSlikaj.TabIndex = 1;
            this.btnSlikaj.Text = "Slikaj";
            this.btnSlikaj.UseVisualStyleBackColor = true;
            this.btnSlikaj.Click += new System.EventHandler(this.btnSlikaj_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(541, 323);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Radno mjesto";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(601, 320);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(601, 349);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(187, 22);
            this.txtLozinka.TabIndex = 9;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(601, 381);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(187, 22);
            this.txtIme.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(601, 416);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(187, 22);
            this.txtPrezime.TabIndex = 11;
            // 
            // cmbRadnoMjesto
            // 
            this.cmbRadnoMjesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRadnoMjesto.FormattingEnabled = true;
            this.cmbRadnoMjesto.Location = new System.Drawing.Point(638, 458);
            this.cmbRadnoMjesto.Name = "cmbRadnoMjesto";
            this.cmbRadnoMjesto.Size = new System.Drawing.Size(150, 24);
            this.cmbRadnoMjesto.TabIndex = 12;
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Location = new System.Drawing.Point(626, 515);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(101, 42);
            this.btnRegistriraj.TabIndex = 13;
            this.btnRegistriraj.Text = "Registriraj se";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // btnUkljuci
            // 
            this.btnUkljuci.Location = new System.Drawing.Point(359, 150);
            this.btnUkljuci.Name = "btnUkljuci";
            this.btnUkljuci.Size = new System.Drawing.Size(107, 33);
            this.btnUkljuci.TabIndex = 14;
            this.btnUkljuci.Text = "Uključi kameru";
            this.btnUkljuci.UseVisualStyleBackColor = true;
            this.btnUkljuci.Click += new System.EventHandler(this.btnUkljuci_Click);
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistracija.Location = new System.Drawing.Point(189, 63);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(164, 32);
            this.lblRegistracija.TabIndex = 15;
            this.lblRegistracija.Text = "Registracija";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pcbSlika2
            // 
            this.pcbSlika2.Location = new System.Drawing.Point(528, 63);
            this.pcbSlika2.Name = "pcbSlika2";
            this.pcbSlika2.Size = new System.Drawing.Size(275, 226);
            this.pcbSlika2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSlika2.TabIndex = 17;
            this.pcbSlika2.TabStop = false;
            // 
            // cboDevices
            // 
            this.cboDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(62, 155);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(291, 24);
            this.cboDevices.TabIndex = 18;
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 635);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.pcbSlika2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.btnUkljuci);
            this.Controls.Add(this.btnRegistriraj);
            this.Controls.Add(this.cmbRadnoMjesto);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSlikaj);
            this.Controls.Add(this.pcbSlika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.FrmRegistracija_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRegistracija_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSlika;
        private System.Windows.Forms.Button btnSlikaj;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cmbRadnoMjesto;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.Button btnUkljuci;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pcbSlika2;
        private System.Windows.Forms.ComboBox cboDevices;
    }
}