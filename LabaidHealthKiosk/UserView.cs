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
        static int x = 0;
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



        private void ComplainSubmitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You Sir. We will try to solve your problem as soon as possible");
            PanelWelcome.BringToFront();
            panelComplain.SendToBack();
            panelUserInfo.SendToBack();
            PanelWelcome.Dock = DockStyle.Fill;

        }

       

        private void Complainbtn_Click(object sender, EventArgs e)
        {
            x = 1;
            PanelWelcome.SendToBack();
            panelComplain.SendToBack();
            panelUserInfo.BringToFront();
            panelUserInfo.Dock = DockStyle.Fill;

        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            x = 2;
            PanelWelcome.SendToBack();
            panelComplain.SendToBack();
            panelUserInfo.BringToFront();
            panelUserInfo.Dock = DockStyle.Fill;
        }

       

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                panelUserInfo.SendToBack();
                PanelWelcome.SendToBack();
                panelComplain.BringToFront();
                panelComplain.Dock = DockStyle.Fill;
            }
            else if (x == 2)
            {
                PanelWelcome.BringToFront();
                PanelWelcome.Dock = DockStyle.Fill;
                panelUserInfo.SendToBack();
            }

        }
    }
}
