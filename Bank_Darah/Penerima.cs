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
    public partial class Penerima : Form
    {
        public Penerima()
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
            cmd.CommandText = "select * from penerima";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "penerima");
            dgvPenerima.DataSource = ds;
            dgvPenerima.DataMember = "penerima";
            dgvPenerima.ReadOnly = true;
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

        private void cboPetugas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void Penerima_Load(object sender, EventArgs e)
        {
            showdata();
            isicombo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ADDPENERIMA1";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter nikPenerima = new SqlParameter("@nikpenerima", SqlDbType.VarChar);
            SqlParameter namaPenerima = new SqlParameter("@namapenerima", SqlDbType.VarChar);
            SqlParameter tanggalLahirPenerima = new SqlParameter("@tanggal_lahirpenerima", SqlDbType.VarChar);
            SqlParameter genderPenerima = new SqlParameter("@gender", SqlDbType.VarChar);
            SqlParameter nohpPenerima = new SqlParameter("@nohp", SqlDbType.VarChar);
            SqlParameter golDarPenerima = new SqlParameter("@goldar", SqlDbType.VarChar);
            SqlParameter alamatPenerima = new SqlParameter("@alamat", SqlDbType.VarChar);
            SqlParameter tglinputdata = new SqlParameter("@tglinputdata", SqlDbType.VarChar);
            SqlParameter jmlButuh = new SqlParameter("@jmlbutuh", SqlDbType.Int);
            SqlParameter username = new SqlParameter("@username", SqlDbType.VarChar);

            nikPenerima.Value = NikPenerima.Text;
            namaPenerima.Value = NamaPenerima.Text;
            tanggalLahirPenerima.Value = TlPenerima.Text;
            genderPenerima.Value = JkPenerima.Text;
            nohpPenerima.Value = NoPenerima.Text;
            golDarPenerima.Value = GoldarPenerima.Text;
            alamatPenerima.Value = AlamatPenerima.Text;
            tglinputdata.Value = TldPenerima.Text;
            jmlButuh.Value = DonorPenerima.Text;
            username.Value = txtUsername.Text;

            cmd.Parameters.Add(nikPenerima);
            cmd.Parameters.Add(namaPenerima);
            cmd.Parameters.Add(tanggalLahirPenerima);
            cmd.Parameters.Add(genderPenerima);
            cmd.Parameters.Add(nohpPenerima);
            cmd.Parameters.Add(golDarPenerima);
            cmd.Parameters.Add(alamatPenerima);
            cmd.Parameters.Add(tglinputdata);
            cmd.Parameters.Add(jmlButuh);
            cmd.Parameters.Add(username);

            cmd.ExecuteNonQuery();


            showdata();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from penerima where nikpenerima = '" + NikPenerima.Text + "'";
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void TldPenerima_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPetugas_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

    }
}
