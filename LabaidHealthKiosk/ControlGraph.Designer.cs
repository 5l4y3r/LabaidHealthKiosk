namespace LabaidHealthKiosk
{
    partial class ControlGraph
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartFeedback = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartFeedback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 469);
            this.panel1.TabIndex = 0;
            // 
            // ChartFeedback
            // 
            this.ChartFeedback.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartFeedback.ChartAreas.Add(chartArea1);
            this.ChartFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.AutoFitMinFontSize = 12;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Font = new System.Drawing.Font("Century Gothic", 8F);
            legend1.ForeColor = System.Drawing.Color.DarkGreen;
            legend1.Name = "FeedbackStar";
            legend1.TitleFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.Maroon;
            this.ChartFeedback.Legends.Add(legend1);
            this.ChartFeedback.Location = new System.Drawing.Point(0, 0);
            this.ChartFeedback.Name = "ChartFeedback";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "FeedbackStar";
            series1.Name = "Feedbacks";
            this.ChartFeedback.Series.Add(series1);
            this.ChartFeedback.Size = new System.Drawing.Size(790, 469);
            this.ChartFeedback.TabIndex = 0;
            this.ChartFeedback.Text = "Avarage feedbacks";
            // 
            // ControlGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ControlGraph";
            this.Size = new System.Drawing.Size(790, 469);
            this.Load += new System.EventHandler(this.ControlGraph_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFeedback;
    }
}
