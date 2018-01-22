namespace LabaidHealthKiosk
{
    partial class ControlAdvertisement
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
            this.components = new System.ComponentModel.Container();
            this.timerAdvertise = new System.Windows.Forms.Timer(this.components);
            this.AdvertisementPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxAdvertise = new System.Windows.Forms.PictureBox();
            this.AdvertisementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvertise)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAdvertise
            // 
            this.timerAdvertise.Interval = 5000;
            this.timerAdvertise.Tick += new System.EventHandler(this.timerAdvertise_Tick);
            // 
            // AdvertisementPanel
            // 
            this.AdvertisementPanel.BackColor = System.Drawing.Color.Transparent;
            this.AdvertisementPanel.ColumnCount = 1;
            this.AdvertisementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AdvertisementPanel.Controls.Add(this.pictureBoxAdvertise, 0, 0);
            this.AdvertisementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvertisementPanel.Location = new System.Drawing.Point(0, 0);
            this.AdvertisementPanel.Name = "AdvertisementPanel";
            this.AdvertisementPanel.RowCount = 1;
            this.AdvertisementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AdvertisementPanel.Size = new System.Drawing.Size(910, 517);
            this.AdvertisementPanel.TabIndex = 0;
            this.AdvertisementPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdvertisementPanel_Paint);
            // 
            // pictureBoxAdvertise
            // 
            this.pictureBoxAdvertise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAdvertise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAdvertise.Image = global::LabaidHealthKiosk.Properties.Resources.ss;
            this.pictureBoxAdvertise.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAdvertise.Name = "pictureBoxAdvertise";
            this.pictureBoxAdvertise.Size = new System.Drawing.Size(904, 511);
            this.pictureBoxAdvertise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdvertise.TabIndex = 0;
            this.pictureBoxAdvertise.TabStop = false;
            this.pictureBoxAdvertise.Click += new System.EventHandler(this.pictureBoxAdvertise_Click);
            // 
            // ControlAdvertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdvertisementPanel);
            this.Name = "ControlAdvertisement";
            this.Size = new System.Drawing.Size(910, 517);
            this.AdvertisementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvertise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAdvertise;
        private System.Windows.Forms.TableLayoutPanel AdvertisementPanel;
        private System.Windows.Forms.PictureBox pictureBoxAdvertise;
    }
}
