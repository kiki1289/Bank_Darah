﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank_Darah
{
    public partial class StatusDarah : Form
    {
        public StatusDarah()
        {
            InitializeComponent();
        }

        private void StatusDarah_Load(object sender, EventArgs e)
        {

        }

        private void keluar_Click(object sender, EventArgs e)
        {
            var Tanya = MessageBox.Show("apakah anda yakin", "keluar", MessageBoxButtons.YesNo);
            if (Tanya == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void NikPendonor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
