using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace membership_system
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Server=.\SQLEXPRESS;Database=UsernameDB;Trusted_Connection=True;");

            SqlCommand cmd = new SqlCommand("INSERT INTO UserInfoTable(Name,Surname,Username,Password) VALUES (@Name,@Surname,@Username,@Password)", sql);
            cmd.Parameters.AddWithValue("@Name", InsertName.Text);
            cmd.Parameters.AddWithValue("@Surname", InsertSurname.Text);
            cmd.Parameters.AddWithValue("@Username", InsertUsername.Text);
            cmd.Parameters.AddWithValue("@Password", InsertPassword.Text);

            sql.Open();

            int sonuc = cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt işleminiz Gerçekleşti");

            sql.Close();
        }
    }
}
