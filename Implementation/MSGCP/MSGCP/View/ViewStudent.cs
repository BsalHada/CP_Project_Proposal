using IdentityModel.Client;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MSGCP.View
{
    public partial class Export : Form
    {
        DeskEntityA db = new DeskEntityA();
        Student std = new Student();
        public Export()
        {
            InitializeComponent();
        }
        struct DataParameter
        {
            public List<Student> StudentList;
            public string FileName { get; set; }
        }
        DataParameter _inputParameter;
        private void loadstudent(object sender, EventArgs e)
        {
            List<Student> students;
            try
            {
                String classId = cmb_Grade.SelectedValue.ToString();
                String sectionId = cmb_Section.SelectedValue.ToString();
                students = (List<Student>)db.Student.Where(a => a.section == sectionId.ToString() && a.grade == classId.ToString()).ToList();
                dgv_Student.DataSource = students;
            }
            catch (Exception ex)
            {
                // ignore

            }
        }
        private void ViewStudent_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter1.Fill(this.students.Student);
            cmb_Grade.DataSource = db.Grade.ToList();
            cmb_Grade.ValueMember = "grade1";
            cmb_Grade.DisplayMember = "grade1";

            cmb_Section.DataSource = db.Section.ToList();
            cmb_Section.ValueMember = "section1";
            cmb_Section.DisplayMember = "section1";
        }
        private void Dgv_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Student> list = ((DataParameter)e.Argument).StudentList;
            string fileName = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = list.Count;
            ws.Cells[1, 1] = "Student ID";
            ws.Cells[1, 2] = "Student Name";
            ws.Cells[1, 3] = "Grade";
            ws.Cells[1, 4] = "Section";
            ws.Cells[1, 5] = "Roll No";
            ws.Cells[1, 6] = "Address";
            ws.Cells[1, 7] = "DOB";
            ws.Cells[1, 8] = "Parents Name";
            ws.Cells[1, 9] = "Parents Phone";
            foreach (Student s in list)
            {
                if (!backgroundWorker.CancellationPending)
                {
                    backgroundWorker.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = s.student_Id.ToString();
                    ws.Cells[index, 2] = s.full_Name;
                    ws.Cells[index, 3] = s.grade;
                    ws.Cells[index, 4] = s.section;
                    ws.Cells[index, 5] = s.roll_No;
                    ws.Cells[index, 6] = s.address;
                    ws.Cells[index, 7] = s.DOB;
                    ws.Cells[index, 8] = s.parents_Name;
                    ws.Cells[index, 9] = s.parent_Phone;
                }
            }
            //Save file 
            ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            //excel.Quit();
            excel.Quit(); 
        }
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lbl_Status.Text = string.Format("Processing....{0}", e.ProgressPercentage);
            progressBar.Update();
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error == null)
            {
                Thread.Sleep(100);
                lbl_Status.Text = "Your data has been successfully exported.";

            }
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xls"

            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.FileName = sfd.FileName;
                    _inputParameter.StudentList = dgv_Student.DataSource as List<Student>;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputParameter);
                }
            }
        }
    }
}
