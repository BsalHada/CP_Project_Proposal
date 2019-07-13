using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace MSGCP.View
{
    public partial class Login : Form
    {
        User user = new User();
        DeskEntityA db = new DeskEntityA();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
           
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {

            if (user.checkLogin(txt_Username.Text, txt_Password.Text))
            {
                Dashboard form = new Dashboard();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username and Password.");
            }
        }
        private void Lbl_Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration form = new Registration();
            form.ShowDialog();
            this.Close();
        }
    }
}

