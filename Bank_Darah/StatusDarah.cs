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
    public partial class StatusDarah : Form
    {
        public StatusDarah()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
       (@"Data Source=KIKI;Initial Catalog=Bank_DarahKIKI;Integrated Security=true");
        private void isicombopendonor()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nikpendonor from pendonor";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1, "pendonor");
            CboPendonor.DataSource = ds1.Tables["pendonor"];
            CboPendonor.DisplayMember = "nikpendonor";

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
             private void isicombostatus()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select idstd from statusdarah";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1, "statusdarah");
            CbStatus.DataSource = ds1.Tables["statusdarah"];
            CbStatus.DisplayMember = "idstd";

        }

        private void StatusDarah_Load(object sender, EventArgs e)
        {
            isicombopendonor();
            isicombostatus();
            isicombostokdarah();
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

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from statusdarah where idstd='" + CbStatus.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                nama.Text = rd[1].ToString();
                txtstatus.Text = rd[2].ToString();
              
                rd.Close();
            }
        }

        private void CboPendonor_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from pendonor where nikPendonor='" + CboPendonor.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                NamaPendonor.Text = rd[1].ToString();
                JkPendonor.Text = rd[3].ToString();
                txtgoldar.Text = rd[5].ToString();
                rd.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into kelayakandarah values('" + CboPendonor.Text + "','" +
                                CbStatus.Text + "','" + txtidDarah.Text + "','" + txtstatus.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ///hapus colom nik donasi,
      

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
