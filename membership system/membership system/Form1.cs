using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace membership_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            SignIn SignIn = new SignIn();
            SignIn.Show();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            LogInForm LogInForm = new LogInForm();
            LogInForm.Show();
        }
    }
}
