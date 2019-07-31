using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_records
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person.counter = 0;

            string check = "y";
            while (check == "y")
            {
                Console.Clear();
                Person.counter++;
                Person newPerson = new Person();
                Console.Write("Please enter the person's first name: ");
                newPerson.Fname = Console.ReadLine();
                Console.Write("Please enter the person's last name: ");
                newPerson.Lname = Console.ReadLine();
                Console.Write("Please enter the person's age name: ");
                newPerson.Age = int.Parse(Console.ReadLine());
                people.Add(newPerson);
                Console.Write("Would you like to add another person? (y/n): ");
                check = Console.ReadLine();
            }

            Console.WriteLine($"The number of people created: {Person.counter}");
            foreach(Person x in people)
                Console.WriteLine($"\nName: {x.Fname} {x.Lname}\nAge: {x.Age}");
            Console.ReadLine();
        }
    }
    class Person
    {
        private string fname;
        private string lname;
        private int age;
        public static int counter;

        public string Fname { get { return fname; }set{ fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set{ age = value; } }

        public string ReturnDeets()
        {
            return $"Name: {fname} {lname}\nAge: {age}";
        }
        public Person() { }
        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
            counter++;
        }
    }
}
