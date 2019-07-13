namespace MSGCP.View
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Load = new System.Windows.Forms.Button();
            this.resultTotal_Chart = new MSGCP.ResultTotal_Chart();
            this.resultTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultTotalTableAdapter = new MSGCP.ResultTotal_ChartTableAdapters.ResultTotalTableAdapter();
            this.cmb_Section = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Roll = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Stdname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Grade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTotal_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTotalBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartProgress
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProgress.ChartAreas.Add(chartArea1);
            this.chartProgress.DataSource = this.resultTotalBindingSource;
            legend1.Name = "Legend1";
            this.chartProgress.Legends.Add(legend1);
            this.chartProgress.Location = new System.Drawing.Point(185, 261);
            this.chartProgress.Name = "chartProgress";
            this.chartProgress.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Progress";
            this.chartProgress.Series.Add(series1);
            this.chartProgress.Size = new System.Drawing.Size(443, 342);
            this.chartProgress.TabIndex = 0;
            this.chartProgress.Text = "chart1";
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            title1.Name = "Progress Report ";
            title1.Text = "Progress Report";
            this.chartProgress.Titles.Add(title1);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(404, 162);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(83, 21);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "LOAD";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // resultTotal_Chart
            // 
            this.resultTotal_Chart.DataSetName = "ResultTotal_Chart";
            this.resultTotal_Chart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultTotalBindingSource
            // 
            this.resultTotalBindingSource.DataMember = "ResultTotal";
            this.resultTotalBindingSource.DataSource = this.resultTotal_Chart;
            // 
            // resultTotalTableAdapter
            // 
            this.resultTotalTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_Section
            // 
            this.cmb_Section.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Section.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Section.FormattingEnabled = true;
            this.cmb_Section.Location = new System.Drawing.Point(505, 110);
            this.cmb_Section.Name = "cmb_Section";
            this.cmb_Section.Size = new System.Drawing.Size(81, 21);
            this.cmb_Section.TabIndex = 53;
            this.cmb_Section.SelectedIndexChanged += new System.EventHandler(this.loadStudent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(400, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Section";
            // 
            // cmb_Roll
            // 
            this.cmb_Roll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Roll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Roll.FormattingEnabled = true;
            this.cmb_Roll.Location = new System.Drawing.Point(713, 108);
            this.cmb_Roll.Name = "cmb_Roll";
            this.cmb_Roll.Size = new System.Drawing.Size(83, 21);
            this.cmb_Roll.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(642, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Roll No";
            // 
            // cmb_Stdname
            // 
            this.cmb_Stdname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Stdname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Stdname.FormattingEnabled = true;
            this.cmb_Stdname.Location = new System.Drawing.Point(135, 162);
            this.cmb_Stdname.Name = "cmb_Stdname";
            this.cmb_Stdname.Size = new System.Drawing.Size(184, 21);
            this.cmb_Stdname.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(21, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Student Name";
            // 
            // cmb_Grade
            // 
            this.cmb_Grade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Grade.FormattingEnabled = true;
            this.cmb_Grade.Location = new System.Drawing.Point(135, 111);
            this.cmb_Grade.Name = "cmb_Grade";
            this.cmb_Grade.Size = new System.Drawing.Size(184, 21);
            this.cmb_Grade.TabIndex = 56;
            this.cmb_Grade.SelectedIndexChanged += new System.EventHandler(this.loadStudent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Class";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 39);
            this.panel2.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(352, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 25);
            this.label16.TabIndex = 9;
            this.label16.Text = "Progress Chart";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmb_Section);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Roll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Stdname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Grade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.chartProgress);
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTotal_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTotalBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgress;
        private System.Windows.Forms.Button btn_Load;
        private ResultTotal_Chart resultTotal_Chart;
        private System.Windows.Forms.BindingSource resultTotalBindingSource;
        private ResultTotal_ChartTableAdapters.ResultTotalTableAdapter resultTotalTableAdapter;
        private System.Windows.Forms.ComboBox cmb_Section;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Roll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Stdname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
    }
}