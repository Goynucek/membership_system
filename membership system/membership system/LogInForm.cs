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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Server =.\SQLEXPRESS; Database = UsernameDB; Trusted_Connection = True; ");
            string command = "SELECT ID,username, password FROM UserInfoTable";
            SqlCommand cmd = new SqlCommand(command, sql);


            sql.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            int i=0;
            while(reader.Read())
            {
                i++;
                if ((UsernameText.Text.ToLower() == reader["username"].ToString().Trim().ToLower()) && (PasswordText.Text == reader["password"].ToString().Trim()))
                {
                    MemberInfo memberinfor = new MemberInfo(i);
                    memberinfor.Show();
                }
            }
        }
    }
}
