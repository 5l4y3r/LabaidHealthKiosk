using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaidHealthKiosk
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            PasswordTxt.PasswordChar = '#';
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            
            UserView u = new UserView();
            u.Show();

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = Visible;
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == @"Admin" && PasswordTxt.Text == @"1234")
            {

                Hide();
                AdminPanel a = new AdminPanel();
                a.Show();
            }
        }
    }
}
