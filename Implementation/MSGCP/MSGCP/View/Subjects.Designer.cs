namespace MSGCP.View
{
    partial class Subjects
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
            this.dgv_Subject = new System.Windows.Forms.DataGridView();
            this.subject_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SubjectMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Subject)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Subject
            // 
            this.dgv_Subject.AllowUserToAddRows = false;
            this.dgv_Subject.AllowUserToDeleteRows = false;
            this.dgv_Subject.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Subject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_Id,
            this.subject1,
            this.Edit,
            this.Delete,
            this.SubjectMarks,
            this.Attendance});
            this.dgv_Subject.Location = new System.Drawing.Point(196, 304);
            this.dgv_Subject.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_Subject.MinimumSize = new System.Drawing.Size(15, 10);
            this.dgv_Subject.Name = "dgv_Subject";
            this.dgv_Subject.ReadOnly = true;
            this.dgv_Subject.RowHeadersWidth = 100;
            this.dgv_Subject.Size = new System.Drawing.Size(408, 292);
            this.dgv_Subject.TabIndex = 36;
            this.dgv_Subject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Subject_CellContentClick);
            // 
            // subject_Id
            // 
            this.subject_Id.DataPropertyName = "subject_Id";
            this.subject_Id.HeaderText = "subject_Id";
            this.subject_Id.Name = "subject_Id";
            this.subject_Id.ReadOnly = true;
            this.subject_Id.Visible = false;
            // 
            // subject1
            // 
            this.subject1.DataPropertyName = "subject1";
            this.subject1.HeaderText = "Subject";
            this.subject1.Name = "subject1";
            this.subject1.ReadOnly = true;
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
            // SubjectMarks
            // 
            this.SubjectMarks.DataPropertyName = "SubjectMarks";
            this.SubjectMarks.HeaderText = "SubjectMarks";
            this.SubjectMarks.Name = "SubjectMarks";
            this.SubjectMarks.ReadOnly = true;
            this.SubjectMarks.Visible = false;
            // 
            // Attendance
            // 
            this.Attendance.DataPropertyName = "attendance";
            this.Attendance.HeaderText = "Attendances";
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            this.Attendance.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel9.Controls.Add(this.btn_Update);
            this.panel9.Controls.Add(this.btn_Add);
            this.panel9.Controls.Add(this.txt_Subject);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(144, 61);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(512, 230);
            this.panel9.TabIndex = 35;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(301, 166);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(83, 37);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(131, 166);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(83, 37);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(131, 96);
            this.txt_Subject.Multiline = true;
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(253, 46);
            this.txt_Subject.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(136, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "ADD SUBJECTS HERE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 648);
            this.Controls.Add(this.dgv_Subject);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Subjects";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Subjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Subject)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Subject;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject1;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
    }
}