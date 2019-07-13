namespace MSGCP.View
{
    partial class Exam
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
            this.dgv_Exam = new System.Windows.Forms.DataGridView();
            this.examination_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examination_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Exam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exam)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Exam
            // 
            this.dgv_Exam.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examination_Id,
            this.examination_Type,
            this.Edit,
            this.Delete});
            this.dgv_Exam.Location = new System.Drawing.Point(222, 302);
            this.dgv_Exam.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_Exam.MinimumSize = new System.Drawing.Size(15, 10);
            this.dgv_Exam.Name = "dgv_Exam";
            this.dgv_Exam.RowHeadersWidth = 100;
            this.dgv_Exam.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_Exam.Size = new System.Drawing.Size(403, 292);
            this.dgv_Exam.TabIndex = 38;
            this.dgv_Exam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Exam_CellContentClick);
            // 
            // examination_Id
            // 
            this.examination_Id.DataPropertyName = "examination_Id";
            this.examination_Id.HeaderText = "Examination Id";
            this.examination_Id.Name = "examination_Id";
            this.examination_Id.Visible = false;
            // 
            // examination_Type
            // 
            this.examination_Type.DataPropertyName = "examination_Type";
            this.examination_Type.HeaderText = "Examination";
            this.examination_Type.Name = "examination_Type";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel9.Controls.Add(this.btn_Update);
            this.panel9.Controls.Add(this.btn_Add);
            this.panel9.Controls.Add(this.txt_Exam);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(159, 59);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(512, 230);
            this.panel9.TabIndex = 37;
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
            // txt_Exam
            // 
            this.txt_Exam.Location = new System.Drawing.Point(131, 96);
            this.txt_Exam.Multiline = true;
            this.txt_Exam.Name = "txt_Exam";
            this.txt_Exam.Size = new System.Drawing.Size(253, 46);
            this.txt_Exam.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(122, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "ADD EXAMINATION HERE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 652);
            this.Controls.Add(this.dgv_Exam);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Exam";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exam)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Exam;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Exam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn examination_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn examination_Type;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}