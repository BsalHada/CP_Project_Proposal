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
    public partial class SchoolDetails : Form
    {
        School sdb = new School();
        DeskEntityA db = new DeskEntityA();
        public SchoolDetails()
        {
            InitializeComponent();
        }
        private void Label17_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txt_Schoolname.Text =
            txt_Address.Text =
            txt_Contact.Text =
            txt_Email.Text =
            txt_Estd.Text =
            txt_Website.Text =
            txt_Principalname.Text = "";
            sdb.school_Id = 0;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Schoolname.Text == "")
            {
                MessageBox.Show("Please enter School Name");
                txt_Schoolname.Focus();
                return;
            }
            if (txt_Address.Text == "")
            {
                MessageBox.Show("Please enter School Address");
                txt_Address.Focus();
                return;
            }
            if (txt_Principalname.Text == "")
            {
                MessageBox.Show("Please enter Principal Name");
                txt_Principalname.Focus();
                return;
            }
            if (txt_Estd.Text == "")
            {
                MessageBox.Show("Please enter Date of Establishment.");
                txt_Estd.Focus();
                return;
            }
            sdb.school_Name = txt_Schoolname.Text.Trim();
            sdb.address = txt_Address.Text.Trim();
            sdb.phone = txt_Contact.Text.Trim();
            sdb.email = txt_Email.Text.Trim();
            sdb.established_Date = txt_Estd.Text.Trim();
            sdb.website = txt_Website.Text.Trim();
            sdb.principal_Name = txt_Principalname.Text.Trim();
            //SQL Execution
            db.School.Add(sdb);
            db.SaveChanges();
            MessageBox.Show("Saved Sucessfully");
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
               // pictureBox1.Image = Image.FromFile(opf.FileName);
                
            }

        }
    }
}
