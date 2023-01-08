namespace Bank_Darah
{
    partial class Donor
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
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDonasikan = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DgvPenerima = new System.Windows.Forms.DataGridView();
            this.Jmlterima = new System.Windows.Forms.TextBox();
            this.GoldarPendonor = new System.Windows.Forms.TextBox();
            this.Tglterima = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.NamaPenerima = new System.Windows.Forms.TextBox();
            this.Dgvstokdarah = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NoDonasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboNikPenerima = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtButuh = new System.Windows.Forms.TextBox();
            this.cbostokdarah = new System.Windows.Forms.ComboBox();
            this.txtidDarah = new System.Windows.Forms.TextBox();
            this.keluar = new System.Windows.Forms.Button();
            this.cbopetugas = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPenerima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvstokdarah)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(552, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 115;
            this.label19.Text = "Stok Darah";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 455);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 107;
            // 
            // btnDonasikan
            // 
            this.btnDonasikan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDonasikan.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonasikan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDonasikan.Location = new System.Drawing.Point(311, 480);
            this.btnDonasikan.Name = "btnDonasikan";
            this.btnDonasikan.Size = new System.Drawing.Size(87, 35);
            this.btnDonasikan.TabIndex = 106;
            this.btnDonasikan.Text = "Donasikan";
            this.btnDonasikan.UseVisualStyleBackColor = false;
            this.btnDonasikan.Click += new System.EventHandler(this.btnDonasikan_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(401, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 105;
            this.label17.Text = "Jumlah Terima";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 116;
            this.label21.Text = "Penerima";
            // 
            // DgvPenerima
            // 
            this.DgvPenerima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPenerima.Location = new System.Drawing.Point(26, 116);
            this.DgvPenerima.Name = "DgvPenerima";
            this.DgvPenerima.Size = new System.Drawing.Size(418, 184);
            this.DgvPenerima.TabIndex = 114;
            this.DgvPenerima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPenerima_CellContentClick);
            // 
            // Jmlterima
            // 
            this.Jmlterima.Location = new System.Drawing.Point(499, 356);
            this.Jmlterima.Name = "Jmlterima";
            this.Jmlterima.Size = new System.Drawing.Size(102, 20);
            this.Jmlterima.TabIndex = 113;
            // 
            // GoldarPendonor
            // 
            this.GoldarPendonor.Location = new System.Drawing.Point(625, 330);
            this.GoldarPendonor.Name = "GoldarPendonor";
            this.GoldarPendonor.Size = new System.Drawing.Size(50, 20);
            this.GoldarPendonor.TabIndex = 112;
            // 
            // Tglterima
            // 
            this.Tglterima.Location = new System.Drawing.Point(499, 390);
            this.Tglterima.Name = "Tglterima";
            this.Tglterima.Size = new System.Drawing.Size(195, 20);
            this.Tglterima.TabIndex = 111;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(401, 393);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 103;
            this.label14.Text = "Tanggal Terima";
            // 
            // NamaPenerima
            // 
            this.NamaPenerima.Location = new System.Drawing.Point(114, 383);
            this.NamaPenerima.Name = "NamaPenerima";
            this.NamaPenerima.Size = new System.Drawing.Size(195, 20);
            this.NamaPenerima.TabIndex = 110;
            // 
            // Dgvstokdarah
            // 
            this.Dgvstokdarah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvstokdarah.Location = new System.Drawing.Point(491, 116);
            this.Dgvstokdarah.Name = "Dgvstokdarah";
            this.Dgvstokdarah.Size = new System.Drawing.Size(205, 184);
            this.Dgvstokdarah.TabIndex = 108;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-308, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 102;
            this.label13.Text = "No HP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Nama";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 79);
            this.panel1.TabIndex = 99;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(132, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 46);
            this.panel3.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(184, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 28);
            this.label11.TabIndex = 13;
            this.label11.Text = "Donasi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "NIK Penerima";
            // 
            // NoDonasi
            // 
            this.NoDonasi.Location = new System.Drawing.Point(114, 314);
            this.NoDonasi.Name = "NoDonasi";
            this.NoDonasi.Size = new System.Drawing.Size(195, 20);
            this.NoDonasi.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "No Donasi";
            // 
            // CboNikPenerima
            // 
            this.CboNikPenerima.FormattingEnabled = true;
            this.CboNikPenerima.Location = new System.Drawing.Point(114, 356);
            this.CboNikPenerima.Name = "CboNikPenerima";
            this.CboNikPenerima.Size = new System.Drawing.Size(195, 21);
            this.CboNikPenerima.TabIndex = 119;
            this.CboNikPenerima.SelectedIndexChanged += new System.EventHandler(this.CboNikPenerima_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "Jumlah Butuh";
            // 
            // txtButuh
            // 
            this.txtButuh.Location = new System.Drawing.Point(499, 330);
            this.txtButuh.Name = "txtButuh";
            this.txtButuh.Size = new System.Drawing.Size(102, 20);
            this.txtButuh.TabIndex = 121;
            // 
            // cbostokdarah
            // 
            this.cbostokdarah.FormattingEnabled = true;
            this.cbostokdarah.Location = new System.Drawing.Point(625, 356);
            this.cbostokdarah.Name = "cbostokdarah";
            this.cbostokdarah.Size = new System.Drawing.Size(50, 21);
            this.cbostokdarah.TabIndex = 122;
            this.cbostokdarah.SelectedIndexChanged += new System.EventHandler(this.cbostokdarah_SelectedIndexChanged);
            // 
            // txtidDarah
            // 
            this.txtidDarah.Location = new System.Drawing.Point(681, 356);
            this.txtidDarah.Name = "txtidDarah";
            this.txtidDarah.Size = new System.Drawing.Size(33, 20);
            this.txtidDarah.TabIndex = 123;
            // 
            // keluar
            // 
            this.keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.keluar.BackColor = System.Drawing.Color.Blue;
            this.keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.ForeColor = System.Drawing.Color.Cornsilk;
            this.keluar.Location = new System.Drawing.Point(619, 480);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(75, 32);
            this.keluar.TabIndex = 124;
            this.keluar.Text = "Keluar";
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // cbopetugas
            // 
            this.cbopetugas.FormattingEnabled = true;
            this.cbopetugas.Location = new System.Drawing.Point(499, 427);
            this.cbopetugas.Name = "cbopetugas";
            this.cbopetugas.Size = new System.Drawing.Size(102, 21);
            this.cbopetugas.TabIndex = 127;
            this.cbopetugas.SelectedIndexChanged += new System.EventHandler(this.cbopetugas_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(401, 430);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 126;
            this.label15.Text = "Petugas";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(625, 428);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(51, 20);
            this.txtUsername.TabIndex = 128;
            // 
            // Donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 540);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cbopetugas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.txtidDarah);
            this.Controls.Add(this.cbostokdarah);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtButuh);
            this.Controls.Add(this.CboNikPenerima);
            this.Controls.Add(this.NoDonasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnDonasikan);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.DgvPenerima);
            this.Controls.Add(this.Jmlterima);
            this.Controls.Add(this.GoldarPendonor);
            this.Controls.Add(this.Tglterima);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NamaPenerima);
            this.Controls.Add(this.Dgvstokdarah);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Name = "Donor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor";
            this.Load += new System.EventHandler(this.Donor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPenerima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvstokdarah)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDonasikan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView DgvPenerima;
        private System.Windows.Forms.TextBox Jmlterima;
        private System.Windows.Forms.TextBox GoldarPendonor;
        private System.Windows.Forms.TextBox Tglterima;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NamaPenerima;
        private System.Windows.Forms.DataGridView Dgvstokdarah;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NoDonasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboNikPenerima;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtButuh;
        private System.Windows.Forms.ComboBox cbostokdarah;
        private System.Windows.Forms.TextBox txtidDarah;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.ComboBox cbopetugas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUsername;
    }
}