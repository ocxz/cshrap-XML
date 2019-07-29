using System;
using System.Xml;

namespace _01_创建xml文档
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  DOM操作xml文档
             *  1、创建xml文档对象  XmlDocument doc = new XmlDocument();
             *  2、创建添加xml文档描述信息 <?xml version="1.0" encoding="utf-8" ?>
             *  3、创建添加xml文档根节点
             *  4、创建添加xml文档子节点
             *  5、设置标签文本
             */

            // 1、创建xml文档对象
            XmlDocument doc = new XmlDocument();
            // 2、创建添加xml文档描述信息 <?xml version="1.0" encoding="utf-8" ?>
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            // 3、创建添加xml文档根节点
            XmlElement books = doc.CreateElement("Books");
            doc.AppendChild(books);
            // 4、创建添加xml文档子节点
            XmlElement book = doc.CreateElement("Book");
            books.AppendChild(book);
            XmlElement bookName = doc.CreateElement("BookName");
            //设置标签文本
            bookName.InnerText = "水浒传";
            book.AppendChild(bookName);
            XmlElement author = doc.CreateElement("Author");
            author.InnerXml = "<Name>施耐庵</Name>";
            book.AppendChild(author);
            XmlElement authorAge = doc.CreateElement("Age");
            authorAge.InnerText = "18";
            author.AppendChild(authorAge);
            // 最后保存文件
            doc.Save("MyBooks.xml");

            Console.WriteLine("保存成功");
            Console.ReadKey();


        }
    }
}
