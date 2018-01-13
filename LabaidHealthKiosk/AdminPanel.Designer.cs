namespace LabaidHealthKiosk
{
    partial class AdminPanel
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
            this.ManageAdBtn = new System.Windows.Forms.Button();
            this.ManageQBtn = new System.Windows.Forms.Button();
            this.MangeReportBtn = new System.Windows.Forms.Button();
            this.ManageVBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageAdBtn
            // 
            this.ManageAdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ManageAdBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAdBtn.ForeColor = System.Drawing.Color.Green;
            this.ManageAdBtn.Location = new System.Drawing.Point(51, 51);
            this.ManageAdBtn.Name = "ManageAdBtn";
            this.ManageAdBtn.Size = new System.Drawing.Size(195, 142);
            this.ManageAdBtn.TabIndex = 0;
            this.ManageAdBtn.Text = "Manage Advertisement";
            this.ManageAdBtn.UseVisualStyleBackColor = false;
            // 
            // ManageQBtn
            // 
            this.ManageQBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ManageQBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageQBtn.ForeColor = System.Drawing.Color.Green;
            this.ManageQBtn.Location = new System.Drawing.Point(376, 51);
            this.ManageQBtn.Name = "ManageQBtn";
            this.ManageQBtn.Size = new System.Drawing.Size(195, 142);
            this.ManageQBtn.TabIndex = 1;
            this.ManageQBtn.Text = "Manage Questionaries";
            this.ManageQBtn.UseVisualStyleBackColor = false;
            // 
            // MangeReportBtn
            // 
            this.MangeReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MangeReportBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangeReportBtn.ForeColor = System.Drawing.Color.Green;
            this.MangeReportBtn.Location = new System.Drawing.Point(51, 236);
            this.MangeReportBtn.Name = "MangeReportBtn";
            this.MangeReportBtn.Size = new System.Drawing.Size(195, 142);
            this.MangeReportBtn.TabIndex = 2;
            this.MangeReportBtn.Text = "Manage Reports";
            this.MangeReportBtn.UseVisualStyleBackColor = false;
            // 
            // ManageVBtn
            // 
            this.ManageVBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ManageVBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageVBtn.ForeColor = System.Drawing.Color.Green;
            this.ManageVBtn.Location = new System.Drawing.Point(376, 236);
            this.ManageVBtn.Name = "ManageVBtn";
            this.ManageVBtn.Size = new System.Drawing.Size(195, 142);
            this.ManageVBtn.TabIndex = 3;
            this.ManageVBtn.Text = "Manage Viewing Options";
            this.ManageVBtn.UseVisualStyleBackColor = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 476);
            this.Controls.Add(this.ManageVBtn);
            this.Controls.Add(this.MangeReportBtn);
            this.Controls.Add(this.ManageQBtn);
            this.Controls.Add(this.ManageAdBtn);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageAdBtn;
        private System.Windows.Forms.Button ManageQBtn;
        private System.Windows.Forms.Button MangeReportBtn;
        private System.Windows.Forms.Button ManageVBtn;
    }
}