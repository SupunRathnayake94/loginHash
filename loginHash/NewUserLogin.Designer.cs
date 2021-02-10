namespace loginHash
{
    partial class NewUserLoginFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FormcaptionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName/Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(115, 36);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(206, 20);
            this.UserNameTxt.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(115, 65);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = 'ӝ';
            this.PasswordTxt.Size = new System.Drawing.Size(206, 20);
            this.PasswordTxt.TabIndex = 1;
            // 
            // ConfirmPasswordTxt
            // 
            this.ConfirmPasswordTxt.Location = new System.Drawing.Point(115, 91);
            this.ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            this.ConfirmPasswordTxt.PasswordChar = 'ӝ';
            this.ConfirmPasswordTxt.Size = new System.Drawing.Size(206, 20);
            this.ConfirmPasswordTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Passward";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirm Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sing Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormcaptionLbl
            // 
            this.FormcaptionLbl.AutoSize = true;
            this.FormcaptionLbl.Location = new System.Drawing.Point(144, 9);
            this.FormcaptionLbl.Name = "FormcaptionLbl";
            this.FormcaptionLbl.Size = new System.Drawing.Size(66, 13);
            this.FormcaptionLbl.TabIndex = 0;
            this.FormcaptionLbl.Text = "FormCaption";
            this.FormcaptionLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewUserLoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfirmPasswordTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FormcaptionLbl);
            this.Controls.Add(this.label1);
            this.Name = "NewUserLoginFrm";
            this.Text = "New User Log in";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox ConfirmPasswordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FormcaptionLbl;
    }
}