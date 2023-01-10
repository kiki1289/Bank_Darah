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
        (@"Data Source=KIKI;Initial Catalog=Bank_DarahKIKI;Integrated Security=true");
        public Donor()
        {
            InitializeComponent();
        }

        private string nodonasi
        {
            get
            {
                con.Open();
                string nomor = "DN-0001";
                SqlCommand cmd = new SqlCommand("select max(right(idDonasi,4)) from donasi", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd[0].ToString() != "")
                    nomor = "DN-" + (int.Parse(rd[0].ToString()) + 1).ToString("000");
                rd.Close();
                return nomor;
            }
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


        private void showdonasi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from donasi";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "donasi");
            Dgvstokdarah.DataSource = ds;
            Dgvstokdarah.DataMember = "donasi";
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
        private void isicombopetugas()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nama from admin";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1, "admin");
            cbopetugas.DataSource = ds1.Tables["admin"];
            cbopetugas.DisplayMember = "nama";

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
            NoDonasi.Text = nodonasi;
            showdatapenerima();
            isicombopenerima();
            isicombopetugas();
            showdonasi();
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
            if (Jmlterima.Text == "" && Tglterima.Text == "")
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
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "insert into detailDonasi values('"+txtUsername.Text+"','" + NoDonasi.Text +"')";
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();

            showdonasi();
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

        private void keluar_Click(object sender, EventArgs e)
        {
            var Tanya = MessageBox.Show("apakah anda yakin", "keluar", MessageBoxButtons.YesNo);
            if (Tanya == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbopetugas_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from admin where nama='" + cbopetugas.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtUsername.Text = rd[0].ToString();
                rd.Close();
            }
        }
    }
}