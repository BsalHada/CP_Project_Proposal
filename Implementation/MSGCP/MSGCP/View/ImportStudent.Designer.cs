namespace MSGCP.View
{
    partial class ImportStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Import = new System.Windows.Forms.Button();
            this.cmb_Import = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Imp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Import);
            this.panel1.Controls.Add(this.cmb_Import);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(252, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 56);
            this.panel1.TabIndex = 47;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(210, 14);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(121, 22);
            this.btn_Import.TabIndex = 48;
            this.btn_Import.Text = "IMPORT FROM EXCEL";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // cmb_Import
            // 
            this.cmb_Import.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Import.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Import.FormattingEnabled = true;
            this.cmb_Import.Location = new System.Drawing.Point(79, 14);
            this.cmb_Import.Name = "cmb_Import";
            this.cmb_Import.Size = new System.Drawing.Size(90, 21);
            this.cmb_Import.TabIndex = 37;
            this.cmb_Import.SelectedIndexChanged += new System.EventHandler(this.Cmb_Import_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Class";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(2, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 39);
            this.panel2.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(329, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(228, 25);
            this.label16.TabIndex = 9;
            this.label16.Text = "Import Student Details ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 148);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(783, 398);
            this.dataGridView.TabIndex = 48;
            // 
            // btn_Imp
            // 
            this.btn_Imp.Location = new System.Drawing.Point(627, 100);
            this.btn_Imp.Name = "btn_Imp";
            this.btn_Imp.Size = new System.Drawing.Size(137, 22);
            this.btn_Imp.TabIndex = 49;
            this.btn_Imp.Text = "IMPORT FROM EXCEL";
            this.btn_Imp.UseVisualStyleBackColor = true;
            this.btn_Imp.Click += new System.EventHandler(this.btn_Imp_Click);
            // 
            // ImportStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 624);
            this.Controls.Add(this.btn_Imp);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ImportStudent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportStudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_Import;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Imp;
    }
}