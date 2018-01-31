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
using EntityClasses;
using ns1;

namespace LabaidHealthKiosk
{
    public partial class ControlFeedback : UserControl
    {
        static int x = 0;
        
        public static Queue<string> Q1 = new Queue<string>();
        public static Queue<string> Q2 = new Queue<string>();
        public static List<Label> QLabels = new List<Label>();
        public static List<Label> QGroup = new List<Label>();
        public static List<Label> QLabelEx = new List<Label>();
        public static List<BunifuRating> QStars = new List<BunifuRating>();
       


        public ControlFeedback(string s)
        {
            InitializeComponent();
           
            ContextDb context = new ContextDb();
            var questionGroup = context.QuestionGroups.Select(t => t.GroupName);
            foreach (var q in questionGroup)
            {
                Q1.Enqueue(q);

            }
            
           AddingLabelInList();
           FeedbackComposing();

          

        }

        private void FeedbackComposing()
        {

            VisibilityControl();

            if (Q1.Count != 0)
            {
                for (int i =0; ;i++)
                {
                    if (Q1.Count > 0)
                    {
                        string groupName = Q1.Dequeue();
                        QGroup[i].Text = groupName;
                        QGroup[i].Visible = true;

                    }
                    else { break;}

                }
                
                ContextDb context = new ContextDb();
                var question = context.Questions.Select(t => t.Ques);
                foreach (var q in question)
                {
                    Q2.Enqueue(q);

                }

               
                for (int i = 0; ; i++)
                {
                    if (Q2.Count > 0)
                    {
                        string sp = Q2.Dequeue();

                        QLabels[i].Text = sp;
                        QLabels[i].Visible = true;
                        QStars[i].Visible = true;

                    }
                    else
                    {
                        break;
                    }

                }


            }

            


        }

        private void VisibilityControl()
        {

            labelQuestion1.Visible = false;
            labelQuestion2.Visible = false;
            labelQuestion3.Visible = false;
            labelQuestion4.Visible = false;
            labelQuestion5.Visible = false;
            labelQuestion6.Visible = false;
            labelQuestion7.Visible = false;
            labelQuestion8.Visible = false;
            labelQuestion9.Visible = false;
            labelQuestion10.Visible = false;
            labelQuestion11.Visible = false;
            labelQuestion12.Visible = false;
            labelQuestion13.Visible = false;
            labelQuestion14.Visible = false;
            labelQuestion15.Visible = false;
            labelQuestion16.Visible = false;
            labelQuestion17.Visible = false;
            labelQuestion18.Visible = false;

            RatingQ1.Visible = false;
            RatingQ2.Visible = false;
            RatingQ3.Visible = false;
            RatingQ4.Visible = false;
            RatingQ5.Visible = false;
            RatingQ6.Visible = false;
            RatingQ7.Visible = false;
            RatingQ8.Visible = false;
            RatingQ9.Visible = false;
            RatingQ10.Visible = false;
            RatingQ11.Visible = false;
            RatingQ12.Visible = false;
            RatingQ13.Visible = false;
            RatingQ14.Visible = false;
            RatingQ15.Visible = false;
            RatingQ16.Visible = false;
            RatingQ17.Visible = false;
            RatingQ18.Visible = false;

            labelQuestionGroup1.Visible = false;
            labelQuestionGroup2.Visible = false;
            labelQuestionGroup3.Visible = false;
            labelQuestionGroup4.Visible = false;
            labelQuestionGroup5.Visible = false;
            labelQuestionGroup6.Visible = false;
            labelQuestionGroup7.Visible = false;
            labelQuestionGroup8.Visible = false;

            labelEx1.Visible = false;
            labelEx2.Visible = false;
            labelEx3.Visible = false;
            labelEx4.Visible = false;
            labelEx5.Visible = false;
            labelEx6.Visible = false;
            labelEx7.Visible = false;
            labelEx8.Visible = false;
            labelEx9.Visible = false;
            labelEx10.Visible = false;
            labelEx11.Visible = false;
            labelEx12.Visible = false;
            labelEx13.Visible = false;
            labelEx14.Visible = false;
            labelEx15.Visible = false;
            labelEx16.Visible = false;
            labelEx17.Visible = false;
            labelEx18.Visible = false;

        }

