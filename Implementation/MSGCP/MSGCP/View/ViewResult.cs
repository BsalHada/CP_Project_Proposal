using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGCP.View
{
    public partial class ViewResult : Form
    {
        DeskEntityA db = new DeskEntityA();
        Subject sub = new Subject();
        SubjectMarks sm = new SubjectMarks();
        Result rslt = new Result();
        ResultTotal rst = new ResultTotal();
        public ViewResult()
        {
            InitializeComponent();
        }
        private void ViewResult_Load(object sender, EventArgs e)
        {
            //Class in combobox
            cmb_Grade.DataSource = db.Grade.ToList();
            cmb_Grade.ValueMember = "grade1";
            cmb_Grade.DisplayMember = "grade1";
            //Section in combobox
            cmb_Section.DataSource = db.Section.ToList();
            cmb_Section.ValueMember = "section1";
            cmb_Section.DisplayMember = "section1";
            //Examination in Combobox
            cmb_Exam.DataSource = db.Examination.ToList();
            cmb_Exam.ValueMember = "examination_Type";
            cmb_Exam.DisplayMember = "examination_Type";
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if(cmb_Exam.Text=="")
            {
                MessageBox.Show("Please select Examination Type.");
            }
            if (cmb_Grade.Text == "")
            {
                MessageBox.Show("Please select Grade.");
            }
            if (cmb_Roll.Text == "")
            {
                MessageBox.Show("Please select RollNo.");
            }
            if (cmb_Section.Text == "")
            {
                MessageBox.Show("Please select Section.");
            }
            if (cmb_Stdname.Text == "")
            {
                MessageBox.Show("Please select Student Name.");
            }
            List<Result> results;
            try
            {
                String exam = cmb_Exam.SelectedValue.ToString();
                String studentName = cmb_Stdname.SelectedValue.ToString();
                results = (List<Result>)db.Result.Where(a => a.student_Name == studentName.ToString() && a.examination_Type == exam.ToString()).ToList();
                dgv_MO.DataSource = results;
                DataGridTotal();

            }
            catch (Exception ex)
            {
                // ignore

            }
        }
        private void DataGridTotal()
        {
            int sum = 0; int sum_fmarks = 0;
            int sumpass = 0;
            decimal per = 0;
            for (int i = 0; i < dgv_MO.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgv_MO.Rows[i].Cells[10].Value);
                sum_fmarks += Convert.ToInt32(dgv_MO.Rows[i].Cells[8].Value);
                sumpass += Convert.ToInt32(dgv_MO.Rows[i].Cells[9].Value);
            }
            per = 100 / sum_fmarks;
            MessageBox.Show(per.ToString());
            this.lbl_Total.Text = sum.ToString();
            rst.student_name = cmb_Stdname.Text.Trim();
            rst.grade = cmb_Grade.Text.Trim();
            rst.section = cmb_Section.Text.Trim();
            rst.roll_No = cmb_Roll.Text.Trim();
            rst.examination_Type = cmb_Exam.Text.Trim();
            rst.full_total = sum_fmarks;
            rst.pass_Total = sumpass;
            rst.obtained_Total = sum;
            db.ResultTotal.Add(rst);
            db.SaveChanges();
            this.lbl_Percentage.Text = per.ToString();
            if (sum<=sumpass)
            {
                this.lbl_status.Text = "Failed!!";
            }
            else
            {
                this.lbl_status.Text = "Passed!";
            }
        }
        private void loadStudent(object sender, EventArgs e)
        {
            List<Student> students;

            try
            {
                String classId = cmb_Grade.SelectedValue.ToString();
                String sectionId = cmb_Section.SelectedValue.ToString();
                students = (List<Student>) db.Student.Where(a => a.section == sectionId.ToString() && a.grade == classId.ToString()).ToList();
                cmb_Stdname.DataSource = students;
                cmb_Stdname.DisplayMember = "full_Name";
                cmb_Stdname.ValueMember = "full_Name";

                cmb_Roll.DataSource = students;
                cmb_Roll.ValueMember = "roll_No";
                cmb_Roll.DisplayMember = "roll_No";
            }
            catch (Exception ex)
            {
                // ignore
                
            }
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Cmb_Roll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form = new Dashboard();
            form.ShowDialog();
            this.Close();
        }
    }
}
