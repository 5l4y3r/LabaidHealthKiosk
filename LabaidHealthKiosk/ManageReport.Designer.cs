namespace LabaidHealthKiosk
{
    partial class ManageReport
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.DatagridFeedback = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbacksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportFeedback = new LabaidHealthKiosk.reportFeedback();
            this.DatagridUserList = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportUserList = new LabaidHealthKiosk.ReportUserList();
            this.DataGridComplain = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userComplainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportComplainList = new LabaidHealthKiosk.ReportComplainList();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnComplain = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.complainsTableAdapter = new LabaidHealthKiosk.ReportComplainListTableAdapters.ComplainsTableAdapter();
            this.userInfoesTableAdapter = new LabaidHealthKiosk.ReportUserListTableAdapters.UserInfoesTableAdapter();
            this.feedbacksTableAdapter = new LabaidHealthKiosk.reportFeedbackTableAdapters.FeedbacksTableAdapter();
            this.panelGraphMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridComplain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportComplainList)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.73809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.2619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelReport, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.25536F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.74464F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 527);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.panelGraphMain);
            this.panelReport.Controls.Add(this.DatagridFeedback);
            this.panelReport.Controls.Add(this.DatagridUserList);
            this.panelReport.Controls.Add(this.DataGridComplain);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(158, 72);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(717, 452);
            this.panelReport.TabIndex = 0;
            // 
            // DatagridFeedback
            // 
            this.DatagridFeedback.AllowUserToAddRows = false;
            this.DatagridFeedback.AllowUserToDeleteRows = false;
            this.DatagridFeedback.AutoGenerateColumns = false;
            this.DatagridFeedback.BackgroundColor = System.Drawing.Color.White;
            this.DatagridFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn2,
            this.ansDataGridViewTextBoxColumn});
            this.DatagridFeedback.DataSource = this.feedbacksBindingSource;
            this.DatagridFeedback.Location = new System.Drawing.Point(353, 3);
            this.DatagridFeedback.Name = "DatagridFeedback";
            this.DatagridFeedback.ReadOnly = true;
            this.DatagridFeedback.Size = new System.Drawing.Size(292, 127);
            this.DatagridFeedback.TabIndex = 2;
            // 
            // userNameDataGridViewTextBoxColumn2
            // 
            this.userNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn2.FillWeight = 20F;
            this.userNameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.userNameDataGridViewTextBoxColumn2.Name = "userNameDataGridViewTextBoxColumn2";
            this.userNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ansDataGridViewTextBoxColumn
            // 
            this.ansDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ansDataGridViewTextBoxColumn.DataPropertyName = "Ans";
            this.ansDataGridViewTextBoxColumn.FillWeight = 80F;
            this.ansDataGridViewTextBoxColumn.HeaderText = "Answers";
            this.ansDataGridViewTextBoxColumn.Name = "ansDataGridViewTextBoxColumn";
            this.ansDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feedbacksBindingSource
            // 
            this.feedbacksBindingSource.DataMember = "Feedbacks";
            this.feedbacksBindingSource.DataSource = this.reportFeedback;
            // 
            // reportFeedback
            // 
            this.reportFeedback.DataSetName = "reportFeedback";
            this.reportFeedback.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatagridUserList
            // 
            this.DatagridUserList.AllowUserToAddRows = false;
            this.DatagridUserList.AllowUserToDeleteRows = false;
            this.DatagridUserList.AutoGenerateColumns = false;
            this.DatagridUserList.BackgroundColor = System.Drawing.Color.White;
            this.DatagridUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn1,
            this.mobileNoDataGridViewTextBoxColumn,
            this.relationDataGridViewTextBoxColumn});
            this.DatagridUserList.DataSource = this.userInfoesBindingSource;
            this.DatagridUserList.Location = new System.Drawing.Point(3, 147);
            this.DatagridUserList.Name = "DatagridUserList";
            this.DatagridUserList.ReadOnly = true;
            this.DatagridUserList.Size = new System.Drawing.Size(205, 134);
            this.DatagridUserList.TabIndex = 1;
            // 
            // userNameDataGridViewTextBoxColumn1
            // 
            this.userNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn1.FillWeight = 30F;
            this.userNameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.userNameDataGridViewTextBoxColumn1.Name = "userNameDataGridViewTextBoxColumn1";
            this.userNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.FillWeight = 40F;
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationDataGridViewTextBoxColumn
            // 
            this.relationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.relationDataGridViewTextBoxColumn.DataPropertyName = "Relation";
            this.relationDataGridViewTextBoxColumn.FillWeight = 30F;
            this.relationDataGridViewTextBoxColumn.HeaderText = "Relation";
            this.relationDataGridViewTextBoxColumn.Name = "relationDataGridViewTextBoxColumn";
            this.relationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userInfoesBindingSource
            // 
            this.userInfoesBindingSource.DataMember = "UserInfoes";
            this.userInfoesBindingSource.DataSource = this.reportUserList;
            // 
            // reportUserList
            // 
            this.reportUserList.DataSetName = "ReportUserList";
            this.reportUserList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataGridComplain
            // 
            this.DataGridComplain.AllowUserToAddRows = false;
            this.DataGridComplain.AllowUserToDeleteRows = false;
            this.DataGridComplain.AutoGenerateColumns = false;
            this.DataGridComplain.BackgroundColor = System.Drawing.Color.White;
            this.DataGridComplain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridComplain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.complainGroupDataGridViewTextBoxColumn,
            this.userComplainDataGridViewTextBoxColumn});
            this.DataGridComplain.DataSource = this.complainsBindingSource;
            this.DataGridComplain.Location = new System.Drawing.Point(0, 0);
            this.DataGridComplain.Name = "DataGridComplain";
            this.DataGridComplain.ReadOnly = true;
            this.DataGridComplain.Size = new System.Drawing.Size(344, 130);
            this.DataGridComplain.TabIndex = 0;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complainGroupDataGridViewTextBoxColumn
            // 
            this.complainGroupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.complainGroupDataGridViewTextBoxColumn.DataPropertyName = "ComplainGroup";
            this.complainGroupDataGridViewTextBoxColumn.FillWeight = 20F;
            this.complainGroupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.complainGroupDataGridViewTextBoxColumn.Name = "complainGroupDataGridViewTextBoxColumn";
            this.complainGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userComplainDataGridViewTextBoxColumn
            // 
            this.userComplainDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userComplainDataGridViewTextBoxColumn.DataPropertyName = "UserComplain";
            this.userComplainDataGridViewTextBoxColumn.FillWeight = 60F;
            this.userComplainDataGridViewTextBoxColumn.HeaderText = "Complain";
            this.userComplainDataGridViewTextBoxColumn.Name = "userComplainDataGridViewTextBoxColumn";
            this.userComplainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complainsBindingSource
            // 
            this.complainsBindingSource.DataMember = "Complains";
            this.complainsBindingSource.DataSource = this.reportComplainList;
            // 
            // reportComplainList
            // 
            this.reportComplainList.DataSetName = "ReportComplainList";
            this.reportComplainList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnComplain, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUserList, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnFeedback, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 72);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(149, 452);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnComplain
            // 
            this.btnComplain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComplain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplain.Location = new System.Drawing.Point(3, 3);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(143, 61);
            this.btnComplain.TabIndex = 0;
            this.btnComplain.Text = "See Complain List";
            this.btnComplain.UseVisualStyleBackColor = true;
            this.btnComplain.Click += new System.EventHandler(this.btnComplain_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserList.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnUserList.Location = new System.Drawing.Point(3, 181);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(143, 61);
            this.btnUserList.TabIndex = 2;
            this.btnUserList.Text = "See User List";
            this.btnUserList.UseVisualStyleBackColor = true;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeedback.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnFeedback.Location = new System.Drawing.Point(3, 92);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(143, 61);
            this.btnFeedback.TabIndex = 1;
            this.btnFeedback.Text = "See Feedback List";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.02332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.61808F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.46356F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.749271F));
            this.tableLayoutPanel3.Controls.Add(this.btnDownload, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGraph, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(158, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(717, 63);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnDownload
            // 
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDownload.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDownload.Location = new System.Drawing.Point(3, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(310, 57);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGraph.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnGraph.Location = new System.Drawing.Point(438, 3);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(263, 57);
            this.btnGraph.TabIndex = 2;
            this.btnGraph.Text = "See Graph of Feedback";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // complainsTableAdapter
            // 
            this.complainsTableAdapter.ClearBeforeFill = true;
            // 
            // userInfoesTableAdapter
            // 
            this.userInfoesTableAdapter.ClearBeforeFill = true;
            // 
            // feedbacksTableAdapter
            // 
            this.feedbacksTableAdapter.ClearBeforeFill = true;
            // 
            // panelGraphMain
            // 
            this.panelGraphMain.Location = new System.Drawing.Point(270, 147);
            this.panelGraphMain.Name = "panelGraphMain";
            this.panelGraphMain.Size = new System.Drawing.Size(338, 278);
            this.panelGraphMain.TabIndex = 3;
            // 
            // ManageReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 527);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageReport";
            this.Text = "ManageReport";
            this.Load += new System.EventHandler(this.ManageReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridComplain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportComplainList)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnComplain;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.DataGridView DataGridComplain;
        private ReportComplainList reportComplainList;
        private System.Windows.Forms.BindingSource complainsBindingSource;
        private ReportComplainListTableAdapters.ComplainsTableAdapter complainsTableAdapter;
        private ReportUserList reportUserList;
        private System.Windows.Forms.BindingSource userInfoesBindingSource;
        private ReportUserListTableAdapters.UserInfoesTableAdapter userInfoesTableAdapter;
        private reportFeedback reportFeedback;
        private System.Windows.Forms.BindingSource feedbacksBindingSource;
        private reportFeedbackTableAdapters.FeedbacksTableAdapter feedbacksTableAdapter;
        private System.Windows.Forms.DataGridView DatagridFeedback;
        private System.Windows.Forms.DataGridView DatagridUserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userComplainDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelGraphMain;
    }
}