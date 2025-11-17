using System;

namespace ForPractice.Abstraction
{
    internal class ConcretePerson : Person1
    {
        public override void Detail()
        {
            Console.WriteLine($"Details - Id: {Id}, Name: {Name}, Age: {Age}, Birthday: {Birthday.ToString("dddd, dd MMMM yyyy")}");
        }
    }
}