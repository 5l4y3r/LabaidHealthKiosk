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
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
            
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            PanelWelcome.BringToFront();
            PanelWelcome.Dock = DockStyle.Fill;
            panelUserInfo.SendToBack();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComplainBtn_Click(object sender, EventArgs e)
        {
            PanelWelcome.SendToBack();
            panelUserInfo.Dock = DockStyle.Fill;
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ready to go!");
            PanelWelcome.BringToFront();
            PanelWelcome.Dock = DockStyle.Fill;
            panelUserInfo.SendToBack();
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            PanelWelcome.SendToBack();
            panelUserInfo.BringToFront();
            panelUserInfo.Dock = DockStyle.Fill;
        }
    }
}
