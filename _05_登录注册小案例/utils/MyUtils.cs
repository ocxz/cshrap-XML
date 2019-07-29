using _05_登录注册小案例.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace _05_登录注册小案例.utils
{
    public static class MyUtils
    {
        private static string filePath = @"person.xml";

        /// <summary>
        /// 根据对象，添加节点
        /// </summary>
        /// <param name="person"></param>
        public static bool AddPerson(Person person)
        {
            XmlDocument doc = new XmlDocument();
            if (!File.Exists(filePath))  // 文件不存在，则创建,并创建添加子节点
            {
                doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
                doc.AppendChild(doc.CreateElement("Persons"));
                doc.Save(filePath);
            }

            if (GetPersonById(person.PId) == null)
            {
                doc.Load(filePath);  // 加载xml文件
                XmlElement persons = doc.DocumentElement;    // 获取父节点


                Dictionary<string, string> personAttrs = new Dictionary<string, string>();
                personAttrs.Add("id", person.PId);
                XmlElement personElement = AddNode(doc, persons, "Person", null, personAttrs);  // 添加一个person节点
                AddNode(doc, personElement, "Name", person.Name, null);  // 给person节点添加一个Name节点
                AddNode(doc, personElement, "Password", person.Password, null);  // 给person节点添加一个Password节点
                AddNode(doc, personElement, "Gender", person.Gender.ToString(), null);  // 给person节点添加一个Gender节点
                AddNode(doc, personElement, "Birthday", person.Birthday, null);  // 给person节点添加一个Birthday节点
                AddNode(doc, personElement, "Phone", person.Phone, null);  // 给person节点添加一个Phone节点
                AddNode(doc, personElement, "Email", person.Email, null);  // 给person节点添加一个Email节点
                doc.Save(filePath);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得所有节点
        /// </summary>
        /// <returns>返回所有节点对象集合</returns>
        public static List<Person> GetAllPerson()
        {
            List<Person> persons = new List<Person>();
            try
            {
                if (File.Exists(filePath))   // 判断文件是否存在 存在
                {
                    // 文档对象
                    XmlDocument doc = new XmlDocument();
                    // 加载文件
                    doc.Load(filePath);
                    // 获得父节点Persons
                    XmlElement ps = doc.DocumentElement;
                    // 获得所有的Person
                    XmlNodeList xnl = ps.SelectNodes("/Persons/Person");
                    foreach (XmlNode item in xnl)
                    {
                        Person person = new Person();
                        person.PId = item.Attributes["id"].Value;
                        person.Name = item["Name"].InnerXml;
                        person.Password = item["Password"].InnerXml;
                        person.Gender = (Gender)Enum.Parse(typeof(Gender), item["Gender"].InnerXml);
                        person.Birthday = item["Birthday"].InnerXml;
                        person.Phone = item["Phone"].InnerXml;
                        person.Email = item["Email"].InnerXml;
                        persons.Add(person);
                    }
                }
            }
            catch (Exception)
            {

                return persons;
            }
            return persons;
        }

        /// <summary>
        /// 根据id获取对象
        /// </summary>
        /// <param name="id">对象Id</param>
        /// <returns>返回的对象</returns>
        public static Person GetPersonById(string id)
        {
            List<Person> persons = GetAllPerson();
            foreach (Person item in persons)
            {
                if(item.PId == id)
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// 给父节点添加子节点
        /// </summary>
        /// <param name="fatherNode">父节点</param>
        /// <param name="nodeName">子节点名字</param>
        /// <param name="nodeText">子节点文本</param>
        /// <param name="attrs">子节点属性</param>
        private static XmlElement AddNode(XmlDocument doc,XmlNode fatherNode, string nodeName , string nodeText, Dictionary<string, string> attrs)
        {
            

            // 创建子节点
            XmlElement element = doc.CreateElement(nodeName);
            // 给字节的添加属性
            if (attrs != null)
            {
                foreach (var item in attrs.Keys)
                {
                    element.SetAttribute(item, attrs[item]);
                }
            }
            // 给子节点添加文本
            if (!string.IsNullOrEmpty(nodeText))
            {
                element.InnerXml = nodeText;
            }

            // 将子节点加入到父节点中
            fatherNode.AppendChild(element);

            // 返回添加的子节点
            return element;
        }
    }


}
