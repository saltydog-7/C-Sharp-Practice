using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Person
    {
        public int age;
        public string name;
        public double height;

        public void SayHi()
        {
            Console.WriteLine("Hello, My name is " + name);
        }
        
        public bool IsAdult()
        {
            if (age>18) { return true; }
            else { return false; }
        } 

        public int Add(int num_1, int num_2)
        {
            return num_1 + num_2;
        }
    }
}
