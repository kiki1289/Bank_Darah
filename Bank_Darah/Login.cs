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
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=DESKTOP-27AG9DA;Initial Catalog=Bank_Darah;Integrated Security=True";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from admin where username=@Username and sandi=@Password", koneksi);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            scmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            koneksi.Open();
            if (scmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Selamat datang di Bank Darah");
                MenuUtama home = new MenuUtama();
                home.Show();
                
            }
            else
            {
                MessageBox.Show("Periksa Username / Password Anda");
            }
            koneksi.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
