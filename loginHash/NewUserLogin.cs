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
    public partial class NewUserLoginFrm : Form
    {
        User user = new User();
        string formCaption = "New User Creation..";
        string FormCaption
        {
            set { formCaption = value; }
            get { return formCaption; }
        }
        public NewUserLoginFrm(User User)
        {
            user = User;
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            FormcaptionLbl.Text = formCaption;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxt.Text;
            string password = PasswordTxt.Text;
            string confirmPassword = ConfirmPasswordTxt.Text;

            if (password != confirmPassword)
                return;
            bool result = validateUserName(userName);
            if (!result)
                return;

            /********************* Encryption  ****************************/
            //string text = loginHash.Helpers.AESEncryption.Encrypt(PlainText: "userName", Password: password);
            //SystemUser newUser = new SystemUser()
            //{
            //    UserName = userName,
            //    Password = text,
            //    saltIguess = "userName"
            //};


            //using (var context = new DataModelContainer()/*<--this my dbcontext Name*/)
            //{
            //    List<SystemUser> SUser = new List<SystemUser>();
            //    SUser.Add(newUser);

            //    user.SystemUser = SUser;
            //    context.ApplicationUsers.Add(user);
            //    context.SaveChanges();
            //}
            //this.Dispose();
            /**************************************************************/

            Helpers.HashAndSaltencryption encryptCls = new Helpers.HashAndSaltencryption();

            string salt = encryptCls.CreatedSalt(64);
            string pass = encryptCls.GenerateSHA256Hash(password, salt);
            SystemUser newUser = new SystemUser()
            {
                UserName = userName,
                Password = pass,
                saltIguess = salt
            };

            using (var context = new DataModelContainer()/*<--this my dbcontext Name*/)
            {
                List<SystemUser> SUser = new List<SystemUser>();
                SUser.Add(newUser);

                user.SystemUser = SUser;
                context.ApplicationUsers.Add(user);
                context.SaveChanges();
            }
            this.Dispose();
        }

        private bool validateUserName(string userName)
        {
            return true;
            //incomplate
        }


        //public String CreatedSalt(int size)
        //{
        //    var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
        //    var buff = new byte[size];
        //    rng.GetBytes(buff);
        //    return Convert.ToBase64String(buff);
        //}

        //public String GenerateSHA256Hash(String input, String salt)
        //{
        //    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
        //    System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
        //    byte[] hash = sha256hashstring.ComputeHash(bytes);
        //    return Convert.ToBase64String(hash);
        //}

    }
}
