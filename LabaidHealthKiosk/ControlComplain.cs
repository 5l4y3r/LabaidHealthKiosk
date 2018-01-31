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
        static int x = 0;
        static string uName = "";
        public ControlComplain(string s)
        {
            InitializeComponent();
            uName = s;

        }

        private void ComplainSubmitBtn_Click(object sender, EventArgs e)
        {
            string s = textBoxComplain.Text;
            string s2 = "";
            if (radioDoctor.Checked)
            {
                s2 = "Doctor";
            }
            else if (radioNurse.Checked)
            {
                s2 = "Nurse";}
            else if (radioAccomo.Checked)
            {
                s2 = "Accomodation";}
            else if (radioBilling.Checked)
            {
                s2 = "Billing";}
            else if (radioHelpDesk.Checked)
            {
                s2 = "Help Desk";
            }
            

            BusinessLayer.ComplainClass.SubmitComplain(uName,s2,s);

            DialogResult dialogResult = MessageBox.Show("Do you want to make another complain?", "Complain", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                this.Controls.Clear();
                ControlWelcome cc = new ControlWelcome();
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                textBoxComplain.Text = "";
            }
           

        }
        private void textBoxComplain_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == 0)
                textBoxComplain.Text = "";

            textBoxComplain.ForeColor = Color.Teal;
            x = 1;
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
