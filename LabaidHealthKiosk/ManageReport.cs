using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Color = System.Drawing.Color;
using System.Windows.Forms.DataVisualization.Charting;

namespace LabaidHealthKiosk
{
    public partial class ManageReport : Form
    {
        static int x = 0;
        public ManageReport()
        {
            InitializeComponent();
        }

        private void ManageReport_Load(object sender, EventArgs e)
        {
           
            DataGridComplain.Visible = false;
            DatagridFeedback.Visible = false;
            DatagridUserList.Visible = false;
            panelGraphMain.Visible = false;
            complainsTableAdapter.Fill(reportComplainList.Complains);
            userInfoesTableAdapter.Fill(reportUserList.UserInfoes);
            feedbacksTableAdapter.Fill(reportFeedback.Feedbacks);
        }

       
        private void btnComplain_Click(object sender, EventArgs e)
        {
            x = 1;
            DataGridComplain.Visible = true;
            DatagridFeedback.Visible = false;
            DatagridUserList.Visible = false;
            panelGraphMain.Visible = false;
            DataGridComplain.Dock = DockStyle.Fill;


        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            x = 2;
            DataGridComplain.Visible = false;
            DatagridFeedback.Visible = true;
            DatagridUserList.Visible = false;
            panelGraphMain.Visible = false;

            DatagridFeedback.Dock = DockStyle.Fill;
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            x = 3;
            DataGridComplain.Visible = false;
            DatagridFeedback.Visible = false;
            DatagridUserList.Visible = true;
            panelGraphMain.Visible = false;
            DatagridUserList.Dock = DockStyle.Fill;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                createPdf(DataGridComplain, "ComplainList");

            }
            else if (x == 2)
            {
                createPdf(DatagridFeedback, "FeedbackList");

            }
            else if (x == 3)
            {
                createPdf(DatagridUserList, "UserList");

            }
            else if (x == 4)
            {
                string folderPath = @"C:\Kiosk Reports\";
                System.Diagnostics.Process.Start(folderPath + "Feedback"+"_"+ DateTime.Now.ToString("dd_MM_yyyy") +".png");
            }

        }
        private void createPdf(DataGridView x, string name)
        {
            string reportname = "report_of_" + name;
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(x.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100f;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;
           

            //Adding Header row
            foreach (DataGridViewColumn column in x.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.Color(135, 206, 250);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in x.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = @"C:\Kiosk Reports\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + reportname+"_"+ DateTime.Now.ToString("dd_MM_yyyy") +".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("Download successfull & file is saved in " + folderPath);
            System.Diagnostics.Process.Start(folderPath+reportname+ "_" + DateTime.Now.ToString("dd_MM_yyyy") + ".pdf");
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            x = 4;
            DataGridComplain.Visible = false;
            DatagridFeedback.Visible = false;
            DatagridUserList.Visible = false;
            panelGraphMain.Visible = true;
            panelGraphMain.Controls.Clear();
            panelGraphMain.Dock = DockStyle.Fill;
            ControlGraph cc = new ControlGraph();
            panelGraphMain.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;
            MessageBox.Show(@"Download successfull & file is saved in C:\Kiosk Reports\ ");
        }

       
    }
}
