namespace Bank_Darah
{
    partial class MenuUtama
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
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendonorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.peenerimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusDarahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokDarahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Donasi = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailDonasi = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-309, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 77;
            this.label13.Text = "No HP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berandaToolStripMenuItem,
            this.pendonorToolStripMenuItem,
            this.statusDarahToolStripMenuItem,
            this.stokDarahToolStripMenuItem,
            this.Donasi,
            this.DetailDonasi});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(730, 25);
            this.menuStrip1.TabIndex = 78;
            this.menuStrip1.Text = "menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // berandaToolStripMenuItem
            // 
            this.berandaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.berandaToolStripMenuItem.Image = global::Bank_Darah.Properties.Resources._111_1111079_logo_templates_png_download_template_logo_png;
            this.berandaToolStripMenuItem.Name = "berandaToolStripMenuItem";
            this.berandaToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.berandaToolStripMenuItem.Text = "&Beranda";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::Bank_Darah.Properties.Resources.logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pendonorToolStripMenuItem
            // 
            this.pendonorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendonorToolStripMenuItem1,
            this.peenerimaToolStripMenuItem});
            this.pendonorToolStripMenuItem.Image = global::Bank_Darah.Properties.Resources.tambahjadi;
            this.pendonorToolStripMenuItem.Name = "pendonorToolStripMenuItem";
            this.pendonorToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.pendonorToolStripMenuItem.Text = "&Input Data";
            this.pendonorToolStripMenuItem.Click += new System.EventHandler(this.pendonorToolStripMenuItem_Click);
            // 
            // pendonorToolStripMenuItem1
            // 
            this.pendonorToolStripMenuItem1.Image = global::Bank_Darah.Properties.Resources.pendonor;
            this.pendonorToolStripMenuItem1.Name = "pendonorToolStripMenuItem1";
            this.pendonorToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.pendonorToolStripMenuItem1.Text = "&Pendonor";
            this.pendonorToolStripMenuItem1.Click += new System.EventHandler(this.pendonorToolStripMenuItem1_Click);
            // 
            // peenerimaToolStripMenuItem
            // 
            this.peenerimaToolStripMenuItem.Image = global::Bank_Darah.Properties.Resources.penerima;
            this.peenerimaToolStripMenuItem.Name = "peenerimaToolStripMenuItem";
            this.peenerimaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.peenerimaToolStripMenuItem.Text = "Pe&nerima";
            this.peenerimaToolStripMenuItem.Click += new System.EventHandler(this.peenerimaToolStripMenuItem_Click);
            // 
            // statusDarahToolStripMenuItem
            // 
            this.statusDarahToolStripMenuItem.Image = global::Bank_Darah.Properties.Resources.loading;
            this.statusDarahToolStripMenuItem.Name = "statusDarahToolStripMenuItem";
            this.statusDarahToolStripMenuItem.Size = new System.Drawing.Size(131, 21);
            this.statusDarahToolStripMenuItem.Text = "&Status Darah";
            this.statusDarahToolStripMenuItem.Click += new System.EventHandler(this.statusDarahToolStripMenuItem_Click);
            // 
            // stokDarahToolStripMenuItem
            // 
            this.stokDarahToolStripMenuItem.Image = global::Bank_Darah.Properties.Resources.in_stock;
            this.stokDarahToolStripMenuItem.Name = "stokDarahToolStripMenuItem";
            this.stokDarahToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.stokDarahToolStripMenuItem.Text = "S&tok Darah";
            this.stokDarahToolStripMenuItem.Click += new System.EventHandler(this.stokDarahToolStripMenuItem_Click);
            // 
            // Donasi
            // 
            this.Donasi.Image = global::Bank_Darah.Properties.Resources.blood_bag;
            this.Donasi.Name = "Donasi";
            this.Donasi.Size = new System.Drawing.Size(86, 21);
            this.Donasi.Text = "&Donasi";
            this.Donasi.Click += new System.EventHandler(this.Donasi_Click);
            // 
            // DetailDonasi
            // 
            this.DetailDonasi.Image = global::Bank_Darah.Properties.Resources.clipboard;
            this.DetailDonasi.Name = "DetailDonasi";
            this.DetailDonasi.Size = new System.Drawing.Size(132, 21);
            this.DetailDonasi.Text = "D&etail Donasi";
            this.DetailDonasi.Click += new System.EventHandler(this.DetailDonasi_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.laporanToolStripMenuItem.Text = "lap&oran";
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bank_Darah.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 432);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem berandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusDarahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokDarahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Donasi;
        private System.Windows.Forms.ToolStripMenuItem DetailDonasi;
        private System.Windows.Forms.ToolStripMenuItem pendonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendonorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem peenerimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
    }
}