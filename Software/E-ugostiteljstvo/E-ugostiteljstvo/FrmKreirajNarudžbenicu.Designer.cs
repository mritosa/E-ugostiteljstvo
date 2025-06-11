namespace E_ugostiteljstvo
{
    partial class FrmKreirajNarudžbenicu
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
            this.dgvNarudžbenica = new System.Windows.Forms.DataGridView();
            this.dgvNamirnice = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPopuni = new System.Windows.Forms.Button();
            this.btnTraži = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtTraži = new System.Windows.Forms.TextBox();
            this.btnMakni = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblNamirniceUKatalogu = new System.Windows.Forms.Label();
            this.lblStavkeNarudzbenice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudžbenica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirnice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudžbenica
            // 
            this.dgvNarudžbenica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudžbenica.Location = new System.Drawing.Point(48, 467);
            this.dgvNarudžbenica.Name = "dgvNarudžbenica";
            this.dgvNarudžbenica.ReadOnly = true;
            this.dgvNarudžbenica.RowHeadersWidth = 51;
            this.dgvNarudžbenica.RowTemplate.Height = 24;
            this.dgvNarudžbenica.Size = new System.Drawing.Size(868, 279);
            this.dgvNarudžbenica.TabIndex = 0;
            // 
            // dgvNamirnice
            // 
            this.dgvNamirnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamirnice.Location = new System.Drawing.Point(48, 73);
            this.dgvNamirnice.Name = "dgvNamirnice";
            this.dgvNamirnice.ReadOnly = true;
            this.dgvNamirnice.RowHeadersWidth = 51;
            this.dgvNamirnice.RowTemplate.Height = 24;
            this.dgvNamirnice.Size = new System.Drawing.Size(868, 279);
            this.dgvNamirnice.TabIndex = 1;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(867, 787);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(95, 45);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPopuni
            // 
            this.btnPopuni.Location = new System.Drawing.Point(48, 369);
            this.btnPopuni.Name = "btnPopuni";
            this.btnPopuni.Size = new System.Drawing.Size(137, 34);
            this.btnPopuni.TabIndex = 3;
            this.btnPopuni.Text = "Popuni automatski";
            this.btnPopuni.UseVisualStyleBackColor = true;
            this.btnPopuni.Click += new System.EventHandler(this.btnPopuni_Click);
            // 
            // btnTraži
            // 
            this.btnTraži.Location = new System.Drawing.Point(818, 29);
            this.btnTraži.Name = "btnTraži";
            this.btnTraži.Size = new System.Drawing.Size(98, 23);
            this.btnTraži.TabIndex = 4;
            this.btnTraži.Text = "Pretraži";
            this.btnTraži.UseVisualStyleBackColor = true;
            this.btnTraži.Click += new System.EventHandler(this.btnTraži_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(834, 371);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(82, 30);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtTraži
            // 
            this.txtTraži.Location = new System.Drawing.Point(675, 30);
            this.txtTraži.Name = "txtTraži";
            this.txtTraži.Size = new System.Drawing.Size(137, 22);
            this.txtTraži.TabIndex = 6;
            // 
            // btnMakni
            // 
            this.btnMakni.Location = new System.Drawing.Point(48, 771);
            this.btnMakni.Name = "btnMakni";
            this.btnMakni.Size = new System.Drawing.Size(89, 32);
            this.btnMakni.TabIndex = 7;
            this.btnMakni.Text = "Ukloni";
            this.btnMakni.UseVisualStyleBackColor = true;
            this.btnMakni.Click += new System.EventHandler(this.btnMakni_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(758, 375);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(56, 22);
            this.txtKolicina.TabIndex = 8;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(695, 378);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(57, 16);
            this.lblKolicina.TabIndex = 9;
            this.lblKolicina.Text = "Količina:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(758, 787);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(92, 45);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblNamirniceUKatalogu
            // 
            this.lblNamirniceUKatalogu.AutoSize = true;
            this.lblNamirniceUKatalogu.Location = new System.Drawing.Point(45, 36);
            this.lblNamirniceUKatalogu.Name = "lblNamirniceUKatalogu";
            this.lblNamirniceUKatalogu.Size = new System.Drawing.Size(139, 16);
            this.lblNamirniceUKatalogu.TabIndex = 11;
            this.lblNamirniceUKatalogu.Text = "Namirnice iz kataloga:";
            // 
            // lblStavkeNarudzbenice
            // 
            this.lblStavkeNarudzbenice.AutoSize = true;
            this.lblStavkeNarudzbenice.Location = new System.Drawing.Point(45, 431);
            this.lblStavkeNarudzbenice.Name = "lblStavkeNarudzbenice";
            this.lblStavkeNarudzbenice.Size = new System.Drawing.Size(141, 16);
            this.lblStavkeNarudzbenice.TabIndex = 12;
            this.lblStavkeNarudzbenice.Text = "Stavke u narudžbenici:";
            // 
            // FrmKreirajNarudžbenicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 875);
            this.Controls.Add(this.lblStavkeNarudzbenice);
            this.Controls.Add(this.lblNamirniceUKatalogu);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.btnMakni);
            this.Controls.Add(this.txtTraži);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnTraži);
            this.Controls.Add(this.btnPopuni);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvNamirnice);
            this.Controls.Add(this.dgvNarudžbenica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKreirajNarudžbenicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiraj Narudžbenicu";
            this.Load += new System.EventHandler(this.FrmKreirajNarudžbenicu_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmKreirajNarudžbenicu_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudžbenica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamirnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudžbenica;
        private System.Windows.Forms.DataGridView dgvNamirnice;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPopuni;
        private System.Windows.Forms.Button btnTraži;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtTraži;
        private System.Windows.Forms.Button btnMakni;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNamirniceUKatalogu;
        private System.Windows.Forms.Label lblStavkeNarudzbenice;
    }
}