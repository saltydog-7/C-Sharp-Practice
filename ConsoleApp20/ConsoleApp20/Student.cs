using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Student : Person //使用:將Student繼承Person已有的內容
    {
        public string school;

        public Student(string name, int age, string school)
        {
            this.name = name;
            this.age = age;
            this.school = school;
        }

        public void PrintSchool()
        {
            Console.WriteLine(this.school);
        }
    }
}
