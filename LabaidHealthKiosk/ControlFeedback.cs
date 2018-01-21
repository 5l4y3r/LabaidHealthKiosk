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
    public partial class ControlFeedback : UserControl
    {
        static int x = 1;
        public ControlFeedback()
        {
            InitializeComponent();
            
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            labelQuestionGroup.Text ="Question Group : "+ x.ToString();
            x++;
        }

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.Iconimage = ((System.Drawing.Image)(Properties.Resources.next_1_));
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            x--;
            labelQuestionGroup.Text ="Question Group : "+ x.ToString();
            
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.Iconimage = ((System.Drawing.Image)(Properties.Resources.back_1_));
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
