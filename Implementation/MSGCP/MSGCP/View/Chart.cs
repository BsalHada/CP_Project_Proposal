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
    public partial class Chart : Form
    {
        DeskEntityA db = new DeskEntityA();
        Grade gd = new Grade();
        public Chart()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            
            chartdata();
        }

        private void Chart_Load(object sender, EventArgs e)
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

        private void chartdata()
        {
            List<ResultTotal> chartresult;
            try {
                String classId = cmb_Grade.SelectedValue.ToString();
                String sectionId = cmb_Section.SelectedValue.ToString();
                String studentname = cmb_Stdname.SelectedValue.ToString();
                
                chartresult = (List<ResultTotal>)db.ResultTotal.Where(a => a.section == sectionId.ToString() && a.grade == classId.ToString() 
                && a.student_name == studentname.ToString()).ToList();


                chartProgress.DataSource = chartresult.ToList();
                chartProgress.Series["Progress"].XValueMember =  "examination_Type";
                chartProgress.Series["Progress"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartProgress.Series["Progress"].YValueMembers = "obtained_Total";
                chartProgress.Series["Progress"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartProgress.Series["Progress"]["PieLabelStyle"] = "Disabled";

            }
            catch (Exception ex){

            }
        }
        private void loadStudent(object sender, EventArgs e)
        {
            List<Student> students;

            try
            {
                String classId = cmb_Grade.SelectedValue.ToString();
                String sectionId = cmb_Section.SelectedValue.ToString();
                students = (List<Student>)db.Student.Where(a => a.section == sectionId.ToString() && a.grade == classId.ToString()).ToList();
                //Student combo box
                cmb_Stdname.DataSource = students;
                cmb_Stdname.DisplayMember = "full_Name";
                cmb_Stdname.ValueMember = "full_Name";
                //Roll no combo box 
                cmb_Roll.DataSource = students;
                cmb_Roll.ValueMember = "roll_No";
                cmb_Roll.DisplayMember = "roll_No";

            }
            catch (Exception ex)
            {
                // ignore

            }
        }
    }
    }

