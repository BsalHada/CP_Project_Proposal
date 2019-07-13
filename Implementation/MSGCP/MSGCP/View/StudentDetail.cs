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
    public partial class StudentDetail : Form
    {
        Student std = new Student();
        DeskEntityA db = new DeskEntityA();
        public StudentDetail()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_Contact.Text = txt_Email.Text = txt_StudentName.Text = 
            txt_Rollno.Text = txt_phone.Text = txt_Parentsname.Text = 
            txt_Parentsname.Text = cmb_Section.Text = cmb_Grade.Text = 
            cmb_Gender.Text = txt_Address.Text = "";
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_StudentName.Text == "")
            {
                MessageBox.Show("Please enter Student Name");
                txt_StudentName.Focus();
                return;
            }
            if (txt_Address.Text == "")
            {
                MessageBox.Show("Please enter School Address");
                txt_Address.Focus();
                return;

            }
            if (cmb_Gender.Text == "")
            {
                MessageBox.Show("Please enter Select Gender");
                cmb_Gender.Focus();
                return;
            }
            if (txt_Contact.Text == "")
            {
                MessageBox.Show("Please enter Date of Establishment.");
                txt_Contact.Focus();
                return;
            }
            if (txt_Parentsname.Text == "")
            {
                MessageBox.Show("Please enter Parents Name.");
                txt_Parentsname.Focus();
                return;
            }
            if (txt_phone.Text == "")
            {
                MessageBox.Show("Please enter Parents Contact.");
                txt_phone.Focus();
                return;
            }
            if (cmb_Grade.Text == "")
            {
                MessageBox.Show("Please Select Class.");
                cmb_Grade.Focus();
                return;
            }
            if (cmb_Section.Text == "")
            {
                MessageBox.Show("Please choose Section.");
                cmb_Section.Focus();
                return;
            }

            std.full_Name= txt_StudentName.Text.Trim();
            std.address=txt_Address.Text.Trim();
            std.gender=cmb_Gender.Text.Trim();
            std.phone= txt_Contact.Text.Trim();
            std.DOB = dateTimePicker1.Value.Date;
            std.gender = cmb_Gender.Text.Trim();
            std.parents_Name= txt_Parentsname.Text.Trim();
            std.parent_Phone= txt_phone.Text.Trim();
            std.email= txt_Email.Text.Trim();
            std.grade= cmb_Grade.Text.Trim();
            std.section= cmb_Section.Text.Trim();
            std.roll_No= int.Parse(txt_Rollno.Text.Trim());
            db.Student.Add(std);
            db.SaveChanges();
            MessageBox.Show("Saved Sucessfully");
        }
        private void StudentDetail_Load(object sender, EventArgs e)
        {
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Save.Enabled = false;
            txt_StudentName.Enabled = false;
            txt_Address.Enabled = false;
            cmb_Gender.Enabled = false;
            txt_Contact.Enabled = false;
            txt_Parentsname.Enabled = false;
            txt_phone.Enabled = false;
            txt_Email.Enabled = false;
            cmb_Grade.Enabled = false;
            cmb_Section.Enabled = false;
            txt_Rollno.Enabled = false;
            int count = 0;
            count = db.Student.Count();
            lbl_Record.Text = count.ToString();
        }
        private void Btn_Newentry_Click(object sender, EventArgs e)
        {
            clear();
            btn_Delete.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Save.Enabled = true;
            txt_StudentName.Enabled = true;
            txt_Address.Enabled = true;
            cmb_Gender.Enabled = true;
            txt_Contact.Enabled = true;
            txt_Parentsname.Enabled = true;
            txt_phone.Enabled = true;
            txt_Email.Enabled = true;
            cmb_Grade.Enabled = true;
            cmb_Section.Enabled = true;
            txt_Rollno.Enabled = true;

            cmb_Grade.DataSource = db.Grade.ToList();
            cmb_Grade.ValueMember = "grade_Id";
            cmb_Grade.DisplayMember = "grade1";

            cmb_Section.DataSource = db.Section.ToList();
            cmb_Section.ValueMember = "section_Id";
            cmb_Section.DisplayMember = "section1";
        }
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            btn_Edit.Text = "UPDATE";
            
        }
        private void Txt_StudentName_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
