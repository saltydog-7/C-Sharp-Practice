// Main 方法

using ConsoleApp15;
using System;

class Program
{
    static void Main()
    {
        Person person_1 = new Person();
        person_1.height = 170.5;
        person_1.name = "Tom";
        person_1.age = 30;
        person_1.SayHi();

        Person person_2 = new Person();
        person_2.height = 162.3;
        person_2.name = "Mary";
        person_2.age = 14;
        Console.WriteLine(person_2.IsAdult());

        Person person_3 = new Person();
        person_3.height = 155.4;
        person_3.name = "June";
        person_3.age = 18;
        Console.WriteLine(person_2.Add(3, 6));
    }
}