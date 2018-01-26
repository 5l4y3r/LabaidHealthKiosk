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
        public static int x = 0;
        public ControlWelcome()
        {
           
            InitializeComponent();
            Dock = DockStyle.Fill;
          
        }

        private void Complainbtn_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 1;
                this.Controls.Clear();
                ControlUserInfo cc = new ControlUserInfo(x);

                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else
            {
                this.Controls.Clear();
                ControlComplain cc = new ControlComplain("");
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;


            }
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                x = 2;
                this.Controls.Clear();
                ControlUserInfo cc = new ControlUserInfo(x);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else
            {
                this.Controls.Clear();
                ControlFeedback cc = new ControlFeedback("");
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;


            }
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