        private void AddingLabelInList()
        {
            QLabels.Add(labelQuestion1);
            QLabels.Add(labelQuestion2);
            QLabels.Add(labelQuestion3);
            QLabels.Add(labelQuestion4);
            QLabels.Add(labelQuestion5);
            QLabels.Add(labelQuestion6);
            QLabels.Add(labelQuestion7);
            QLabels.Add(labelQuestion8);
            QLabels.Add(labelQuestion9);
            QLabels.Add(labelQuestion10);
            QLabels.Add(labelQuestion11);
            QLabels.Add(labelQuestion12);
            QLabels.Add(labelQuestion13);
            QLabels.Add(labelQuestion14);
            QLabels.Add(labelQuestion15);
            QLabels.Add(labelQuestion16);
            QLabels.Add(labelQuestion17);
            QLabels.Add(labelQuestion18);

            QStars.Add(RatingQ1);
            QStars.Add(RatingQ2);
            QStars.Add(RatingQ3);
            QStars.Add(RatingQ4);
            QStars.Add(RatingQ5);
            QStars.Add(RatingQ6);
            QStars.Add(RatingQ7);
            QStars.Add(RatingQ8);
            QStars.Add(RatingQ9);
            QStars.Add(RatingQ10);
            QStars.Add(RatingQ11);
            QStars.Add(RatingQ12);
            QStars.Add(RatingQ13);
            QStars.Add(RatingQ14);
            QStars.Add(RatingQ15);
            QStars.Add(RatingQ16);
            QStars.Add(RatingQ17);
            QStars.Add(RatingQ18);

            QGroup.Add(labelQuestionGroup1);
            QGroup.Add(labelQuestionGroup2);
            QGroup.Add(labelQuestionGroup3);
            QGroup.Add(labelQuestionGroup4);
            QGroup.Add(labelQuestionGroup5);
            QGroup.Add(labelQuestionGroup6);
            QGroup.Add(labelQuestionGroup7);
            QGroup.Add(labelQuestionGroup8);

            QLabelEx.Add(labelEx1);
            QLabelEx.Add(labelEx2);
            QLabelEx.Add(labelEx3);
            QLabelEx.Add(labelEx4);
            QLabelEx.Add(labelEx5);
            QLabelEx.Add(labelEx6);
            QLabelEx.Add(labelEx7);
            QLabelEx.Add(labelEx8);
            QLabelEx.Add(labelEx9);
            QLabelEx.Add(labelEx10);
            QLabelEx.Add(labelEx11);
            QLabelEx.Add(labelEx12);
            QLabelEx.Add(labelEx13);
            QLabelEx.Add(labelEx14);
            QLabelEx.Add(labelEx15);
            QLabelEx.Add(labelEx16);
            QLabelEx.Add(labelEx17);
            QLabelEx.Add(labelEx18);

        }

        private void NextPhase()
        {
            if (RatingQ1.Value > 0 && RatingQ2.Value > 0 && RatingQ3.Value > 0 && RatingQ4.Value > 0 &&
                RatingQ5.Value > 0 && RatingQ6.Value > 0 && RatingQ7.Value > 0 && RatingQ8.Value > 0 &&
                RatingQ9.Value > 0 && RatingQ10.Value > 0 && RatingQ11.Value > 0 && RatingQ12.Value > 0 &&
                RatingQ13.Value > 0 && RatingQ14.Value > 0 && RatingQ15.Value > 0 && RatingQ16.Value > 0 &&
                RatingQ17.Value > 0 && RatingQ18.Value > 0)
            {
                MessageBox.Show("Thank You For your time sir!");
                this.Controls.Clear();
                ControlWelcome cc = new ControlWelcome();
                this.Controls.Add(cc);
                cc.Show();
                cc.Dock = DockStyle.Fill;
            }
            else
            {
               
                MessageBox.Show("You are missing something");
            }



        }
        private string rateText(int value)
        {

            if (value == 1)
            {
                return "Very Poor";
            }
            else if (value == 2)
            {

                return "Poor";
            }
            else if (value == 3)
            {
                return "Good";
            }
            else if (value == 4)
            {
                return "Very Good";
            }
            else if (value == 5)
            {
                return "Excelent";
            }
            return " ";
        }

