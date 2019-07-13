using System;
using System.Linq;
using System.Windows.Forms;

namespace MSGCP.View
{
    public partial class Subjects : Form
    {
        DeskEntityA db = new DeskEntityA();
        Subject sub = new Subject();
        int id;
        public Subjects()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_Subject.Text = "";
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Subject.Text == "")
            {
                MessageBox.Show("Please enter Examination Title");
                txt_Subject.Focus();
                return;
            }
            sub.subject1 = txt_Subject.Text.Trim();
            //SQL Execution
            db.Subject.Add(sub);
            db.SaveChanges();
            clear();
            MessageBox.Show("Saved Sucessfully");
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
            dgv_Subject.DataSource = db.Subject.ToList<Subject>();
        }
        private void Subjects_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        private void Dgv_Subject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var command = dgv_Subject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            id = Convert.ToInt32(dgv_Subject.Rows[e.RowIndex].Cells["subject_Id"].Value);
            if (command.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var subs = db.Subject.Find(id);
                    db.Subject.Remove(subs);
                    db.SaveChanges();
                    MessageBox.Show("SUBJECT SUCCESSFULLY DELETED");
                    PopulateDataGridView();
                }
                else if (confirmResult == DialogResult.No)
                {
                    return;
                }
            }
                else if (command.ToString() == "Edit")
            {
                var subs = db.Subject.Find(id);
                txt_Subject.Text = subs.subject1.ToString();
            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            using (var context = new DeskEntityA())
            {
                var commandText = "UPDATE Subject SET subject='"+ txt_Subject.Text.ToString() + "'where  subject_Id='" + id.ToString() + "'";
                context.Database.ExecuteSqlCommand(commandText);
                PopulateDataGridView();
            }
            clear();
            MessageBox.Show("Updated Sucessfully");
            PopulateDataGridView();
        }
    }
}
    

