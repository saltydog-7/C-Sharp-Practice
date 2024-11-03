// Constructor 建構方法

using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main()
        {
            Person person_1 = new Person(170.5, 30, "Tom");

            Console.WriteLine(person_1.name);
        }
    }
}