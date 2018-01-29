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
        public static List<BunifuRating> QStars = new List<BunifuRating>();
        static string uName = "";


        public ControlFeedback(string s)
        {
            InitializeComponent();
            uName = s;
            ContextDb context = new ContextDb();
            var questionGroup = context.QuestionGroups.Select(t => t.GroupName);
            foreach (var q in questionGroup)
            {
                Q1.Enqueue(q);

            }
            
            QLabels.Add(labelQuestion1);
            QLabels.Add(labelQuestion2);
            QLabels.Add(labelQuestion3);
            QLabels.Add(labelQuestion4);
            QLabels.Add(labelQuestion5);
            QStars.Add(RatingQ1);
            QStars.Add(RatingQ2);
            QStars.Add(RatingQ3);
            QStars.Add(RatingQ4);
            QStars.Add(RatingQ5);

            FeedbackComposing();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FeedbackComposing();
        }

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void FeedbackComposing()
        {

            labelQuestion1.Visible = false;
            labelQuestion2.Visible = false;
            labelQuestion3.Visible = false;
            labelQuestion4.Visible = false;
            labelQuestion5.Visible = false;
            RatingQ1.Visible = false;
            RatingQ2.Visible = false;
            RatingQ3.Visible = false;
            RatingQ4.Visible = false;
            RatingQ5.Visible = false;

            if (Q1.Count != 0)
            {
                string group = Q1.Dequeue();
                ContextDb context = new ContextDb();
                var question = context.Questions.Where(t => t.QuestionGroup == group).Select(t => t.Ques);
                foreach (var q in question)
                {
                    Q2.Enqueue(q);

                }

                string labelName = "labelQuestion";
                labelQuestionGroup.Text = "Question Group : " + group;
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
            else
            {
                this.Controls.Clear();
                ControlFinalFeedback cc = new ControlFinalFeedback();

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
