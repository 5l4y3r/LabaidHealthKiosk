using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityClasses;

namespace LabaidHealthKiosk
{
    public partial class ManageQuestion : Form
    {
        private string tempString ;

        public ManageQuestion()
        {
            InitializeComponent();
        }

        private void ManageQuestion_Load(object sender, EventArgs e)
        {

            this.questionGroupsTableAdapter.Fill(this.questionGroupDataSet.QuestionGroups);

            var con = new ContextDb();


          

        }

        private void AddQGroupBtn_Click(object sender, EventArgs e)
        {
            string s = QuestionGroupTxt.Text;

            BusinessLayer.QuestionClass.AddQuestionGroup(s);
            MessageBox.Show("Qusetion Group added");
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
           // this.questionGroupsTableAdapter.Fill(this.questionGroupDataSet.QuestionGroups);
            var con = new ContextDb();
            tempString = QuestionGroupComboBox.Text;
            var tempData = con.Questions.Where(t => t.QuestionGroup == tempString);

            QuestionGridView.DataSource = tempData.ToList();

        }

        private void QuestionGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = new ContextDb();
            tempString = QuestionGroupComboBox.Text;
            var tempData = con.Questions.Where(t => t.QuestionGroup == tempString);

            QuestionGridView.DataSource = tempData.ToList();



        }

        private void AddQBtn_Click(object sender, EventArgs e)
        {
            string s2 = QuestionTxtBox.Text;
            string s1 = QuestionGroupComboBox.Text;
            BusinessLayer.QuestionClass.AddQuestion(s1,s2);
            MessageBox.Show("Qusetion added");

        }

        private void questionGroupsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
