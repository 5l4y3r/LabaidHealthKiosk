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
            this.Controls.Clear();
            ControlFeedback cc = new ControlFeedback();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
    }
}
