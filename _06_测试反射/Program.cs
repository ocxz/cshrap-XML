using System;
using System.Reflection;
using System.Xml;
using System.Collections.Generic;

namespace _06_测试反射
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ps = { "张三", "18", "男" };

            int i = 0;
            Person person = new Person();
            foreach (var item in GetPropertyInfoArray())
            {
                switch (item.Name)
                {

                }
            }

            Console.ReadKey();
        }



        private static  PropertyInfo[] GetPropertyInfoArray()
        {
            PropertyInfo[] props = null;
            try
            {
                Type type = typeof(Person);
                object obj = Activator.CreateInstance(type);
                props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            }
            catch (Exception ex)
            { }
            return props;
        }

        public static void ObjectToXml(string path, string NodeName,)
        {

        }
    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
    }


}
