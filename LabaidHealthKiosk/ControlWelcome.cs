using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaidHealthKiosk
{
    public partial class ControlWelcome : UserControl
    {
        public ControlWelcome()
        {
           
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void Complainbtn_Click(object sender, EventArgs e)
        {
            PanelWelcome.Controls.Clear();
            PanelWelcome.Controls.Add(new ControlComplain());
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            PanelWelcome.Controls.Clear();
            PanelWelcome.Controls.Add(new ControlUserInfo());
        }

        private void PanelWelcomeMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
