using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Person
    {
        public int age;
        public string name;
        public double height;

        public Person(double height, int age, string name)
        {
            this.height = height;
            this.age = age;
            this.name = name;
        }
    }
}
