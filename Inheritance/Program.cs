using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Cusromer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {

    }

}
