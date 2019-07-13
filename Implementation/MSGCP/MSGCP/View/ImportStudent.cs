using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MSGCP.View
{
    public partial class ImportStudent : Form
    {
        public ImportStudent()
        {
            InitializeComponent();
        }
        DataSet result;
        private void Btn_Import_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Excel Workbook 97-2016|*.xls|Excel Workbook|*.xlsx",
                ValidateNames = true

            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (ofd.FilterIndex == 1)
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    //IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    //IExcelDataReader rd = ExcelReaderFactory.CreateBinaryReader(fs);
                    
                    //reader. IsFirstRowAsColumnNames = true;
                   // result = reader.AsDataSet();
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                   });
                    cmb_Import.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                        cmb_Import.Items.Add(dt.TableName);
                    reader.Close();


                }
            }
        }

        private void Cmb_Import_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = result.Tables[cmb_Import.SelectedIndex];
        }

        private void btn_Imp_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel Files|*.xls;.xlsx;*.xlsm";
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream stream = new FileStream(open.FileName, FileMode.Open);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = reader.AsDataSet();
            DeskEntityA db = new DeskEntityA();
            foreach (DataTable table in result.Tables)
            {
                foreach(DataRow dr in table.Rows)
                {
                    Student std = new Student()
                    {
                    //    student_Id=Convert.ToInt32(dr[0]),
                    //    full_Name=Convert.ToString(dr[1]),
                    //    grade=Convert.ToString(dr[9]),
                    //    section=Convert.ToString(dr[10]),
                    //    roll_No=Convert.ToInt32(dr[11]),
                    //    address=Convert.ToString(dr[2]),
                    //   // DOB=Convert.ToString(dr[6]),
                    //   parents_Name=Convert.ToString(dr[6]),
                    //   parent_Phone=Convert.ToString(dr[8])

                       student_Id = Convert.ToInt32(dr[0]),
                        full_Name = Convert.ToString(dr[1]),
                        grade = Convert.ToString(dr[2]),
                        section = Convert.ToString(dr[3]),
                        roll_No = Convert.ToInt32(dr[4]),
                        address = Convert.ToString(dr[5]),
                        // DOB=Convert.ToString(dr[6]),
                        parents_Name = Convert.ToString(dr[7]),
                        parent_Phone = Convert.ToString(dr[8])

                    };
                    db.Student.Add(std);
                }
            }
            db.SaveChanges();
            reader.Close();
            stream.Close();
            MessageBox.Show("Saved Successfully");
        }
    }
}





