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
    public partial class UserManual : Form
    {
        public UserManual()
        {
            InitializeComponent();
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            
            }

        private void UserManual_Load(object sender, EventArgs e)
        {
            // Create object of Open file dialog class  
            {
                OpenFileDialog dlg = new OpenFileDialog();
                // set file filter of dialog   
                dlg.Filter = "pdf files (*.pdf) |*.pdf;";
                dlg.ShowDialog();
                if (dlg.FileName != null)
                {
                    // use the LoadFile(ByVal fileName As String) function for open the pdf in control  
                    axAcroPDF1.LoadFile(dlg.FileName);
                }
            }
    }
    }
}
