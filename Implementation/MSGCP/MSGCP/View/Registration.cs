using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGCP.View
{
    public partial class Registration : Form
    {
        User Dbmodel = new User();
        DeskEntityA db = new DeskEntityA();
        public Registration()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt_Username.Text = txt_Password.Text =  "";
        }
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);

            }
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                MessageBox.Show("Please enter USERNAME");
                txt_Username.Focus();
                return;
            }
            if (txt_Password.Text == "")
            {
                MessageBox.Show("Please enter PASSWORD");
                txt_Password.Focus();
                return;
            }
            Dbmodel.user_Name = txt_Username.Text.Trim();
            Dbmodel.password = Encrypt (txt_Password.Text.Trim());
            db.User.Add(Dbmodel);
            db.SaveChanges();
            clear();
            MessageBox.Show("Registered Sucessfully");
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }
    }
}
