namespace MSGCP.View
{
    partial class Sections
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
            this.dgv_Section = new System.Windows.Forms.DataGridView();
            this.section_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.grade_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Section = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Section)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Section
            // 
            this.dgv_Section.AllowUserToAddRows = false;
            this.dgv_Section.AllowUserToDeleteRows = false;
            this.dgv_Section.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Section.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.section_Id,
            this.section1,
            this.Edit,
            this.Delete,
            this.grade_Id,
            this.Grade1,
            this.grade,
            this.Result});
            this.dgv_Section.Location = new System.Drawing.Point(207, 304);
            this.dgv_Section.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_Section.MinimumSize = new System.Drawing.Size(15, 10);
            this.dgv_Section.Name = "dgv_Section";
            this.dgv_Section.ReadOnly = true;
            this.dgv_Section.RowHeadersWidth = 100;
            this.dgv_Section.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_Section.Size = new System.Drawing.Size(403, 292);
            this.dgv_Section.TabIndex = 36;
            this.dgv_Section.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Section_CellContentClick);
            // 
            // section_Id
            // 
            this.section_Id.DataPropertyName = "section_Id";
            this.section_Id.HeaderText = "Section Id";
            this.section_Id.Name = "section_Id";
            this.section_Id.ReadOnly = true;
            this.section_Id.Visible = false;
            // 
            // section1
            // 
            this.section1.DataPropertyName = "section1";
            this.section1.HeaderText = "Section";
            this.section1.Name = "section1";
            this.section1.ReadOnly = true;
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
            // grade_Id
            // 
            this.grade_Id.DataPropertyName = "grade_Id";
            this.grade_Id.HeaderText = "grade_Id";
            this.grade_Id.Name = "grade_Id";
            this.grade_Id.ReadOnly = true;
            this.grade_Id.Visible = false;
            // 
            // Grade1
            // 
            this.Grade1.DataPropertyName = "Grade1";
            this.Grade1.HeaderText = "Grade1";
            this.Grade1.Name = "Grade1";
            this.Grade1.ReadOnly = true;
            this.Grade1.Visible = false;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "grade";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            this.grade.Visible = false;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "result";
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel9.Controls.Add(this.btn_Update);
            this.panel9.Controls.Add(this.btn_Add);
            this.panel9.Controls.Add(this.txt_Section);
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
            // txt_Section
            // 
            this.txt_Section.Location = new System.Drawing.Point(131, 96);
            this.txt_Section.Multiline = true;
            this.txt_Section.Name = "txt_Section";
            this.txt_Section.Size = new System.Drawing.Size(253, 46);
            this.txt_Section.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(150, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "ADD SECTION HERE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 648);
            this.Controls.Add(this.dgv_Section);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Sections";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Section";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sections_FormClosed);
            this.Load += new System.EventHandler(this.Sections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Section)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Section;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Section;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn section_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn section1;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}