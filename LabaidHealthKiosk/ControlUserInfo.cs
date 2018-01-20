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
    public partial class ControlUserInfo : UserControl
    {
        public ControlUserInfo()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            PanelUserInfo.Controls.Clear();
            PanelUserInfo.Controls.Add(new ControlFeedback());
        }
    }
}
