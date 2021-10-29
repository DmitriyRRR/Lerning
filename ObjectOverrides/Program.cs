using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    
    class Person 
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public int SSN { get; set; }
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }

        public override string ToString()
        => $"[First Name: { FirstName}; LastName Name: { LastName}; Age; { Age}]";
        public override bool Equals(object obj) => obj.ToString() == ToString();
        public override int GetHashCode() => SSN.GetHashCode();

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with System.Object*******\n");
            Person p1 = new Person("Homer", "Ivanov", 55);
            Person p2 = new Person("Homer", "Ivanov", 50);
            Console.WriteLine($"p1.Tostring: {p1.ToString()}\n p2.Tostring: {p2.ToString()}");
            //Console.WriteLine($"Hash Code: {p1.GetHashCode()}");
            //Console.WriteLine($"Type: {p1.GetType()}");
            //Person p2 = p1;
            Console.WriteLine($"p1=p2?: {p1.Equals(p2)}");

            Console.WriteLine("*******************************");
            Console.WriteLine($"Same HASH?: {p1.GetHashCode()== p2.GetHashCode()}");
            Console.WriteLine("*******************************");
            p2.Age = 47;
            Console.WriteLine($"p1.ToString()= {p1.ToString()}");
            Console.WriteLine($"p2.ToString()= {p2.ToString()}");
            Console.WriteLine($"Is this Persons p1=p2?:{p1.Equals(p2)}");
            Console.WriteLine(p1.Age.GetHashCode());
            Console.WriteLine($"Same HASH?: {p1.Age.GetHashCode()==p2.Age.GetHashCode()}");
            object o = p2;
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }
            else
            {
                Console.WriteLine("Not match!");
            }
            StaticMembersOfObject();
            Console.ReadLine();
        }
        static void StaticMembersOfObject()
        {
            // Static members of System.Object.
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            object p5 = p4;
            Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
            Console.WriteLine("P3 and P4 are pointing to same object: {0}",
              object.ReferenceEquals(p5, p4));
        }
    }
}
