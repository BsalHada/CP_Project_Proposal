using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;

namespace MSGCP.View
{
    public partial class MarksObtainedEntry : Form
    {
        DeskEntityA db = new DeskEntityA();
        Subject sub = new Subject();
        SubjectMarks sm = new SubjectMarks();
        Grade gd = new Grade();
        Result rslt = new Result();
        Examination exm = new Examination();

        string command;
        int id;
        public MarksObtainedEntry()
        {
            InitializeComponent();
        }
        void clear()
        {
            cmb_Subject.Text=txt_OM.Text=cmb_Exam.Text=cmb_Grade.Text = cmb_Roll.Text = cmb_Section.Text = cmb_Stdname.Text=cmb_Remark.Text= "";
        }
        void PopulateDataGridView()
        {
            dgv_MO.DataSource = db.Result.ToList<Result>();
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void MarksObtainedEntry_Load(object sender, EventArgs e)
        {
            this.resultTableAdapter4.Fill(this.marksobtainedResult.Result);
            btn_Update.Enabled = false;
            try
            {
                //Init data
                db.Configuration.ProxyCreationEnabled = false;
                cmb_Exam.DataSource = db.Examination.ToList();
                cmb_Exam.ValueMember = "examination_Id";
                cmb_Exam.DisplayMember = "examination_Type";

                cmb_Grade.DataSource = db.Grade.ToList();
                cmb_Grade.ValueMember = "grade1";
                cmb_Grade.DisplayMember = "grade1";

                cmb_Section.DataSource = db.Section.ToList();
                cmb_Section.ValueMember = "section1";
                cmb_Section.DisplayMember = "section1";

               
                cmb_Stdname.DataSource = db.Student.ToList();
                cmb_Stdname.ValueMember = "student_Id";
                cmb_Stdname.DisplayMember = "full_Name";

                cmb_Subject.DataSource = db.Subject.ToList();
                cmb_Subject.DisplayMember = "subject1";
                cmb_Subject.ValueMember = "subject_Id";

                cmb_Remark.DataSource = db.Remark.ToList();
                cmb_Remark.ValueMember = "remark_Id";
                cmb_Remark.DisplayMember = "remark";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
                rslt.marks_Obtained = Convert.ToInt32(txt_OM.Text.Trim());
                rslt.remark = cmb_Remark.Text;
                rslt.grade = cmb_Grade.Text;
                rslt.section = cmb_Section.Text;
                rslt.student_Name = cmb_Stdname.Text;
                rslt.examination_Type = cmb_Exam.Text;
                rslt.subject = cmb_Subject.Text;
                rslt.examination_Id = Convert.ToInt32( cmb_Exam.SelectedValue);
                rslt.student_Id =(int)cmb_Stdname.SelectedValue;
                rslt.roll_No = Convert.ToInt32(cmb_Roll.SelectedValue);
                rslt.full_Marks = db.SubjectMarks.Where(s => s.subject.Equals(cmb_Subject.Text)).Single().fullmarks;
                rslt.pass_Marks = db.SubjectMarks.Where(s => s.subject.Equals(cmb_Subject.Text)).Single().passmarks;
                db.Result.Add(rslt);
                db.SaveChanges();
                clear();
                MessageBox.Show("Saved Sucessfully");
                PopulateDataGridView();
        }
        public void Dgv_MO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            command = dgv_MO.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            id = Convert.ToInt32(dgv_MO.Rows[e.RowIndex].Cells["resultIdDataGridViewTextBoxColumn"].Value);
            if (command.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var reslt = db.Result.Find(id);
                    db.Result.Remove(reslt);
                    db.SaveChanges();
                    MessageBox.Show("Marks Obtained SUCCESSFULLY DELETED");
                    PopulateDataGridView();
                }
                else if (confirmResult == DialogResult.No)
                {
                    return;
                }
               
            }
            else if (command.ToString() == "Edit")
            {
                var reslt = db.Result.Find(id);
                txt_OM.Text = reslt.marks_Obtained.ToString();
                cmb_Stdname.Text = reslt.student_Name.ToString();
                cmb_Grade.Text = reslt.grade.ToString();
                cmb_Roll.Text = reslt.roll_No.ToString();
                cmb_Section.Text = reslt.section.ToString();
                cmb_Exam.Text = reslt.examination_Type.ToString();
                cmb_Remark.Text = reslt.remark.ToString();
                cmb_Subject.Text = reslt.subject.ToString();
                btn_Update.Enabled = true;
            }
        }
        private void Txt_OM_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void Txt_OM_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void Txt_OM_TextChanged(object sender, EventArgs e)
        {
            var obtainedMarksInput = txt_OM.Text.Trim();
            try
            {
                long obtainedMarkNum = Convert.ToInt64(obtainedMarksInput);
                if (obtainedMarkNum < 0)
                {
                    MessageBox.Show("Obtained marks should be positive");
                    return;
                } else if (obtainedMarkNum > 100)
                {
                    MessageBox.Show("Obtained marks should be less than full marks");
                    return;
                }
            } catch (Exception ex)
            {
                    MessageBox.Show("Obtained marks should be number only"); 
                    return;
            }
        }
        private void loadSubject(long subjectId)
        {
            this.sm = (SubjectMarks) db.SubjectMarks.Where(sm => sm.subject_Id == subjectId);
        }
        private void Cmb_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                long subjectId = Convert.ToInt64((cmb_Subject.SelectedValue));
                loadSubject(subjectId);
            } catch (Exception ex)
            {
                // do nothing
            }
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
        private void update(int resultId)
        {
            Result rslt = db.Result.Find(resultId);
            cmb_Stdname.Text= rslt.student_Name;
            cmb_Section.Text= rslt.section;
            cmb_Grade.Text = rslt.grade;
            cmb_Roll.Text= rslt.roll_No.ToString();
            cmb_Exam.Text = rslt.examination_Type;
            cmb_Subject.Text= rslt.subject;
            cmb_Remark.Text= rslt.remark;
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            using (var context = new DeskEntityA())
            {
                var commandText = "UPDATE Result SET examination_Type='"
                   + cmb_Exam.Text.ToString() + "',subject='" + cmb_Subject.Text.ToString() 
                    + "',marks_Obtained='"+txt_OM.Text.ToString()
                    +"' where  result_Id='" +id.ToString() + "'";
                context.Database.ExecuteSqlCommand(commandText);
            }
            clear();
            MessageBox.Show("Updated Sucessfully");
            PopulateDataGridView();
        }
    }
}
