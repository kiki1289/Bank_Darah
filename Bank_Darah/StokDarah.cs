using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_Darah
{
    public partial class StokDarah : Form
    {
        public StokDarah()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
        (@"Data Source=KIKI;Initial Catalog=Bank_DarahKIKI;Integrated Security=true");

        private void showdatastok()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from stokDarah";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "stokDarah");
            dgvStokdarah.DataSource = ds;
            dgvStokdarah.DataMember = "stokDarah";
            dgvStokdarah.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void JkPendonor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void NamaPendonor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NikPendonor_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StokDarah_Load(object sender, EventArgs e)
        {
            showdatastok();
        }
    }
}
