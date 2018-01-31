using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg.OpenPgp;

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
            string name, contact, relation;
            int age;
            name = txtName.Text;
            contact = txtContact.Text;
            if (radioButton1.Checked)
            {
                relation = "Patient";
            }
            else
            {
                relation = "patient's relative";}

            BusinessLayer.UserInfoClass.AddUser(name, contact, relation);

            if (p == 1)
            {
                this.Controls.Clear();
                ControlComplain cc = new ControlComplain(txtName.Text);
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else if (p == 2)
            {
                this.Controls.Clear();
                ControlFeedback cc = new ControlFeedback(txtName.Text);
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
