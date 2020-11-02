using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonbuchCS
{
    class Person
    {
        public string name { get; set; }
        public string number { get; set; }
        public int age { get; set; }

        public Person()
        {
        }

        public Person(string name, string number, int age)
        {
            this.name = name;
            this.number = number;
            this.age = age;
        }

        public void print()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Number: " + this.number);
            Console.WriteLine("Age: " + this.age);
        }
    }
}
