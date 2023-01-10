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
            cmd.CommandText = "ADDPENDONOR";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter nikPendonor = new SqlParameter("@nikpendonor", SqlDbType.VarChar);
            SqlParameter namaPendonor = new SqlParameter("@namapendonor", SqlDbType.VarChar);
            SqlParameter tanggal_lahirPendonor = new SqlParameter("@tanggal_lahirpendonor", SqlDbType.VarChar);
            SqlParameter gender = new SqlParameter("@gender", SqlDbType.VarChar);
            SqlParameter nohp = new SqlParameter("@nohp", SqlDbType.VarChar);
            SqlParameter golDar = new SqlParameter("@goldar", SqlDbType.VarChar);
            SqlParameter alamat = new SqlParameter("@alamat", SqlDbType.VarChar);
            SqlParameter tglDonor = new SqlParameter("@tgldonor", SqlDbType.VarChar);
            SqlParameter nDonor = new SqlParameter("@ndonor", SqlDbType.Int);
            SqlParameter username = new SqlParameter("@username", SqlDbType.VarChar);

            nikPendonor.Value = NikPendonor.Text;
            namaPendonor.Value = NamaPendonor.Text;
            tanggal_lahirPendonor.Value = TlPendonor.Text;
            gender.Value = JkPendonor.Text;
            nohp.Value = NoPendonor.Text;
            golDar.Value = GoldarPendonor.Text;
            alamat.Value = AlamatPendonor.Text;
            tglDonor.Value = TldPendonor.Text;
            nDonor.Value = DonorPendonor.Text;
            username.Value = txtUsername.Text;

            cmd.Parameters.Add(nikPendonor);
            cmd.Parameters.Add(namaPendonor);
            cmd.Parameters.Add(tanggal_lahirPendonor);
            cmd.Parameters.Add(gender);
            cmd.Parameters.Add(nohp);
            cmd.Parameters.Add(golDar);
            cmd.Parameters.Add(alamat);
            cmd.Parameters.Add(tglDonor);
            cmd.Parameters.Add(nDonor);
            cmd.Parameters.Add(username);

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
