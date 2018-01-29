namespace LabaidHealthKiosk
{
    partial class ManageQuestion
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
            this.QuestionGroupComboBox = new System.Windows.Forms.ComboBox();
            this.questionGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionGroupDataSet = new LabaidHealthKiosk.QuestionGroupDataSet();
            this.labaidHealthKioskDataSet = new LabaidHealthKiosk.LabaidHealthKioskDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionGridView = new System.Windows.Forms.DataGridView();
            this.quesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionDataSet = new LabaidHealthKiosk.QuestionDataSet();
            this.AddQBtn = new System.Windows.Forms.Button();
            this.QuestionGroupTxt = new System.Windows.Forms.TextBox();
            this.AddQGroupBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.questionGroupsTableAdapter = new LabaidHealthKiosk.QuestionGroupDataSetTableAdapters.QuestionGroupsTableAdapter();
            this.QuestionTxtBox = new System.Windows.Forms.TextBox();
            this.questionsTableAdapter = new LabaidHealthKiosk.QuestionDataSetTableAdapters.QuestionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.questionGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionGroupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labaidHealthKioskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionGroupComboBox
            // 
            this.QuestionGroupComboBox.DataSource = this.questionGroupsBindingSource;
            this.QuestionGroupComboBox.DisplayMember = "GroupName";
            this.QuestionGroupComboBox.FormattingEnabled = true;
            this.QuestionGroupComboBox.Location = new System.Drawing.Point(12, 120);
            this.QuestionGroupComboBox.Name = "QuestionGroupComboBox";
            this.QuestionGroupComboBox.Size = new System.Drawing.Size(506, 21);
            this.QuestionGroupComboBox.TabIndex = 0;
            this.QuestionGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.QuestionGroupComboBox_SelectedIndexChanged);
            // 
            // questionGroupsBindingSource
            // 
            this.questionGroupsBindingSource.DataMember = "QuestionGroups";
            this.questionGroupsBindingSource.DataSource = this.questionGroupDataSet;
            this.questionGroupsBindingSource.CurrentChanged += new System.EventHandler(this.questionGroupsBindingSource_CurrentChanged);
            // 
            // questionGroupDataSet
            // 
            this.questionGroupDataSet.DataSetName = "QuestionGroupDataSet";
            this.questionGroupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labaidHealthKioskDataSet
            // 
            this.labaidHealthKioskDataSet.DataSetName = "LabaidHealthKioskDataSet";
            this.labaidHealthKioskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Questions";
            // 
            // QuestionGridView
            // 
            this.QuestionGridView.AllowUserToAddRows = false;
            this.QuestionGridView.AllowUserToDeleteRows = false;
            this.QuestionGridView.AutoGenerateColumns = false;
            this.QuestionGridView.BackgroundColor = System.Drawing.Color.White;
            this.QuestionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quesDataGridViewTextBoxColumn});
            this.QuestionGridView.DataSource = this.questionsBindingSource;
            this.QuestionGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuestionGridView.Location = new System.Drawing.Point(3, 250);
            this.QuestionGridView.Name = "QuestionGridView";
            this.QuestionGridView.ReadOnly = true;
            this.QuestionGridView.Size = new System.Drawing.Size(593, 200);
            this.QuestionGridView.TabIndex = 3;
            // 
            // quesDataGridViewTextBoxColumn
            // 
            this.quesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quesDataGridViewTextBoxColumn.DataPropertyName = "Ques";
            this.quesDataGridViewTextBoxColumn.HeaderText = "Questions";
            this.quesDataGridViewTextBoxColumn.Name = "quesDataGridViewTextBoxColumn";
            this.quesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.questionDataSet;
            // 
            // questionDataSet
            // 
            this.questionDataSet.DataSetName = "QuestionDataSet";
            this.questionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddQBtn
            // 
            this.AddQBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddQBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQBtn.Location = new System.Drawing.Point(535, 165);
            this.AddQBtn.Name = "AddQBtn";
            this.AddQBtn.Size = new System.Drawing.Size(124, 33);
            this.AddQBtn.TabIndex = 4;
            this.AddQBtn.Text = "Add Question";
            this.AddQBtn.UseVisualStyleBackColor = false;
            this.AddQBtn.Click += new System.EventHandler(this.AddQBtn_Click);
            // 
            // QuestionGroupTxt
            // 
            this.QuestionGroupTxt.Location = new System.Drawing.Point(12, 60);
            this.QuestionGroupTxt.Name = "QuestionGroupTxt";
            this.QuestionGroupTxt.Size = new System.Drawing.Size(476, 20);
            this.QuestionGroupTxt.TabIndex = 6;
            // 
            // AddQGroupBtn
            // 
            this.AddQGroupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddQGroupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQGroupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddQGroupBtn.Location = new System.Drawing.Point(513, 52);
            this.AddQGroupBtn.Name = "AddQGroupBtn";
            this.AddQGroupBtn.Size = new System.Drawing.Size(192, 35);
            this.AddQGroupBtn.TabIndex = 7;
            this.AddQGroupBtn.Text = "Add New Question Group";
            this.AddQGroupBtn.UseVisualStyleBackColor = false;
            this.AddQGroupBtn.Click += new System.EventHandler(this.AddQGroupBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Question group";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBtn.Location = new System.Drawing.Point(593, 101);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(43, 40);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // questionGroupsTableAdapter
            // 
            this.questionGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // QuestionTxtBox
            // 
            this.QuestionTxtBox.Location = new System.Drawing.Point(12, 165);
            this.QuestionTxtBox.Multiline = true;
            this.QuestionTxtBox.Name = "QuestionTxtBox";
            this.QuestionTxtBox.Size = new System.Drawing.Size(506, 33);
            this.QuestionTxtBox.TabIndex = 10;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // ManageQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 513);
            this.Controls.Add(this.QuestionTxtBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddQGroupBtn);
            this.Controls.Add(this.QuestionGroupTxt);
            this.Controls.Add(this.AddQBtn);
            this.Controls.Add(this.QuestionGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionGroupComboBox);
            this.Name = "ManageQuestion";
            this.Text = "ManageQuestion";
            this.Load += new System.EventHandler(this.ManageQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionGroupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labaidHealthKioskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox QuestionGroupComboBox;
        private LabaidHealthKioskDataSet labaidHealthKioskDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView QuestionGridView;
        private System.Windows.Forms.Button AddQBtn;
        private System.Windows.Forms.TextBox QuestionGroupTxt;
        private System.Windows.Forms.Button AddQGroupBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RefreshBtn;
        private QuestionGroupDataSet questionGroupDataSet;
        private System.Windows.Forms.BindingSource questionGroupsBindingSource;
        private QuestionGroupDataSetTableAdapters.QuestionGroupsTableAdapter questionGroupsTableAdapter;
        private System.Windows.Forms.TextBox QuestionTxtBox;
        private QuestionDataSet questionDataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private QuestionDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesDataGridViewTextBoxColumn;
    }
}