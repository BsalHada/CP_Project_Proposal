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
    public partial class addRemark : Form
    {
        DeskEntityA db = new DeskEntityA();
        Remark rm = new Remark();
        int id;
        public addRemark()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_Remark.Text = "";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txt_Remark.Text == "")
            {
                MessageBox.Show("Please enter Remark");
                txt_Remark.Focus();
                return;
            }
            rm.remark1 = txt_Remark.Text.Trim();
            //SQL Execution
            db.Remark.Add(rm);
            db.SaveChanges();
            clear();
            MessageBox.Show("Saved Sucessfully");
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
            dgv_Remarks.DataSource = db.Remark.ToList<Remark>();
         }
        private void AddRemark_Load(object sender, EventArgs e)
        {
          PopulateDataGridView();
        }
        public void Dgv_Remarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var command = dgv_Remarks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            id = Convert.ToInt32(dgv_Remarks.Rows[e.RowIndex].Cells["remark_Id"].Value);
            if (command.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var remarks = db.Remark.Find(id);
                    db.Remark.Remove(remarks);
                    db.SaveChanges();
                    MessageBox.Show("REMARK SUCCESSFULLY DELETED");
                    PopulateDataGridView();
                }
                else if (confirmResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (command.ToString() == "Edit")
            {
                var remarks = db.Remark.Find(id);
                txt_Remark.Text = remarks.remark1.ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (var context = new DeskEntityA())
            {
                var commandText = "UPDATE Remark SET remark='"+ txt_Remark.Text.ToString()+ "' where  remark_Id='"+id.ToString()+ "'";
                context.Database.ExecuteSqlCommand(commandText);
            }
            clear();
            MessageBox.Show("Updated Sucessfully");
            PopulateDataGridView();
        }
    }
}

