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
            string s2 = comboCategory.Text;

            BusinessLayer.ComplainClass.SubmitComplain(uName,s2,s);

            MessageBox.Show("We will Sove this problem Soon");
            this.Controls.Clear();
            ControlWelcome cc = new ControlWelcome();
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

        private void textBoxComplain_MouseClick(object sender, MouseEventArgs e)
        {
            if(x==0)
            textBoxComplain.Text = "";
            x = 1;
        }

        private void btnAnotherComplain_Click(object sender, EventArgs e)
        {

            textBoxComplain.Text = "";
        }
    }
}
