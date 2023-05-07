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
    public partial class MemberInfo : Form
    {
        public MemberInfo(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public int id { get; set; }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Server=.\SQLEXPRESS;Database=UsernameDB;Trusted_Connection=True;");
            string query = "SELECT Name, surname,username FROM UserInfoTable";
            SqlCommand cmd = new SqlCommand(query, sql);

            sql.Open();
            MessageBox.Show("Open");

            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while(reader.Read())
            {
                i++;
                if(i == id)
                {
                    NameLabel.Text = reader["Name"].ToString();
                    SurnameLabel.Text = reader["surname"].ToString();
                    UsernameLabel.Text = reader["username"].ToString();
                }
            }


            reader.Close();
            sql.Close();
        }
    }
}
