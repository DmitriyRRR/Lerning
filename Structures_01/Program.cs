using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { name = "Tom", age = 23 };
            Person p2 = new Person { name = "Tom2", age = 22 };
            Console.WriteLine(p.name); // Tom

            ChangePerson(p);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23

            Console.Read();
        }

        static void ChangePerson(Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }
    }
    class Person
    {
        public string name;
        public int age;
    }
    /* class Program
   {
       private static void Main(string[] args)
       {
           State state1 = new State(); 
           State state2 = new State();

           state2.country = new Country();
           state2.country.x = 5;
           state2.country.y = 5;
           state2.x = 22;
           state1 = state2;
           state1.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country
                               // указывают на один объект в хипе
           Console.WriteLine(state1.country.x); // 8
           Console.WriteLine(state2.country.x); // 8
           Console.WriteLine(state2.country.y); // 8
           Console.WriteLine(state1.x); // 8
           Console.WriteLine(state2.x); // 8

           Console.Read();
       }
   }
   struct State
   {
       public int x;
       public int y;
       public Country country;
   }
   class Country
   {
       public int x;
       public int y;
   }*/
}
