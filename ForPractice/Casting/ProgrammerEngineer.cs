using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPractice.Casting
{
    internal class ProgrammerEngineer : Engineer
    {
        public string ProgrammingLanguage { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, Birthday: {Birthday.ToShortDateString()}, Programming Language: {ProgrammingLanguage}");
        }
    }
}