        private void RatingQ1_onValueChanged(object sender, EventArgs e)
        {
            labelEx1.Text = rateText(RatingQ1.Value);
            labelEx1.Visible = true;
            
        }

        private void RatingQ2_onValueChanged(object sender, EventArgs e)
        {
            labelEx2.Text = rateText(RatingQ2.Value);
            labelEx2.Visible = true;
        }

        private void RatingQ3_onValueChanged(object sender, EventArgs e)
        {
            labelEx3.Text = rateText(RatingQ3.Value);
            labelEx3.Visible = true;
        }

        private void RatingQ4_onValueChanged(object sender, EventArgs e)
        {
            labelEx4.Text = rateText(RatingQ4.Value);
            labelEx4.Visible = true;

        }
        private void RatingQ5_onValueChanged(object sender, EventArgs e)
        {
            labelEx5.Text = rateText(RatingQ5.Value);
            labelEx5.Visible = true;
        }

        

        private void RatingQ6_onValueChanged(object sender, EventArgs e)
        {
            labelEx6.Text = rateText(RatingQ6.Value);
            labelEx6.Visible = true;
        }

        private void RatingQ7_onValueChanged(object sender, EventArgs e)
        {
            labelEx7.Text = rateText(RatingQ7.Value);
            labelEx7.Visible = true;
        }

        private void RatingQ8_onValueChanged(object sender, EventArgs e)
        {
            labelEx8.Text = rateText(RatingQ8.Value);
            labelEx8.Visible = true;
        }

        private void RatingQ9_onValueChanged(object sender, EventArgs e)
        {
            labelEx9.Text = rateText(RatingQ9.Value);
            labelEx9.Visible = true;
        }

        private void RatingQ10_onValueChanged(object sender, EventArgs e)
        {
            labelEx10.Text = rateText(RatingQ10.Value);
            labelEx10.Visible = true;
        }

        private void RatingQ11_onValueChanged(object sender, EventArgs e)
        {
            labelEx11.Text = rateText(RatingQ11.Value);
            labelEx11.Visible = true;
        }

        private void RatingQ12_onValueChanged(object sender, EventArgs e)
        {
            labelEx12.Text = rateText(RatingQ12.Value);
            labelEx12.Visible = true;
        }

        private void RatingQ13_onValueChanged(object sender, EventArgs e)
        {
            labelEx13.Text = rateText(RatingQ13.Value);
            labelEx13.Visible = true;
        }

        private void RatingQ14_onValueChanged(object sender, EventArgs e)
        {
            labelEx14.Text = rateText(RatingQ14.Value);
            labelEx14.Visible = true;
        }

        private void RatingQ15_onValueChanged(object sender, EventArgs e)
        {
            labelEx15.Text = rateText(RatingQ15.Value);
            labelEx15.Visible = true;
        }

        private void RatingQ16_onValueChanged(object sender, EventArgs e)
        {
            labelEx16.Text = rateText(RatingQ16.Value);
            labelEx16.Visible = true;
        }

        private void RatingQ17_onValueChanged(object sender, EventArgs e)
        {
            labelEx17.Text = rateText(RatingQ17.Value);
            labelEx17.Visible = true;
        }

        private void RatingQ18_onValueChanged(object sender, EventArgs e)
        {
            labelEx18.Text = rateText(RatingQ18.Value);
            labelEx18.Visible = true;
            NextPhase();

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
