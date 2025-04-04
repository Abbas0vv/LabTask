using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab
{
    class Student
    {
        int _id = 1;
        public Student(string fullName, string groupNo, byte age)
        {
            Id = _id;
            FullName = fullName;
            GroupNo = groupNo;
            Age = age;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public byte Age { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Id}. {FullName}, {Age} => {GroupNo}");
        }
    }
}
