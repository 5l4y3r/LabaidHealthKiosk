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
        public int p = 0;
        public ControlUserInfo(int point)
        {
            p = point;
            InitializeComponent();
            Dock = DockStyle.Fill;
           
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            BusinessLayer.UserInfoClass.AddUser(txtName.Text,txtContact.Text,txtRelation.Text);
            if (p == 1)
            {
                this.Controls.Clear();
                ControlComplain cc = new ControlComplain(txtName.text);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else if (p == 2)
            {
                this.Controls.Clear();
                ControlFeedback cc = new ControlFeedback(txtName.text);
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

         int s1 = 0;
         int s2 = 0;
         int s3 = 0;

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (s1 == 0)
            {
                txtName.text = "";
                s1 = 1;
            }

        }

        private void txtContact_MouseClick(object sender, MouseEventArgs e)
        {
            if (s2 == 0)
            {
                txtContact.text = "";
                s2 = 1;
            }

        }

        private void txtRelation_MouseClick(object sender, MouseEventArgs e)
        {
            if (s3 == 0)
            {
                txtRelation.text = "";
                s3 = 1;
            }
        }
    }
}
