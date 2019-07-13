namespace MSGCP.View
{
    partial class MarksObtainedEntry
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
            this.cmb_Exam = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Grade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Roll = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Section = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Stdname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Remark = new System.Windows.Forms.ComboBox();
            this.dgv_MO = new System.Windows.Forms.DataGridView();
            this.resultBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.marksobtainedResult = new MSGCP.MarksobtainedResult();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Subject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_OM = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.resultTableAdapter4 = new MSGCP.MarksobtainedResultTableAdapters.ResultTableAdapter();
            this.resultIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectMarks_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examinationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksObtainedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examinationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksobtainedResult)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Exam
            // 
            this.cmb_Exam.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Exam.FormattingEnabled = true;
            this.cmb_Exam.Location = new System.Drawing.Point(484, 167);
            this.cmb_Exam.Name = "cmb_Exam";
            this.cmb_Exam.Size = new System.Drawing.Size(223, 21);
            this.cmb_Exam.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label9.Location = new System.Drawing.Point(364, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Examination ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(19, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Class";
            // 
            // cmb_Grade
            // 
            this.cmb_Grade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Grade.FormattingEnabled = true;
            this.cmb_Grade.Location = new System.Drawing.Point(153, 109);
            this.cmb_Grade.Name = "cmb_Grade";
            this.cmb_Grade.Size = new System.Drawing.Size(184, 21);
            this.cmb_Grade.TabIndex = 33;
            this.cmb_Grade.SelectedIndexChanged += new System.EventHandler(this.loadStudent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(642, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Roll No";
            // 
            // cmb_Roll
            // 
            this.cmb_Roll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Roll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Roll.FormattingEnabled = true;
            this.cmb_Roll.Location = new System.Drawing.Point(713, 107);
            this.cmb_Roll.Name = "cmb_Roll";
            this.cmb_Roll.Size = new System.Drawing.Size(86, 21);
            this.cmb_Roll.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(364, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Section";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // cmb_Section
            // 
            this.cmb_Section.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Section.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Section.FormattingEnabled = true;
            this.cmb_Section.Location = new System.Drawing.Point(484, 107);
            this.cmb_Section.Name = "cmb_Section";
            this.cmb_Section.Size = new System.Drawing.Size(114, 21);
            this.cmb_Section.TabIndex = 33;
            this.cmb_Section.SelectedIndexChanged += new System.EventHandler(this.loadStudent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(19, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Student Name";
            // 
            // cmb_Stdname
            // 
            this.cmb_Stdname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Stdname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Stdname.FormattingEnabled = true;
            this.cmb_Stdname.Location = new System.Drawing.Point(153, 167);
            this.cmb_Stdname.Name = "cmb_Stdname";
            this.cmb_Stdname.Size = new System.Drawing.Size(184, 21);
            this.cmb_Stdname.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(364, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Remark";
            // 
            // cmb_Remark
            // 
            this.cmb_Remark.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Remark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Remark.FormattingEnabled = true;
            this.cmb_Remark.Location = new System.Drawing.Point(484, 225);
            this.cmb_Remark.Name = "cmb_Remark";
            this.cmb_Remark.Size = new System.Drawing.Size(223, 21);
            this.cmb_Remark.TabIndex = 33;
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
            this.SubjectMarks_Id,
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.rollNoDataGridViewTextBoxColumn,
            this.examinationTypeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn,
            this.marksObtainedDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.examinationIdDataGridViewTextBoxColumn,
            this.gradeIdDataGridViewTextBoxColumn,
            this.sectionIdDataGridViewTextBoxColumn,
            this.remarkidDataGridViewTextBoxColumn,
            this.full_Marks,
            this.pass_Marks,
            this.Edit,
            this.Delete});
            this.dgv_MO.DataSource = this.resultBindingSource4;
            this.dgv_MO.Location = new System.Drawing.Point(19, 337);
            this.dgv_MO.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_MO.MinimumSize = new System.Drawing.Size(15, 10);
            this.dgv_MO.Name = "dgv_MO";
            this.dgv_MO.ReadOnly = true;
            this.dgv_MO.RowHeadersWidth = 100;
            this.dgv_MO.Size = new System.Drawing.Size(796, 292);
            this.dgv_MO.TabIndex = 38;
            this.dgv_MO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_MO_CellContentClick);
            // 
            // resultBindingSource4
            // 
            this.resultBindingSource4.DataMember = "Result";
            this.resultBindingSource4.DataSource = this.marksobtainedResult;
            // 
            // marksobtainedResult
            // 
            this.marksobtainedResult.DataSetName = "MarksobtainedResult";
            this.marksobtainedResult.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(368, 295);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(84, 22);
            this.btn_Add.TabIndex = 39;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(19, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Subject";
            // 
            // cmb_Subject
            // 
            this.cmb_Subject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Subject.FormattingEnabled = true;
            this.cmb_Subject.Location = new System.Drawing.Point(153, 228);
            this.cmb_Subject.Name = "cmb_Subject";
            this.cmb_Subject.Size = new System.Drawing.Size(184, 21);
            this.cmb_Subject.TabIndex = 33;
            this.cmb_Subject.SelectedIndexChanged += new System.EventHandler(this.Cmb_Subject_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label7.Location = new System.Drawing.Point(19, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Obtained Marks";
            // 
            // txt_OM
            // 
            this.txt_OM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_OM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OM.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.txt_OM.Location = new System.Drawing.Point(153, 292);
            this.txt_OM.Name = "txt_OM";
            this.txt_OM.Size = new System.Drawing.Size(184, 24);
            this.txt_OM.TabIndex = 41;
            this.txt_OM.TextChanged += new System.EventHandler(this.Txt_OM_TextChanged);
            this.txt_OM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_OM_KeyDown);
            this.txt_OM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_OM_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(-2, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 39);
            this.panel2.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(316, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(223, 25);
            this.label16.TabIndex = 9;
            this.label16.Text = "Marks Obtained Entry ";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(484, 295);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(84, 22);
            this.btn_Update.TabIndex = 43;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // resultTableAdapter4
            // 
            this.resultTableAdapter4.ClearBeforeFill = true;
            // 
            // resultIdDataGridViewTextBoxColumn
            // 
            this.resultIdDataGridViewTextBoxColumn.DataPropertyName = "result_Id";
            this.resultIdDataGridViewTextBoxColumn.HeaderText = "result_Id";
            this.resultIdDataGridViewTextBoxColumn.Name = "resultIdDataGridViewTextBoxColumn";
            this.resultIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // SubjectMarks_Id
            // 
            this.SubjectMarks_Id.DataPropertyName = "SubjectMarks_Id";
            this.SubjectMarks_Id.HeaderText = "SubjectMarks_Id";
            this.SubjectMarks_Id.Name = "SubjectMarks_Id";
            this.SubjectMarks_Id.ReadOnly = true;
            this.SubjectMarks_Id.Visible = false;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "student_Id";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "attendance";
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // marksObtainedDataGridViewTextBoxColumn
            // 
            this.marksObtainedDataGridViewTextBoxColumn.DataPropertyName = "marks_Obtained";
            this.marksObtainedDataGridViewTextBoxColumn.HeaderText = "marks_Obtained";
            this.marksObtainedDataGridViewTextBoxColumn.Name = "marksObtainedDataGridViewTextBoxColumn";
            this.marksObtainedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examinationIdDataGridViewTextBoxColumn
            // 
            this.examinationIdDataGridViewTextBoxColumn.DataPropertyName = "examination_Id";
            this.examinationIdDataGridViewTextBoxColumn.HeaderText = "examination_Id";
            this.examinationIdDataGridViewTextBoxColumn.Name = "examinationIdDataGridViewTextBoxColumn";
            this.examinationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.examinationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // gradeIdDataGridViewTextBoxColumn
            // 
            this.gradeIdDataGridViewTextBoxColumn.DataPropertyName = "grade_Id";
            this.gradeIdDataGridViewTextBoxColumn.HeaderText = "grade_Id";
            this.gradeIdDataGridViewTextBoxColumn.Name = "gradeIdDataGridViewTextBoxColumn";
            this.gradeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectionIdDataGridViewTextBoxColumn
            // 
            this.sectionIdDataGridViewTextBoxColumn.DataPropertyName = "section_Id";
            this.sectionIdDataGridViewTextBoxColumn.HeaderText = "section_Id";
            this.sectionIdDataGridViewTextBoxColumn.Name = "sectionIdDataGridViewTextBoxColumn";
            this.sectionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // remarkidDataGridViewTextBoxColumn
            // 
            this.remarkidDataGridViewTextBoxColumn.DataPropertyName = "remark_id";
            this.remarkidDataGridViewTextBoxColumn.HeaderText = "remark_id";
            this.remarkidDataGridViewTextBoxColumn.Name = "remarkidDataGridViewTextBoxColumn";
            this.remarkidDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarkidDataGridViewTextBoxColumn.Visible = false;
            // 
            // full_Marks
            // 
            this.full_Marks.DataPropertyName = "full_Marks";
            this.full_Marks.HeaderText = "full_Marks";
            this.full_Marks.Name = "full_Marks";
            this.full_Marks.ReadOnly = true;
            // 
            // pass_Marks
            // 
            this.pass_Marks.DataPropertyName = "pass_Marks";
            this.pass_Marks.HeaderText = "pass_Marks";
            this.pass_Marks.Name = "pass_Marks";
            this.pass_Marks.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // MarksObtainedEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 648);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_OM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_MO);
            this.Controls.Add(this.cmb_Section);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Subject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Roll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Remark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Stdname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Grade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Exam);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MarksObtainedEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarksObtainedEntry";
            this.Load += new System.EventHandler(this.MarksObtainedEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksobtainedResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Exam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Grade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Roll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Section;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Stdname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Remark;
        private System.Windows.Forms.DataGridView dgv_MO;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Subject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_OM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Update;
        private MarksobtainedResult marksobtainedResult;
        private System.Windows.Forms.BindingSource resultBindingSource4;
        private MarksobtainedResultTableAdapters.ResultTableAdapter resultTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectMarks_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examinationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksObtainedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examinationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_Marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_Marks;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}