using System;
using System.Linq;
using System.Windows.Forms;

namespace MSGCP.View
{
    public partial class Exam : Form
    {
        Examination exams = new Examination();
        DeskEntityA db = new DeskEntityA();
        int id;
        public Exam()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_Exam.Text = "";
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Exam.Text == "")
            {
                MessageBox.Show("Please enter Examination Title");
                txt_Exam.Focus();
                return;
            }
            exams.examination_Type = txt_Exam.Text.Trim();
            //SQL Execution
            db.Examination.Add(exams);
            db.SaveChanges();
            clear();
            MessageBox.Show("Saved Sucessfully");
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
            dgv_Exam.DataSource = db.Examination.ToList<Examination>();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void Dgv_Exam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var command = dgv_Exam.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            id = Convert.ToInt32(dgv_Exam.Rows[e.RowIndex].Cells["examination_Id"].Value);
            if (command.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var exm = db.Examination.Find(id);
                    db.Examination.Remove(exm);
                    db.SaveChanges();
                    MessageBox.Show("Examination SUCCESSFULLY DELETED");
                    PopulateDataGridView();
                }
                else if (confirmResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (command.ToString() == "Edit")
            {
                var exm = db.Examination.Find(id);
                txt_Exam.Text = exm.examination_Type.ToString();

            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            using (var context = new DeskEntityA())
            {
                var commandText = "UPDATE Examination SET examination_Type='"
                   + txt_Exam.Text.ToString() + "' where  examination_Id='" + id.ToString() + "'";
                //var name = new SqlParameter("@CategoryName", "Test");
                context.Database.ExecuteSqlCommand(commandText);
            }
            clear();
            MessageBox.Show("Updated Sucessfully");
            PopulateDataGridView();
        }
    }
    
}
