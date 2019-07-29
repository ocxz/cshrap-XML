using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _05_登录注册小案例.POJO;
using _05_登录注册小案例.utils;

namespace _05_登录注册小案例
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnReigster_Click(object sender, EventArgs e)
        {
            string pid = txtId.Text.Trim();
            if (MyUtils.GetPersonById(pid) != null)
            {
                MessageBox.Show("用户已存在，注册失败");
            }
            else
            {
                string name = txtName.Text.Trim();
                string pwd = txtPwd.Text;
                Gender gender = rbMan.Checked ? Gender.男 : Gender.女;
                string birthday = txtBirthday.Value.ToShortDateString();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();

                Person person = new Person(pid, name, pwd, gender, birthday, phone, email);
                MyUtils.AddPerson(person);
                MessageBox.Show("注册成功");
            }
        }
    }
}
