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

            var con = new ContextDb();

            this.questionsTableAdapter.Fill(this.labaidHealthKioskDataSet.Questions);

        }

        private void AddQGroupBtn_Click(object sender, EventArgs e)
        {
            string s = questionTxt.Text;

            BusinessLayer.QuestionClass.AddQuestion(s,s);
            MessageBox.Show("Qusetion Group added");
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.questionsTableAdapter.Fill(this.labaidHealthKioskDataSet.Questions);
           
        }

        private void QuestionGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = new ContextDb();
            tempString = QuestionGroupComboBox.Text;
            var tempData = con.Questions.Where(t => t.QuestionGroup == tempString);

            questionsBindingSource1.DataSource = tempData.ToList();

        }

        private void AddQBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
