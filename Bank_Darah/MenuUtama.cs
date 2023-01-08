using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank_Darah
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
        private void pendonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pendonor pndr = new Pendonor();
            pndr.ShowDialog();
        }

        private void pendonorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peenerimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Penerima pnrma = new Penerima();
            pnrma.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusDarahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusDarah stts = new StatusDarah();
            stts.ShowDialog();

        }

        private void stokDarahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokDarah stkdrh = new StokDarah();
            stkdrh.Show();

        }

        private void Donasi_Click(object sender, EventArgs e)
        {
            Donor dnr = new Donor();
            dnr.ShowDialog();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DetailDonasi_Click(object sender, EventArgs e)
        {
            Detail_donasi dtldns = new Detail_donasi();
            dtldns.Show();
        }
    }
}
        