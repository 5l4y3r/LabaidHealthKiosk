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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.QuestionGroupComboBox = new System.Windows.Forms.ComboBox();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labaidHealthKioskDataSet = new LabaidHealthKiosk.LabaidHealthKioskDataSet();
            this.questionsTableAdapter = new LabaidHealthKiosk.LabaidHealthKioskDataSetTableAdapters.QuestionsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labaidHealthKioskDataSet1 = new LabaidHealthKiosk.LabaidHealthKioskDataSet1();
            this.questionsTableAdapter1 = new LabaidHealthKiosk.LabaidHealthKioskDataSet1TableAdapters.QuestionsTableAdapter();
            this.AddQBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.questionTxt = new System.Windows.Forms.TextBox();
            this.AddQGroupBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labaidHealthKioskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labaidHealthKioskDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionGroupComboBox
            // 
            this.QuestionGroupComboBox.DataSource = this.questionsBindingSource;
            this.QuestionGroupComboBox.DisplayMember = "QuestionGroup";
            this.QuestionGroupComboBox.FormattingEnabled = true;
            this.QuestionGroupComboBox.Location = new System.Drawing.Point(12, 120);
            this.QuestionGroupComboBox.Name = "QuestionGroupComboBox";
            this.QuestionGroupComboBox.Size = new System.Drawing.Size(506, 21);
            this.QuestionGroupComboBox.TabIndex = 0;
            this.QuestionGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.QuestionGroupComboBox_SelectedIndexChanged);
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.labaidHealthKioskDataSet;
            // 
            // labaidHealthKioskDataSet
            // 
            this.labaidHealthKioskDataSet.DataSetName = "LabaidHealthKioskDataSet";
            this.labaidHealthKioskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionsBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(593, 200);
            this.dataGridView1.TabIndex = 3;
            // 
            // quesDataGridViewTextBoxColumn
            // 
            this.quesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quesDataGridViewTextBoxColumn.DataPropertyName = "Ques";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            this.quesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.quesDataGridViewTextBoxColumn.HeaderText = "Question";
            this.quesDataGridViewTextBoxColumn.Name = "quesDataGridViewTextBoxColumn";
            this.quesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionsBindingSource1
            // 
            this.questionsBindingSource1.DataMember = "Questions";
            this.questionsBindingSource1.DataSource = this.labaidHealthKioskDataSet1;
            // 
            // labaidHealthKioskDataSet1
            // 
            this.labaidHealthKioskDataSet1.DataSetName = "LabaidHealthKioskDataSet1";
            this.labaidHealthKioskDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsTableAdapter1
            // 
            this.questionsTableAdapter1.ClearBeforeFill = true;
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
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(616, 241);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(89, 50);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete Question";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // questionTxt
            // 
            this.questionTxt.Location = new System.Drawing.Point(12, 60);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.Size = new System.Drawing.Size(476, 20);
            this.questionTxt.TabIndex = 6;
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
            this.RefreshBtn.Image = global::LabaidHealthKiosk.Properties.Resources.Custom_Icon_Design_Flatastic_8_Refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(593, 101);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(43, 40);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 33);
            this.textBox1.TabIndex = 10;
            // 
            // ManageQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 513);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddQGroupBtn);
            this.Controls.Add(this.questionTxt);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddQBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionGroupComboBox);
            this.Name = "ManageQuestion";
            this.Text = "ManageQuestion";
            this.Load += new System.EventHandler(this.ManageQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labaidHealthKioskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labaidHealthKioskDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox QuestionGroupComboBox;
        private LabaidHealthKioskDataSet labaidHealthKioskDataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private LabaidHealthKioskDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LabaidHealthKioskDataSet1 labaidHealthKioskDataSet1;
        private System.Windows.Forms.BindingSource questionsBindingSource1;
        private LabaidHealthKioskDataSet1TableAdapters.QuestionsTableAdapter questionsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddQBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox questionTxt;
        private System.Windows.Forms.Button AddQGroupBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}