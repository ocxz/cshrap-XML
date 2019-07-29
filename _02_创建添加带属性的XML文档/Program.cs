using System;
using System.Xml;

namespace _02_创建添加带属性的XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement Persons = doc.CreateElement("Persons");
            doc.AppendChild(Persons);

            XmlElement Person = doc.CreateElement("Person");
            Person.SetAttribute("id", "1");
            Person.SetAttribute("class", "person");
            Persons.AppendChild(Person);

            XmlElement Name = doc.CreateElement("Name");
            Name.InnerText = "张三";
            Name.SetAttribute("name", "userName");
            Name.SetAttribute("class", "userName");
            Person.AppendChild(Name);

            XmlElement Age = doc.CreateElement("Age");
            Age.InnerText = "18";
            Person.AppendChild(Age);

            XmlElement Person2 = doc.CreateElement("Person");
            Person2.SetAttribute("id", "2");
            Person2.SetAttribute("class", "person");
            Persons.AppendChild(Person2);
            XmlElement Name2 = doc.CreateElement("Name");
            Name2.SetAttribute("name", "username");
            Name2.SetAttribute("class", "userName");
            Name2.InnerXml = "李四";
            Person2.InnerXml = "<Age name='userAge' class='userAge'>18</Age>";
            Person2.AppendChild(Name2);

            doc.Save("Persons.xml");

            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
}
