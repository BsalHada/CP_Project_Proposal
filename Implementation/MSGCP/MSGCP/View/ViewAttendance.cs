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
        public partial class ViewAttendance : Form
    {
        DeskEntityA db = new DeskEntityA();
        Attendance atd = new Attendance();
        public ViewAttendance()
        {
            InitializeComponent();
        }
        private void Btn_View_Click(object sender, EventArgs e)
        {
            List<Attendance> attendances;
            try
            {
                String classs = cmb_Grade.SelectedValue.ToString();
                String section = cmb_Section.SelectedValue.ToString();
                attendances = (List<Attendance>)db.Attendance.Where(a => a.grade == classs.ToString() && a.section == section.ToString()).ToList();
                dgv_Attendance.DataSource = attendances;
            }
            catch (Exception ex)
            {
                // ignore

            }
        }
        private void ViewAttendance_Load(object sender, EventArgs e)
        {
            //Class in combobox
            cmb_Grade.DataSource = db.Grade.ToList();
            cmb_Grade.ValueMember = "grade1";
            cmb_Grade.DisplayMember = "grade1";
            //Section in combobox
            cmb_Section.DataSource = db.Section.ToList();
            cmb_Section.ValueMember = "section1";
            cmb_Section.DisplayMember = "section1";
        }
    }
}
