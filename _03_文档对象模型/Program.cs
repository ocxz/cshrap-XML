using System;
using System.Xml;
using System.Collections.Generic;

namespace _03_文档对象模型
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stuNames = { "张三", "李四", "王五", "赵六", "田七", "韩婷婷", "李凤姐", "张不留", "孙大圣", "娜可露露" };
            Random r = new Random();
            List<Student> stuList = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student stu = new Student(i + 1, stuNames[i], 18 + i, (Gender)r.Next(2));
                stuList.Add(stu);
            }

            // 创建xml文档
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            // 创建根节点
            XmlElement stus = doc.CreateElement("Students");
            doc.AppendChild(stus);

            // 循环集合 获得对象 生成节点 添加至xml文档
            for (int i = 0; i < stuList.Count; i++)
            {
                XmlElement Student = doc.CreateElement("Student");
                Student.SetAttribute("studentID", stuList[i].Id.ToString());
                stus.AppendChild(Student);

                XmlElement Name = doc.CreateElement("Name");
                Name.InnerXml = stuList[i].Name;
                Name.SetAttribute("name", "stuName");
                Name.SetAttribute("class", "stuName");
                Student.AppendChild(Name);

                XmlElement Age = doc.CreateElement("Age");
                Age.InnerXml = stuList[i].Age.ToString();
                Age.SetAttribute("name", "stuAge");
                Age.SetAttribute("class", "stuAge");
                Student.AppendChild(Age);

                XmlElement Gender = doc.CreateElement("Gender");
                Gender.InnerXml = stuList[i].Gender.ToString();
                Gender.SetAttribute("name", "stuSex");
                Gender.SetAttribute("class", "stuSex");
                Student.AppendChild(Gender);
            }
            doc.Save("Student.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }


    public enum Gender
    {
        男,
        女,
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }


        public Student() { }
        public Student(int stuId, string stuName, int stuAge, Gender stuGender)
        {
            this.Id = stuId;
            this.Name = stuName;
            this.Age = stuAge;
            this.Gender = stuGender;
        }
    }
}
