using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LabaidHealthKiosk
{
    public partial class ControlFeedback : UserControl
    {
        static int x = 0;
        static Dictionary<string, string> mapQuestion = new Dictionary<string,string>();
        
        public ControlFeedback()
        {
            InitializeComponent();

            mapQuestion.Add("Reception","Help Desk Executive");
            mapQuestion.Add("Reception", "Co Operation");
            mapQuestion.Add("Reception", "Information & COmmunication");
            mapQuestion.Add("Doctor","RMO's Co operation");
            mapQuestion.Add("Doctor", "Presense of RMO");
            mapQuestion.Add("Nursing", "Assistance for giving Medicine");
            mapQuestion.Add("Nursing", "Providing essential care to patient");
            mapQuestion.Add("Nursing", "Essential steps to solve the problems");
            mapQuestion.Add("House keeping", "Cleaniness of room");
            mapQuestion.Add("House keeping", "cleaniness of washroom ");
            mapQuestion.Add("House keeping", "cleaniness of bed & cloths");
            mapQuestion.Add("House keeping", "Presence of help aid & cleaner");
            mapQuestion.Add("Food", "Time of food supply");
            mapQuestion.Add("Food", "Quantity of food");
            mapQuestion.Add("Food", "Quality of food");
            mapQuestion.Add("Billing & Treatment", "Bill service process");
            mapQuestion.Add("Billing & Treatment", "Opportunity & privileges");


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            for (int q=x; q<mapQuestion.Count;q++ )
            {
                labelQuestionGroup.Text = "Question Group : " + mapQuestion.Keys.ElementAt(x);
                foreach (string ques in mapQuestion.Keys)
                {
                    while (ques == mapQuestion.Keys.ElementAt(x))
                    {
                        labelQuestion1.Text = mapQuestion.Values.ElementAt(0);
                        labelQuestion2.Text = mapQuestion.Values.ElementAt(1);
                        labelQuestion3.Text = mapQuestion.Values.ElementAt(2);
                        labelQuestion4.Text = mapQuestion.Values.ElementAt(3);
                        labelQuestion5.Text = mapQuestion.Values.ElementAt(4);
                        

                    }
                    
                }
                {
                    

                }

            }
            
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
