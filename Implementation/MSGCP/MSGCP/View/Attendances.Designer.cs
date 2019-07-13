namespace MSGCP.View
{
    partial class Attendances
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Grade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Section = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Attendance = new System.Windows.Forms.DataGridView();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceDataSet = new MSGCP.AttendanceDataSet();
            this.cmb_Attendance = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_Stdname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Roll = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.attendanceTableAdapter = new MSGCP.AttendanceDataSetTableAdapters.AttendanceTableAdapter();
            this.attendanceData = new MSGCP.AttendanceData();
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter1 = new MSGCP.AttendanceDataTableAdapters.AttendanceTableAdapter();
            this.attendanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 39);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(364, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Attendance\r\n";
            // 
            // cmb_Grade
            // 
            this.cmb_Grade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Grade.FormattingEnabled = true;
            this.cmb_Grade.Location = new System.Drawing.Point(153, 118);
            this.cmb_Grade.Name = "cmb_Grade";
            this.cmb_Grade.Size = new System.Drawing.Size(116, 21);
            this.cmb_Grade.TabIndex = 35;
            this.cmb_Grade.SelectedIndexChanged += new System.EventHandler(this.loadStudent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(19, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Grade:";
            // 
            // cmb_Section
            // 
            this.cmb_Section.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Section.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Section.FormattingEnabled = true;
            this.cmb_Section.Location = new System.Drawing.Point(153, 144);
            this.cmb_Section.Name = "cmb_Section";
            this.cmb_Section.Size = new System.Drawing.Size(116, 21);
            this.cmb_Section.TabIndex = 37;
            this.cmb_Section.SelectedIndexChanged += new System.EventHandler(this.loadStudent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(19, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Section:";
            // 
            // cmb_Subject
            // 
            this.cmb_Subject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Subject.FormattingEnabled = true;
            this.cmb_Subject.Location = new System.Drawing.Point(633, 169);
            this.cmb_Subject.Name = "cmb_Subject";
            this.cmb_Subject.Size = new System.Drawing.Size(142, 21);
            this.cmb_Subject.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(554, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Subject:";
            // 
            // dgv_Attendance
            // 
            this.dgv_Attendance.AllowUserToAddRows = false;
            this.dgv_Attendance.AllowUserToDeleteRows = false;
            this.dgv_Attendance.AutoGenerateColumns = false;
            this.dgv_Attendance.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.subjectIdDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgv_Attendance.DataSource = this.attendanceBindingSource1;
            this.dgv_Attendance.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Attendance.Location = new System.Drawing.Point(73, 267);
            this.dgv_Attendance.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_Attendance.MinimumSize = new System.Drawing.Size(15, 10);
            this.dgv_Attendance.Name = "dgv_Attendance";
            this.dgv_Attendance.ReadOnly = true;
            this.dgv_Attendance.RowHeadersWidth = 100;
            this.dgv_Attendance.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_Attendance.Size = new System.Drawing.Size(702, 292);
            this.dgv_Attendance.TabIndex = 40;
            this.dgv_Attendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Attendance_CellContentClick);
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.attendanceDataSet;
            // 
            // attendanceDataSet
            // 
            this.attendanceDataSet.DataSetName = "AttendanceDataSet";
            this.attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_Attendance
            // 
            this.cmb_Attendance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Attendance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Attendance.FormattingEnabled = true;
            this.cmb_Attendance.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.cmb_Attendance.Location = new System.Drawing.Point(132, 10);
            this.cmb_Attendance.Name = "cmb_Attendance";
            this.cmb_Attendance.Size = new System.Drawing.Size(116, 21);
            this.cmb_Attendance.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(24, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Attendance:";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(265, 8);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 25);
            this.btn_Save.TabIndex = 43;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel3.Controls.Add(this.cmb_Attendance);
            this.panel3.Controls.Add(this.btn_Save);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(257, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 41);
            this.panel3.TabIndex = 35;
            // 
            // cmb_Stdname
            // 
            this.cmb_Stdname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Stdname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Stdname.FormattingEnabled = true;
            this.cmb_Stdname.Location = new System.Drawing.Point(153, 169);
            this.cmb_Stdname.Name = "cmb_Stdname";
            this.cmb_Stdname.Size = new System.Drawing.Size(217, 21);
            this.cmb_Stdname.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(19, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Student Name";
            // 
            // cmb_Roll
            // 
            this.cmb_Roll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Roll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Roll.FormattingEnabled = true;
            this.cmb_Roll.Location = new System.Drawing.Point(633, 142);
            this.cmb_Roll.Name = "cmb_Roll";
            this.cmb_Roll.Size = new System.Drawing.Size(86, 21);
            this.cmb_Roll.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label7.Location = new System.Drawing.Point(556, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Roll No";
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceData
            // 
            this.attendanceData.DataSetName = "AttendanceData";
            this.attendanceData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataMember = "Attendance";
            this.attendanceBindingSource1.DataSource = this.attendanceData;
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // attendanceIdDataGridViewTextBoxColumn
            // 
            this.attendanceIdDataGridViewTextBoxColumn.DataPropertyName = "attendance_Id";
            this.attendanceIdDataGridViewTextBoxColumn.HeaderText = "attendance_Id";
            this.attendanceIdDataGridViewTextBoxColumn.Name = "attendanceIdDataGridViewTextBoxColumn";
            this.attendanceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student Id";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "subject_Id";
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "Subject Id";
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            this.subjectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "subject_Name";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "Subject Name";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Attendances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 652);
            this.Controls.Add(this.cmb_Roll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Stdname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Attendance);
            this.Controls.Add(this.cmb_Subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Section);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Grade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Attendances";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_Grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Section;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Attendance;
        private System.Windows.Forms.ComboBox cmb_Attendance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_Stdname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Roll;
        private System.Windows.Forms.Label label7;
        private AttendanceDataSet attendanceDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private AttendanceDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private AttendanceData attendanceData;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private AttendanceDataTableAdapters.AttendanceTableAdapter attendanceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}