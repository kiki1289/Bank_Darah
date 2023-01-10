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
    public partial class Detail_donasi : Form
    {
        public Detail_donasi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
        (@"Data Source=KIKI;Initial Catalog=Bank_Darah4;Integrated Security=true");

        private void showdetaildonasi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from view_detaildonasi";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "detaildonasi");
            dgvdetaildonasi.DataSource = ds;
            dgvdetaildonasi.DataMember = "detaildonasi";
            dgvdetaildonasi.ReadOnly = true;
        }
        private void keluar_Click(object sender, EventArgs e)
        {
           
            }

        private void Detail_donasi_Load(object sender, EventArgs e)
        {
            showdetaildonasi();
        }
        }
    }

