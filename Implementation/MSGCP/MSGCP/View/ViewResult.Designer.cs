namespace MSGCP.View
{
    partial class ViewResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewResult));
            this.btn_View = new System.Windows.Forms.Button();
            this.cmb_Section = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Roll = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Stdname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Grade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Exam = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_MO = new System.Windows.Forms.DataGridView();
            this.resultIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examinationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksObtainedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectMarks_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.resultss = new MSGCP.Resultss();
            this.resultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.lbl_Percentage = new System.Windows.Forms.Label();
            this.resultTableAdapter1 = new MSGCP.ResultMSGCPDataSetTableAdapters.ResultTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.resultTableAdapter2 = new MSGCP.ResultssTableAdapters.ResultTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_Print = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Stat = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(711, 146);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(83, 22);
            this.btn_View.TabIndex = 50;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // cmb_Section
            // 
            this.cmb_Section.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Section.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Section.FormattingEnabled = true;
            this.cmb_Section.Location = new System.Drawing.Point(503, 98);
            this.cmb_Section.Name = "cmb_Section";
            this.cmb_Section.Size = new System.Drawing.Size(81, 21);
            this.cmb_Section.TabIndex = 45;
            this.cmb_Section.SelectedIndexChanged += new System.EventHandler(this.loadStudent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(398, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Section";
            // 
            // cmb_Roll
            // 
            this.cmb_Roll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Roll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Roll.FormattingEnabled = true;
            this.cmb_Roll.Location = new System.Drawing.Point(711, 96);
            this.cmb_Roll.Name = "cmb_Roll";
            this.cmb_Roll.Size = new System.Drawing.Size(83, 21);
            this.cmb_Roll.TabIndex = 46;
            this.cmb_Roll.SelectedIndexChanged += new System.EventHandler(this.Cmb_Roll_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(640, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Roll No";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cmb_Stdname
            // 
            this.cmb_Stdname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Stdname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Stdname.FormattingEnabled = true;
            this.cmb_Stdname.Location = new System.Drawing.Point(133, 150);
            this.cmb_Stdname.Name = "cmb_Stdname";
            this.cmb_Stdname.Size = new System.Drawing.Size(184, 21);
            this.cmb_Stdname.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(19, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Student Name";
            // 
            // cmb_Grade
            // 
            this.cmb_Grade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Grade.FormattingEnabled = true;
            this.cmb_Grade.Location = new System.Drawing.Point(133, 99);
            this.cmb_Grade.Name = "cmb_Grade";
            this.cmb_Grade.Size = new System.Drawing.Size(184, 21);
            this.cmb_Grade.TabIndex = 48;
            this.cmb_Grade.SelectedIndexChanged += new System.EventHandler(this.loadStudent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Class";
            // 
            // cmb_Exam
            // 
            this.cmb_Exam.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Exam.FormattingEnabled = true;
            this.cmb_Exam.Location = new System.Drawing.Point(503, 148);
            this.cmb_Exam.Name = "cmb_Exam";
            this.cmb_Exam.Size = new System.Drawing.Size(202, 21);
            this.cmb_Exam.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label9.Location = new System.Drawing.Point(398, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Examination ";
            // 
            // dgv_MO
            // 
            this.dgv_MO.AllowUserToAddRows = false;
            this.dgv_MO.AllowUserToDeleteRows = false;
            this.dgv_MO.AutoGenerateColumns = false;
            this.dgv_MO.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_MO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.rollNoDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.examinationTypeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.full_Marks,
            this.pass_Marks,
            this.marksObtainedDataGridViewTextBoxColumn,
            this.SubjectMarks_Id});
            this.dgv_MO.DataSource = this.resultBindingSource2;
            this.dgv_MO.Location = new System.Drawing.Point(19, 209);
            this.dgv_MO.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_MO.MinimumSize = new System.Drawing.Size(15, 10);
            this.dgv_MO.Name = "dgv_MO";
            this.dgv_MO.ReadOnly = true;
            this.dgv_MO.RowHeadersWidth = 100;
            this.dgv_MO.Size = new System.Drawing.Size(686, 292);
            this.dgv_MO.TabIndex = 51;
            // 
            // resultIdDataGridViewTextBoxColumn
            // 
            this.resultIdDataGridViewTextBoxColumn.DataPropertyName = "result_Id";
            this.resultIdDataGridViewTextBoxColumn.HeaderText = "result_Id";
            this.resultIdDataGridViewTextBoxColumn.Name = "resultIdDataGridViewTextBoxColumn";
            this.resultIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "student_Id";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rollNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "student_Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionDataGridViewTextBoxColumn.Visible = false;
            // 
            // examinationTypeDataGridViewTextBoxColumn
            // 
            this.examinationTypeDataGridViewTextBoxColumn.DataPropertyName = "examination_Type";
            this.examinationTypeDataGridViewTextBoxColumn.HeaderText = "examination_Type";
            this.examinationTypeDataGridViewTextBoxColumn.Name = "examinationTypeDataGridViewTextBoxColumn";
            this.examinationTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // full_Marks
            // 
            this.full_Marks.DataPropertyName = "full_Marks";
            this.full_Marks.HeaderText = "Full Marks";
            this.full_Marks.Name = "full_Marks";
            this.full_Marks.ReadOnly = true;
            this.full_Marks.Width = 90;
            // 
            // pass_Marks
            // 
            this.pass_Marks.DataPropertyName = "pass_Marks";
            this.pass_Marks.HeaderText = "Pass Marks";
            this.pass_Marks.Name = "pass_Marks";
            this.pass_Marks.ReadOnly = true;
            this.pass_Marks.Width = 90;
            // 
            // marksObtainedDataGridViewTextBoxColumn
            // 
            this.marksObtainedDataGridViewTextBoxColumn.DataPropertyName = "marks_Obtained";
            this.marksObtainedDataGridViewTextBoxColumn.HeaderText = "marks_Obtained";
            this.marksObtainedDataGridViewTextBoxColumn.Name = "marksObtainedDataGridViewTextBoxColumn";
            this.marksObtainedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SubjectMarks_Id
            // 
            this.SubjectMarks_Id.DataPropertyName = "SubjectMarks_Id";
            this.SubjectMarks_Id.HeaderText = "SubjectMarks_Id";
            this.SubjectMarks_Id.Name = "SubjectMarks_Id";
            this.SubjectMarks_Id.ReadOnly = true;
            this.SubjectMarks_Id.Visible = false;
            // 
            // resultBindingSource2
            // 
            this.resultBindingSource2.DataMember = "Result";
            this.resultBindingSource2.DataSource = this.resultss;
            // 
            // resultss
            // 
            this.resultss.DataSetName = "Resultss";
            this.resultss.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(20, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Total:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.lbl_Total.Location = new System.Drawing.Point(78, 511);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(18, 19);
            this.lbl_Total.TabIndex = 53;
            this.lbl_Total.Text = "0";
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.lbl_Percent.Location = new System.Drawing.Point(22, 540);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(102, 19);
            this.lbl_Percent.TabIndex = 52;
            this.lbl_Percent.Text = "Percentage:";
            // 
            // lbl_Percentage
            // 
            this.lbl_Percentage.AutoSize = true;
            this.lbl_Percentage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.lbl_Percentage.Location = new System.Drawing.Point(130, 540);
            this.lbl_Percentage.Name = "lbl_Percentage";
            this.lbl_Percentage.Size = new System.Drawing.Size(18, 19);
            this.lbl_Percentage.TabIndex = 53;
            this.lbl_Percentage.Text = "0";
            // 
            // resultTableAdapter1
            // 
            this.resultTableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 39);
            this.panel2.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(370, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 25);
            this.label16.TabIndex = 9;
            this.label16.Text = "Result\r\n";
            // 
            // resultTableAdapter2
            // 
            this.resultTableAdapter2.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(711, 184);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(83, 22);
            this.btn_Print.TabIndex = 55;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(-1, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(83, 22);
            this.btn_Back.TabIndex = 56;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // lbl_Stat
            // 
            this.lbl_Stat.AutoSize = true;
            this.lbl_Stat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Stat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.lbl_Stat.Location = new System.Drawing.Point(211, 511);
            this.lbl_Stat.Name = "lbl_Stat";
            this.lbl_Stat.Size = new System.Drawing.Size(64, 19);
            this.lbl_Stat.TabIndex = 52;
            this.lbl_Stat.Text = "Status:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.lbl_status.Location = new System.Drawing.Point(269, 511);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(18, 19);
            this.lbl_status.TabIndex = 53;
            this.lbl_status.Text = "0";
            // 
            // ViewResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 648);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_Percentage);
            this.Controls.Add(this.lbl_Percent);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Stat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_MO);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.cmb_Section);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Roll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Stdname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Grade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Exam);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewResult";
            this.Load += new System.EventHandler(this.ViewResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.ComboBox cmb_Section;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Roll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Stdname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Exam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_MO;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Percent;
        private System.Windows.Forms.Label lbl_Percentage;
        private System.Windows.Forms.BindingSource resultBindingSource1;
        private ResultMSGCPDataSetTableAdapters.ResultTableAdapter resultTableAdapter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private Resultss resultss;
        private System.Windows.Forms.BindingSource resultBindingSource2;
        private ResultssTableAdapters.ResultTableAdapter resultTableAdapter2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examinationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_Marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_Marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksObtainedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectMarks_Id;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Stat;
        private System.Windows.Forms.Label lbl_status;
    }
}