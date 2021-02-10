using loginHash.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginHash
{
    public partial class logInFrm : Form
    {
        public logInFrm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserNameTxt.SelectAll();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegisterFrm frm = new UserRegisterFrm();
            frm.Show(this);
        }
        public static void ThreadProc()
        {
            MainFrm f;
            Application.Run(new MainFrm());
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxt.Text;
            //string password = loginHash.Helpers.AESEncryption.Encrypt(PlainText: "userName", Password: PasswordTxt.Text);
            string password = null;

            using (var context = new DataModelContainer())
            {
                IEnumerable<SystemUser> password4rmDatabase = from a in context.SystemUser
                                                              where a.UserName == userName
                                                              select a;

                foreach (var item in password4rmDatabase)
                {
                    string salt = item.saltIguess;
                    string pass = item.Password;
                    Helpers.HashAndSaltencryption encryptCls = new Helpers.HashAndSaltencryption();
                    password = encryptCls.GenerateSHA256Hash(PasswordTxt.Text, salt);


                    if (password == pass)
                    {
                        //MainFrm.
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                        t.Start();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Enterd Cridentials not valied");
                    }
                }
            }
               
        }

        private void UserNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                PasswordTxt.SelectAll();
            }
        }

        private void PasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnLogIn_Click(sender, e);
            }
        }
    }
}
