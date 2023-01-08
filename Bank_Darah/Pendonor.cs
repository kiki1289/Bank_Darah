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
    public partial class Pendonor : Form
    {
        public Pendonor()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
       (@"Data Source =KIKI; Initial catalog = Bank_Darah4; Integrated Security = True");
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from pendonor";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "pendonor");
            dgvPendonor.DataSource = ds;
            dgvPendonor.DataMember = "pendonor";
            dgvPendonor.ReadOnly = true;
        }
        private void isicombo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select nama from admin";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1, "admin");
            cboPetugas.DataSource = ds1.Tables["admin"];
            cboPetugas.DisplayMember = "nama";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO pendonor VALUES ('" + NikPendonor.Text + "','" + NamaPendonor.Text + "','" + TlPendonor.Text + "','" + JkPendonor.Text + "','" + NoPendonor.Text + "','" + GoldarPendonor.Text + "','" + AlamatPendonor.Text + "','" + TldPendonor.Text + "','" + int.Parse(DonorPendonor.Text) + "','" + txtUsername.Text + "')";
            cmd.ExecuteNonQuery();

            showdata();
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            var Tanya = MessageBox.Show("apakah anda yakin", "keluar", MessageBoxButtons.YesNo);
            if (Tanya == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Pendonor_Load(object sender, EventArgs e)
        {
            showdata();
            isicombo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from pendonor where nikpendonor = '" + NikPendonor.Text + "'";
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPetugas_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from admin where nama='" + cboPetugas.Text + "'", con);
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
