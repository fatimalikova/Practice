using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForPractice.Casting
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public DateTime Birthday { get; set; }


        public Person(int id, string name, int age, DateTime birthday)
        {
            Id = id;
            Name = name;
            Age = age;
            Birthday = birthday;
        
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, Birthday: {Birthday.ToShortDateString()}");
        }
        public Person() { }
    }
}
