namespace MSGCP.View
{
    partial class fmentry
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
            this.txt_Fullmarks = new System.Windows.Forms.TextBox();
            this.cmb_Subject = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Passmarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Fpm = new System.Windows.Forms.DataGridView();
            this.subjectmarksIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullmarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passmarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.subjectMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityMSGCPDataSet4 = new MSGCP.EntityMSGCPDataSet4();
            this.subjectMarksTableAdapter = new MSGCP.EntityMSGCPDataSet4TableAdapters.SubjectMarksTableAdapter();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fpm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityMSGCPDataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Fullmarks
            // 
            this.txt_Fullmarks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Fullmarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Fullmarks.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fullmarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.txt_Fullmarks.Location = new System.Drawing.Point(123, 178);
            this.txt_Fullmarks.Name = "txt_Fullmarks";
            this.txt_Fullmarks.Size = new System.Drawing.Size(184, 24);
            this.txt_Fullmarks.TabIndex = 30;
            // 
            // cmb_Subject
            // 
            this.cmb_Subject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Subject.FormattingEnabled = true;
            this.cmb_Subject.Location = new System.Drawing.Point(123, 127);
            this.cmb_Subject.Name = "cmb_Subject";
            this.cmb_Subject.Size = new System.Drawing.Size(184, 21);
            this.cmb_Subject.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label9.Location = new System.Drawing.Point(22, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(22, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Full Marks";
            // 
            // txt_Passmarks
            // 
            this.txt_Passmarks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Passmarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Passmarks.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Passmarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.txt_Passmarks.Location = new System.Drawing.Point(620, 178);
            this.txt_Passmarks.Name = "txt_Passmarks";
            this.txt_Passmarks.Size = new System.Drawing.Size(184, 24);
            this.txt_Passmarks.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(517, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Pass Marks";
            // 
            // dgv_Fpm
            // 
            this.dgv_Fpm.AllowUserToAddRows = false;
            this.dgv_Fpm.AllowUserToDeleteRows = false;
            this.dgv_Fpm.AutoGenerateColumns = false;
            this.dgv_Fpm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Fpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fpm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectmarksIdDataGridViewTextBoxColumn,
            this.subjectIdDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.fullmarksDataGridViewTextBoxColumn,
            this.passmarksDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dgv_Fpm.DataSource = this.subjectMarksBindingSource;
            this.dgv_Fpm.Location = new System.Drawing.Point(15, 280);
            this.dgv_Fpm.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_Fpm.MinimumSize = new System.Drawing.Size(15, 10);
            this.dgv_Fpm.Name = "dgv_Fpm";
            this.dgv_Fpm.ReadOnly = true;
            this.dgv_Fpm.RowHeadersWidth = 100;
            this.dgv_Fpm.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_Fpm.Size = new System.Drawing.Size(796, 292);
            this.dgv_Fpm.TabIndex = 37;
            this.dgv_Fpm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Fpm_CellContentClick);
            // 
            // subjectmarksIdDataGridViewTextBoxColumn
            // 
            this.subjectmarksIdDataGridViewTextBoxColumn.DataPropertyName = "subjectmarks_Id";
            this.subjectmarksIdDataGridViewTextBoxColumn.HeaderText = "subjectmarks_Id";
            this.subjectmarksIdDataGridViewTextBoxColumn.Name = "subjectmarksIdDataGridViewTextBoxColumn";
            this.subjectmarksIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "subject_Id";
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "subject_Id";
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            this.subjectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullmarksDataGridViewTextBoxColumn
            // 
            this.fullmarksDataGridViewTextBoxColumn.DataPropertyName = "fullmarks";
            this.fullmarksDataGridViewTextBoxColumn.HeaderText = "fullmarks";
            this.fullmarksDataGridViewTextBoxColumn.Name = "fullmarksDataGridViewTextBoxColumn";
            this.fullmarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passmarksDataGridViewTextBoxColumn
            // 
            this.passmarksDataGridViewTextBoxColumn.DataPropertyName = "passmarks";
            this.passmarksDataGridViewTextBoxColumn.HeaderText = "passmarks";
            this.passmarksDataGridViewTextBoxColumn.Name = "passmarksDataGridViewTextBoxColumn";
            this.passmarksDataGridViewTextBoxColumn.ReadOnly = true;
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
            // subjectMarksBindingSource
            // 
            this.subjectMarksBindingSource.DataMember = "SubjectMarks";
            this.subjectMarksBindingSource.DataSource = this.entityMSGCPDataSet4;
            // 
            // entityMSGCPDataSet4
            // 
            this.entityMSGCPDataSet4.DataSetName = "EntityMSGCPDataSet4";
            this.entityMSGCPDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectMarksTableAdapter
            // 
            this.subjectMarksTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(26, 230);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(83, 37);
            this.btn_Add.TabIndex = 38;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(1, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 39);
            this.panel2.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(316, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(219, 50);
            this.label16.TabIndex = 9;
            this.label16.Text = "Full Pass Marks Entry\r\n ";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(721, 230);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(83, 37);
            this.btn_Update.TabIndex = 44;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // fmentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 652);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Fpm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Passmarks);
            this.Controls.Add(this.txt_Fullmarks);
            this.Controls.Add(this.cmb_Subject);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fmentry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmentry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fmentry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fpm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityMSGCPDataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Fullmarks;
        private System.Windows.Forms.ComboBox cmb_Subject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Passmarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Fpm;
        private EntityMSGCPDataSet4 entityMSGCPDataSet4;
        private System.Windows.Forms.BindingSource subjectMarksBindingSource;
        private EntityMSGCPDataSet4TableAdapters.SubjectMarksTableAdapter subjectMarksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectmarksIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullmarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passmarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Update;
    }
}