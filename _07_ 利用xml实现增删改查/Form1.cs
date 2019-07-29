using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _07__利用xml实现增删改查
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //存储对象的集合
            List<User> listUser = new List<User>();

            XmlDocument doc = new XmlDocument();
            doc.Load("Student.xml");

            // 获得父节点
            XmlElement stus = doc.DocumentElement;

            foreach (XmlNode item in stus.ChildNodes)
            {
                User u = new User();
                u.ID = int.Parse(item.Attributes["studentID"].Value);
                u.Name = item["Name"].InnerXml;
                u.Age = int.Parse(item["Age"].InnerXml);
                u.Gender = char.Parse(item["Gender"].InnerXml);
                listUser.Add(u);
            }

            dataGridView1.DataSource = listUser;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
