namespace MSGCP.View
{
    partial class Class
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
            this.dgv_Grade = new System.Windows.Forms.DataGridView();
            this.grade_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Grade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grade)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Grade
            // 
            this.dgv_Grade.AllowUserToAddRows = false;
            this.dgv_Grade.AllowUserToDeleteRows = false;
            this.dgv_Grade.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Grade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grade_Id,
            this.grade1,
            this.Edit,
            this.Delete,
            this.Section});
            this.dgv_Grade.Location = new System.Drawing.Point(204, 304);
            this.dgv_Grade.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_Grade.MinimumSize = new System.Drawing.Size(15, 10);
            this.dgv_Grade.Name = "dgv_Grade";
            this.dgv_Grade.ReadOnly = true;
            this.dgv_Grade.RowHeadersWidth = 100;
            this.dgv_Grade.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_Grade.Size = new System.Drawing.Size(403, 292);
            this.dgv_Grade.TabIndex = 36;
            this.dgv_Grade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Grade_CellContentClick);
            // 
            // grade_Id
            // 
            this.grade_Id.DataPropertyName = "grade_Id";
            this.grade_Id.HeaderText = "GradeId";
            this.grade_Id.Name = "grade_Id";
            this.grade_Id.ReadOnly = true;
            this.grade_Id.Visible = false;
            // 
            // grade1
            // 
            this.grade1.DataPropertyName = "grade1";
            this.grade1.HeaderText = "Grade";
            this.grade1.Name = "grade1";
            this.grade1.ReadOnly = true;
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
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel9.Controls.Add(this.btn_Update);
            this.panel9.Controls.Add(this.btn_Add);
            this.panel9.Controls.Add(this.txt_Grade);
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
            // txt_Grade
            // 
            this.txt_Grade.Location = new System.Drawing.Point(131, 96);
            this.txt_Grade.Multiline = true;
            this.txt_Grade.Name = "txt_Grade";
            this.txt_Grade.Size = new System.Drawing.Size(253, 46);
            this.txt_Grade.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "ADD GRADE HERE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 648);
            this.Controls.Add(this.dgv_Grade);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Class";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grade)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Grade;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade1;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
    }
}