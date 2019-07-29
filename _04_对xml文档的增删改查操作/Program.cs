using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace _04_对xml文档的增删改查操作
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *    1、创建文档操作对象
             *    2、判断文档是否存在 加载xml文档 操作文档 存在追加 否则创建
             *    3、查看文档
             * 
             * 
             */



            #region 1、对xml文档实现追加功能
            //// 创建文档对象
            //XmlDocument doc = new XmlDocument();
            //// 判断要操作的xml文档是否存在
            //if (File.Exists("Student.xml"))  // 存在 追加
            //{
            //    // 加载文件
            //    doc.Load("Student.xml");
            //    // 获得根节点 追加子节点
            //    XmlElement stus = doc.DocumentElement;
            //    XmlElement student = doc.CreateElement("Student");
            //    student.SetAttribute("studentID", "11");
            //    stus.AppendChild(student);

            //    XmlElement name = doc.CreateElement("Name");
            //    name.InnerXml = "张国荣";
            //    name.SetAttribute("name", "stuName");
            //    name.SetAttribute("class", "stuName");
            //    student.AppendChild(name);

            //    XmlElement age = doc.CreateElement("Age");
            //    age.InnerXml = "26";
            //    age.SetAttribute("name", "stuAge");
            //    age.SetAttribute("class", "stuAge");
            //    student.AppendChild(age);

            //    XmlElement gender = doc.CreateElement("Gender");
            //    gender.InnerXml = "男";
            //    gender.SetAttribute("name", "stuSex");
            //    gender.SetAttribute("class", "stuSex");
            //    student.AppendChild(gender);
            //}
            //else   // 不存在  创建
            //{
            //    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //    doc.AppendChild(dec);
            //    XmlElement stus = doc.CreateElement("Students");
            //    doc.AppendChild(stus);
            //}


            //doc.Save("Student.xml");
            //Console.WriteLine("保存成功");
            //Console.ReadKey();
            #endregion

            #region 2、对文档的解析读取
            //XmlDocument doc = new XmlDocument();
            //if (File.Exists("Student.xml"))   // 判断文件是否存在  存在则加载，进行下一步操作
            //{
            //    // 加载文件
            //    doc.Load("Student.xml");

            //    // 获得根节点
            //    XmlElement stus = doc.DocumentElement;

            //    // 获得根节点所有子节点数据  用来存放所有子节点Student
            //    XmlNodeList xnl = stus.ChildNodes;
            //    foreach (XmlNode item in xnl)
            //    {
            //        Console.WriteLine(item.InnerText);
            //    }

            //    XmlElement stu = stus["Student"];   // 拿出第一个student
            //    XmlNodeList xnl2 = stu.ChildNodes;  // 取出第一个student的所有节点

            //    foreach (XmlNode item in xnl2)
            //    {
            //        Console.WriteLine(item.Attributes["name"].Value);
            //        Console.WriteLine(item.Attributes["class"].Value);
            //    }

            //    doc.Save("Student.xml");
            //    Console.WriteLine("查看成功");
            //    Console.ReadKey();


            //}
            //else   // 不存在
            //{
            //    Console.WriteLine("文件不存在");
            //    Console.ReadKey();
            //} 
            #endregion

            #region 3、使用XPath读取解析xml文件

            //if (File.Exists("Student.xml"))
            //{
            //    XmlDocument doc = new XmlDocument();

            //    doc.Load("Student.xml");

            //    // 获得根节点
            //    XmlElement stus = doc.DocumentElement;

            //    // 根据XPath 解析XML文件 获取单个节点
            //    XmlNode student = stus.SelectSingleNode("/Students/Student[@studentID='11']/Name");
            //    Console.WriteLine(student.InnerText);
            //    Console.ReadKey();

            //    // 根据XPath 解析XML文件 获取选中全部节点
            //    XmlNodeList xnl = stus.SelectNodes("/Students/Student/Name");
            //    foreach (XmlNode item in xnl)
            //    {
            //        Console.WriteLine(item.InnerXml);
            //    }
            //    Console.ReadKey();
            //}

            #endregion

            #region 4、对xml文档的删除操作

            //if (File.Exists("Student.xml"))
            //{
            //    XmlDocument doc = new XmlDocument();
            //    doc.Load("Student.xml");

            //    //doc.RemoveAll();   // 删不掉 因为根节点无法被删除

            //    //// 获取根节点 删除根节点下的所有子节点
            //    //XmlElement stus = doc.DocumentElement;
            //    //stus.RemoveAll();

            //    // Xpath定位删除
            //    XmlElement stus = doc.DocumentElement;

            //    //// 删除子节点 找到父节点 父节点删除子节点
            //    //XmlNode xn = stus.SelectSingleNode("/Students/Student[@studentID='1']/Name/RealName");
            //    //stus["Student"]["Name"].RemoveChild(xn);

            //    XmlNode xn2 = stus.SelectSingleNode("/Students/Student[@studentID='2']/Name");
            //    xn2.Attributes.RemoveNamedItem("name");



            //    doc.Save("Student.xml");
            //    Console.WriteLine("删除成功");
            //    Console.ReadKey();
            //}

            #endregion

            XmlDocument doc = new XmlDocument();
            doc.Load("person.xml");
            XmlElement ps = doc.DocumentElement;
            XmlNodeList xnl = ps.SelectNodes("/Persons/Person");
            foreach (XmlNode item in xnl)
            {
                Console.WriteLine(item.Attributes["id"].Value);
            }
            Console.ReadKey();

        }
    }
}
