using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_登录注册小案例.POJO
{
    public class Person
    {
        public string PId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person() { }
        public Person(string pid,string name,string password,Gender gender)
        {
            this.PId = pid;
            this.Name = name;
            this.Password = password;
            this.Gender = gender;
        }
        public Person(string pid, string name, string password,Gender gender, string birthday
            , string phone,string email) : this(pid, name, password, gender)
        {
            this.Birthday = birthday;
            this.Phone = phone;
            this.Email = email;
        }
    }

    public enum Gender
    {
        男,
        女,
    }
}
