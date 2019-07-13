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
    public partial class Sections : Form
    {
        Section sc = new Section();
        DeskEntityA db = new DeskEntityA();
        int id;
        public Sections()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_Section.Text= "";
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Section.Text == "")
            {
                MessageBox.Show("Please enter Section");
                txt_Section.Focus();
                return;

            }
            sc.section1 = txt_Section.Text.Trim();
            //SQL Execution
            db.Section.Add(sc);
            db.SaveChanges();
            clear();
            MessageBox.Show("Saved Sucessfully");
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
                dgv_Section.DataSource = db.Section.ToList<Section>();
        }
        private void Sections_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        private void Sections_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        private void Dgv_Section_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var command = dgv_Section.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            id = Convert.ToInt32(dgv_Section.Rows[e.RowIndex].Cells["section_Id"].Value);
            if (command.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var sec = db.Section.Find(id);
                    db.Section.Remove(sec);
                    db.SaveChanges();
                    MessageBox.Show("SECTION SUCCESSFULLY DELETED");
                    PopulateDataGridView();
                }
                else if (confirmResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (command.ToString() == "Edit")
            {
                var sec = db.Section.Find(id);
                txt_Section.Text = sec.section1.ToString();

            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            using (var context = new DeskEntityA())
            {
                var commandText = "UPDATE Section SET section='"
                   + txt_Section.Text.ToString() + "' where  section_Id='" + id.ToString() + "'";
                context.Database.ExecuteSqlCommand(commandText);
            }
            clear();
            MessageBox.Show("Updated Sucessfully");
            PopulateDataGridView();
        }
    }
    
}
