using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.rtf.text;

namespace LabaidHealthKiosk
{
	public partial class ControlGraph : UserControl
	{
		public ControlGraph()
		{
			InitializeComponent();
		}

		private void ControlGraph_Load(object sender, EventArgs e)
		{
			FillChart();
			CreateChartImg("Feedback");

		}

		private void FillChart()
		{
			//AddXY value in Feedback in series named as Salary  
			ChartFeedback.Series["Feedbacks"].Points.AddXY("Reception", "4");
			ChartFeedback.Series["Feedbacks"].Points.AddXY("Doctor", "5");
			ChartFeedback.Series["Feedbacks"].Points.AddXY("Nursing", "4");
			ChartFeedback.Series["Feedbacks"].Points.AddXY("House Keeping", "3");
			ChartFeedback.Series["Feedbacks"].Points.AddXY("Food", "1");
			ChartFeedback.Series["Feedbacks"].Points.AddXY("Billing & Treatment", "1");
			ChartFeedback.Series["Feedbacks"].Points.AddXY("Overall", "3.5");
			//chart title  
			ChartFeedback.Titles.Add("Feedback Chart");
		}

		public void CreateChartImg(string name)
		{
			string reportname = "report_of_" + name;
			
			//Exporting to Jpeg
			string folderPath = @"C:\Kiosk Reports\";
			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}

			this.ChartFeedback.SaveImage(folderPath+name+".png",ChartImageFormat.Png);

			
				
			}
		

	}
	}
