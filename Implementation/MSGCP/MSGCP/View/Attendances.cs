using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MSGCP.View
{
    public partial class Attendances : Form
    {
        DeskEntityA db = new DeskEntityA();
        Subject sub = new Subject();
        Attendance atd = new Attendance();
        public Attendances()
        {
            InitializeComponent();
        }
        private void loadStudent(object sender, EventArgs e)
        {
            List<Student> students;

            try
            {
                String classId = cmb_Grade.SelectedValue.ToString();
                String sectionId = cmb_Section.SelectedValue.ToString();
                students = (List<Student>)db.Student.Where(a => a.section == sectionId.ToString() && a.grade == classId.ToString()).ToList();
                cmb_Stdname.DataSource = students;
                cmb_Stdname.DisplayMember = "full_Name";
                cmb_Stdname.ValueMember = "student_Id";

                cmb_Roll.DataSource = students;
                cmb_Roll.DisplayMember = "roll_No";
                cmb_Roll.ValueMember = "roll_No";
            }
            catch (Exception ex)
            {
                // ignore

            }
        }
        private void Attendance_Load(object sender, EventArgs e)
        {
            this.attendanceTableAdapter1.Fill(this.attendanceData.Attendance);
            //Subject Combobox
            cmb_Subject.DataSource = db.Subject.ToList();
            cmb_Subject.DisplayMember = "subject1";
            cmb_Subject.ValueMember = "subject_Id";
            //GradeCombobx
            cmb_Grade.DataSource = db.Grade.ToList();
            cmb_Grade.ValueMember = "grade1";
            cmb_Grade.DisplayMember = "grade1";
            //Section Combobox
            cmb_Section.DataSource = db.Section.ToList();
            cmb_Section.ValueMember = "section1";
            cmb_Section.DisplayMember = "section1";
        }
        void PopulateDataGridView()
        {
            dgv_Attendance.DataSource = db.Attendance.ToList<Attendance>();
        }
        void clear()
        {
            cmb_Stdname.Text = cmb_Section.Text = cmb_Roll.Text = cmb_Subject.Text = "";
        }
            private void Btn_Save_Click(object sender, EventArgs e)
        {
            atd.student_Name = cmb_Stdname.Text.ToString();
            atd.subject_Name=cmb_Subject.Text.ToString();
            atd.section = cmb_Section.Text.ToString();
            atd.student_Name = cmb_Stdname.Text.ToString();
            atd.grade = cmb_Grade.Text.ToString();
            atd.student_Id = (int)cmb_Stdname.SelectedValue;
            atd.subject_Id = (int)cmb_Subject.SelectedValue;
            atd.status = cmb_Attendance.Text.ToString();
            db.Attendance.Add(atd);
            db.SaveChanges();
            clear();
            MessageBox.Show("Saved Sucessfully");
            PopulateDataGridView();
        }

        private void Dgv_Attendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}


