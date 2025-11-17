using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPractice.Casting
{
    internal class DesignerEngineer : Engineer
    {
        public string DesignTool { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, Birthday: {Birthday.ToShortDateString()}, Design Tool: {DesignTool}");
        }
    }

}
