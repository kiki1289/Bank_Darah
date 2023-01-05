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
    public partial class Donor : Form
    {
        ///Kobeksi DB 
        SqlConnection con = new SqlConnection
        (@"Data Source=DESKTOP-27AG9DA;Initial Catalog=Bank_Darah;Integrated Security=true");
        public Donor()
        {
            InitializeComponent();
        }
  

        private void showdatapenerima()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from penerima";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "penerima");
            DgvPenerima.DataSource = ds;
            DgvPenerima.DataMember = "penerima";
            DgvPenerima.ReadOnly = true;
        }


        private void showdatastok()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from stokDarah";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "stokDarah");
            Dgvstokdarah.DataSource = ds;
            Dgvstokdarah.DataMember = "stokDarah";
            Dgvstokdarah.ReadOnly = true;
        }
        ///Otomatisasi No Donasi

        ///Isi NIK Otomatis 
        private void isicombopenerima()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nikpenerima from penerima";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1, "penerima");
            CboNikPenerima.DataSource = ds1.Tables["penerima"];
            CboNikPenerima.DisplayMember = "nikpenerima";

        }

        private void isicombostokdarah()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select golDarah from stokDarah";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1, "stokDarah");
            cbostokdarah.DataSource = ds1.Tables["stokDarah"];
            cbostokdarah.DisplayMember = "golDarah";

        }
        private void DgvPenerima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Donor_Load(object sender, EventArgs e)
        {
            showdatapenerima();
            isicombopenerima();
            showdatastok();
            isicombostokdarah();
            Tglterima.Text = DateTime.Now.ToString("dd/MM/yyyy");
          
          
        }

        private void CboNikPenerima_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from penerima where nikPenerima='" + CboNikPenerima.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                NamaPenerima.Text = rd[1].ToString();
                txtButuh.Text = rd[8].ToString();
                GoldarPendonor.Text = rd[5].ToString();
                rd.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDonasikan_Click(object sender, EventArgs e)
        {
            if (Jmlterima.Text == ""&&Tglterima.Text == "")
            {
                MessageBox.Show("Jumlah Terima dan Tanggal Terima Harap di Isi !!");
                goto berhenti;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into donasi values('" + NoDonasi.Text + "','" +
                                Tglterima.Text + "','" + Jmlterima.Text + "','" + txtidDarah.Text + "','" + CboNikPenerima.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ///hapus colom nik donasi,
           
          
             berhenti:
            ;
        }

        private void cbostokdarah_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from stokDarah where golDarah='" + cbostokdarah.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtidDarah.Text = rd[0].ToString();
                rd.Close();
            }
        }
    }
}
