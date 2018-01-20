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
    public partial class ControlComplain : UserControl
    {
        public ControlComplain()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void ComplainSubmitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you");
            PanelComplain.Controls.Clear();
            PanelComplain.Controls.Add(new ControlWelcome());
            Dock = DockStyle.Fill;
        }
    }
}
