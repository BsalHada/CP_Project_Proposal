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
    public partial class fmentry : Form
    {
        DeskEntityA db = new DeskEntityA();
        Subject sub = new Subject();
        SubjectMarks sm = new SubjectMarks();
        int id;
        public fmentry()
        {
            InitializeComponent();
        }
        void clear()
        {
            cmb_Subject.Text = txt_Fullmarks.Text = txt_Passmarks.Text = "";
        }

        void PopulateDataGridView()
        {
            dgv_Fpm.DataSource = db.SubjectMarks.ToList<SubjectMarks>();
        }
        private void Fmentry_Load(object sender, EventArgs e)
        {
            this.subjectMarksTableAdapter.Fill(this.entityMSGCPDataSet4.SubjectMarks);
            try
            {
                //Init data
                db.Configuration.ProxyCreationEnabled = false;
                cmb_Subject.DataSource = db.Subject.ToList();
                cmb_Subject.ValueMember = "subject_Id";
                cmb_Subject.DisplayMember = "subject1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            sm.Subject1 = db.Subject.Find(Convert.ToInt32(cmb_Subject.SelectedValue));
            sm.fullmarks = Convert.ToInt32(txt_Fullmarks.Text.Trim());
            sm.passmarks = Convert.ToInt32(txt_Passmarks.Text.Trim());
            sm.subject = cmb_Subject.Text;
            db.SubjectMarks.Add(sm);
            db.SaveChanges();
            clear();
            MessageBox.Show("Saved Sucessfully");
            PopulateDataGridView();
        }

        private void Dgv_Fpm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var command = dgv_Fpm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            id = Convert.ToInt32(dgv_Fpm.Rows[e.RowIndex].Cells["subjectmarksIdDataGridViewTextBoxColumn"].Value);
            if (command.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var fpmark = db.SubjectMarks.Find(id);
                    db.SubjectMarks.Remove(fpmark);
                    db.SaveChanges();
                    MessageBox.Show("Marks SUCCESSFULLY DELETED");
                    PopulateDataGridView();
                }
                else if (confirmResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (command.ToString() == "Edit")
            {
                var fpmark = db.SubjectMarks.Find(id);
                txt_Fullmarks.Text = fpmark.fullmarks.ToString();
                txt_Passmarks.Text = fpmark.passmarks.ToString();
                cmb_Subject.Text = fpmark.subject.ToString();
            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            using (var context = new DeskEntityA())
            {
                var commandText = "UPDATE SubjectMarks SET fullmarks='"
                   + txt_Fullmarks.Text.ToString() + "'where  subjectmarks_Id='" + id.ToString() + "'";
                //var name = new SqlParameter("@CategoryName", "Test");
                context.Database.ExecuteSqlCommand(commandText);
            }
            clear();
            MessageBox.Show("Updated Sucessfully");
            PopulateDataGridView();
        }
    }
}
