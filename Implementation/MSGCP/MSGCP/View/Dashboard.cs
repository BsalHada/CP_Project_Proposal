using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGCP.View
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fULLMARKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            fmentry form = new fmentry();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void rESULTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            SchoolDetails form = new SchoolDetails();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            StudentDetail form = new StudentDetail();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            StudentDetail form = new StudentDetail();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            SchoolDetails form = new SchoolDetails();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void sUBJECTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            Subjects form = new Subjects();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void main_fetch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void eXAMINATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            Exam form = new Exam();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void gRADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            Class form = new Class();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void sECTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            Sections form = new Sections();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void rEMARKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            addRemark form = new addRemark();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void sTUDENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            StudentDetail form = new StudentDetail();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void sCHOOLDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            SchoolDetails form = new SchoolDetails();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void aTTENDANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            Attendances form = new Attendances();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void MARKSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LEDGERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewResult form = new ViewResult();
            form.ShowDialog();
            this.Close();
        }

        private void MARKSOBTAINEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            MarksObtainedEntry form = new MarksObtainedEntry();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void STUDENTDETAILSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            Export form = new Export();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void SCHOOLDETAILSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            SchoolDetails form = new SchoolDetails();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void USERGUIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"D:\MSG\MSGCP\MSGCP\Resources\userManual.pdf");
            Process.Start(startInfo);
        }

        private void PROGRESSCHARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            Chart form = new Chart();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void IMPORTSTUDENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            ImportStudent form = new ImportStudent();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            form.Show();
        }

        private void ATTENDANCEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            main_fetch.Controls.Clear();
            ViewAttendance form = new ViewAttendance();
            form.TopLevel = false;
            main_fetch.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            form.Show();
        }

        private void MARKSHEETToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HELPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
