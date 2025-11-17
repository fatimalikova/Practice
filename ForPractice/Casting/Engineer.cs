using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPractice.Casting
{
    internal class Engineer : Person
    {
        public string[] KnowledgeAreas { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, Birthday: {Birthday.ToShortDateString()}, Knowledge Area: {KnowledgeAreas}");
        }
    }
}
