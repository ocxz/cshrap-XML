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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string id = userId.Text.Trim();
            string pwd = userPwd.Text.Trim();

            Person person = MyUtils.GetPersonById(id);
            if (person != null)
            {
                if (person.Password == pwd)
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
            else
            {
                MessageBox.Show("用户不存在");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show(this);
        }
    }
}
