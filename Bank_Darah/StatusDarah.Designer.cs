namespace Bank_Darah
{
    partial class StatusDarah
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
            this.JkPendonor = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.NamaPendonor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CbStatus = new System.Windows.Forms.ComboBox();
            this.keluar = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.CboPendonor = new System.Windows.Forms.ComboBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.txtidDarah = new System.Windows.Forms.TextBox();
            this.cbostokdarah = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgoldar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // JkPendonor
            // 
            this.JkPendonor.Location = new System.Drawing.Point(253, 196);
            this.JkPendonor.Name = "JkPendonor";
            this.JkPendonor.Size = new System.Drawing.Size(114, 20);
            this.JkPendonor.TabIndex = 96;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 23);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NamaPendonor
            // 
            this.NamaPendonor.Location = new System.Drawing.Point(253, 169);
            this.NamaPendonor.Name = "NamaPendonor";
            this.NamaPendonor.Size = new System.Drawing.Size(246, 20);
            this.NamaPendonor.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-308, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "No HP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Jenis Kelamin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "NIK Pendonor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 79);
            this.panel1.TabIndex = 78;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(141, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 46);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status Darah";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Status";
            // 
            // CbStatus
            // 
            this.CbStatus.FormattingEnabled = true;
            this.CbStatus.Location = new System.Drawing.Point(307, 228);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(192, 21);
            this.CbStatus.TabIndex = 98;
            this.CbStatus.SelectedIndexChanged += new System.EventHandler(this.CbStatus_SelectedIndexChanged);
            // 
            // keluar
            // 
            this.keluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.keluar.BackColor = System.Drawing.Color.Blue;
            this.keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.ForeColor = System.Drawing.Color.Cornsilk;
            this.keluar.Location = new System.Drawing.Point(631, 415);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(75, 32);
            this.keluar.TabIndex = 99;
            this.keluar.Text = "Keluar";
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(520, 229);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(56, 20);
            this.txtstatus.TabIndex = 100;
            // 
            // CboPendonor
            // 
            this.CboPendonor.FormattingEnabled = true;
            this.CboPendonor.Location = new System.Drawing.Point(253, 140);
            this.CboPendonor.Name = "CboPendonor";
            this.CboPendonor.Size = new System.Drawing.Size(192, 21);
            this.CboPendonor.TabIndex = 101;
            this.CboPendonor.SelectedIndexChanged += new System.EventHandler(this.CboPendonor_SelectedIndexChanged);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(307, 255);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(192, 20);
            this.nama.TabIndex = 102;
            // 
            // txtidDarah
            // 
            this.txtidDarah.Location = new System.Drawing.Point(364, 281);
            this.txtidDarah.Name = "txtidDarah";
            this.txtidDarah.Size = new System.Drawing.Size(33, 20);
            this.txtidDarah.TabIndex = 125;
            // 
            // cbostokdarah
            // 
            this.cbostokdarah.FormattingEnabled = true;
            this.cbostokdarah.Location = new System.Drawing.Point(308, 281);
            this.cbostokdarah.Name = "cbostokdarah";
            this.cbostokdarah.Size = new System.Drawing.Size(50, 21);
            this.cbostokdarah.TabIndex = 124;
            this.cbostokdarah.SelectedIndexChanged += new System.EventHandler(this.cbostokdarah_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "GolDar";
            // 
            // txtgoldar
            // 
            this.txtgoldar.Location = new System.Drawing.Point(481, 140);
            this.txtgoldar.Name = "txtgoldar";
            this.txtgoldar.Size = new System.Drawing.Size(56, 20);
            this.txtgoldar.TabIndex = 127;
            // 
            // StatusDarah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 459);
            this.Controls.Add(this.txtgoldar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidDarah);
            this.Controls.Add(this.cbostokdarah);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.CboPendonor);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.JkPendonor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.NamaPendonor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "StatusDarah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusDarah";
            this.Load += new System.EventHandler(this.StatusDarah_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox JkPendonor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox NamaPendonor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.ComboBox CboPendonor;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox txtidDarah;
        private System.Windows.Forms.ComboBox cbostokdarah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgoldar;
    }
}