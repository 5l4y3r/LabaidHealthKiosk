namespace LabaidHealthKiosk
{
    partial class UserView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelUserViewMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelUserViewMain
            // 
            this.PanelUserViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUserViewMain.Location = new System.Drawing.Point(0, 0);
            this.PanelUserViewMain.Name = "PanelUserViewMain";
            this.PanelUserViewMain.Size = new System.Drawing.Size(824, 462);
            this.PanelUserViewMain.TabIndex = 0;
            // 
            // UserView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 462);
            this.ControlBox = false;
            this.Controls.Add(this.PanelUserViewMain);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "UserView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelUserViewMain;
    }
}