namespace _05_登录注册小案例
{
    partial class Register
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
            this.idLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.pwdLb = new System.Windows.Forms.Label();
            this.birthdayLb = new System.Windows.Forms.Label();
            this.genderLb = new System.Windows.Forms.Label();
            this.phoneLb = new System.Windows.Forms.Label();
            this.emailLb = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnReigster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLb
            // 
            this.idLb.AutoSize = true;
            this.idLb.Location = new System.Drawing.Point(225, 30);
            this.idLb.Name = "idLb";
            this.idLb.Size = new System.Drawing.Size(53, 12);
            this.idLb.TabIndex = 0;
            this.idLb.Text = "用户ID：";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(225, 74);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(53, 12);
            this.nameLb.TabIndex = 1;
            this.nameLb.Text = "用户名：";
            // 
            // pwdLb
            // 
            this.pwdLb.AutoSize = true;
            this.pwdLb.Location = new System.Drawing.Point(225, 127);
            this.pwdLb.Name = "pwdLb";
            this.pwdLb.Size = new System.Drawing.Size(65, 12);
            this.pwdLb.TabIndex = 1;
            this.pwdLb.Text = "用户密码：";
            // 
            // birthdayLb
            // 
            this.birthdayLb.AutoSize = true;
            this.birthdayLb.Location = new System.Drawing.Point(225, 187);
            this.birthdayLb.Name = "birthdayLb";
            this.birthdayLb.Size = new System.Drawing.Size(65, 12);
            this.birthdayLb.TabIndex = 1;
            this.birthdayLb.Text = "出生年月：";
            // 
            // genderLb
            // 
            this.genderLb.AutoSize = true;
            this.genderLb.Location = new System.Drawing.Point(225, 252);
            this.genderLb.Name = "genderLb";
            this.genderLb.Size = new System.Drawing.Size(41, 12);
            this.genderLb.TabIndex = 1;
            this.genderLb.Text = "性别：";
            // 
            // phoneLb
            // 
            this.phoneLb.AutoSize = true;
            this.phoneLb.Location = new System.Drawing.Point(225, 301);
            this.phoneLb.Name = "phoneLb";
            this.phoneLb.Size = new System.Drawing.Size(65, 12);
            this.phoneLb.TabIndex = 2;
            this.phoneLb.Text = "电话号码：";
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Location = new System.Drawing.Point(225, 347);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(65, 12);
            this.emailLb.TabIndex = 2;
            this.emailLb.Text = "常用邮箱：";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(296, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 21);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(296, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(296, 127);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(148, 21);
            this.txtPwd.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(296, 298);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(148, 21);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(296, 338);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 21);
            this.txtEmail.TabIndex = 3;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(310, 247);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(35, 16);
            this.rbMan.TabIndex = 4;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "男";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(392, 247);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(35, 16);
            this.rbWoman.TabIndex = 5;
            this.rbWoman.Text = "女";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(297, 177);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(190, 21);
            this.txtBirthday.TabIndex = 6;
            // 
            // btnReigster
            // 
            this.btnReigster.Location = new System.Drawing.Point(551, 384);
            this.btnReigster.Name = "btnReigster";
            this.btnReigster.Size = new System.Drawing.Size(75, 23);
            this.btnReigster.TabIndex = 7;
            this.btnReigster.Text = "注册";
            this.btnReigster.UseVisualStyleBackColor = true;
            this.btnReigster.Click += new System.EventHandler(this.BtnReigster_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReigster);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.rbWoman);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.emailLb);
            this.Controls.Add(this.phoneLb);
            this.Controls.Add(this.genderLb);
            this.Controls.Add(this.birthdayLb);
            this.Controls.Add(this.pwdLb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.idLb);
            this.Name = "Register";
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLb;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label pwdLb;
        private System.Windows.Forms.Label birthdayLb;
        private System.Windows.Forms.Label genderLb;
        private System.Windows.Forms.Label phoneLb;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.DateTimePicker txtBirthday;
        private System.Windows.Forms.Button btnReigster;
    }
}