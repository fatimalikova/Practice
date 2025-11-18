using ForPractice.Abstraction;
using ForPractice.Casting;
using ForPractice.Interface;

namespace ForPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UserRepo userRepo = new UserRepo();
            //userRepo.SendEmail();

            //IA ab = new AB();
            //ab.A();

            //IEat human = new Human();
            //human.Work(); // boxing
            //human.Eat();


            //Person designerEngineer = new DesignerEngineer();
            //designerEngineer.Name = "Alice";
            //designerEngineer.Age = 30;
            //designerEngineer.KnowledgeAreas = new string[] { "UI/UX", "Graphic Design" };
            //designerEngineer.Birthday = new DateTime(1993, 5, 15);
            //designerEngineer.Id = 1;
            //designerEngineer.DesignTool = "Figma";

            //DesignerEngineer designerEngineer = new DesignerEngineer();
            //designerEngineer.Id = 1;
            //designerEngineer.Name = "Alice";
            //designerEngineer.Age = 30;
            //designerEngineer.Birthday = new DateTime(1993, 5, 15);
            //designerEngineer.KnowledgeAreas = new string[] { "UI/UX", "Graphic Design" };
            //designerEngineer.DesignTool = "Figma";

            //ProgrammerEngineer programmerEngineer = new ProgrammerEngineer();
            //programmerEngineer.Id = 2;
            //programmerEngineer.Name = "Bob";
            //programmerEngineer.Age = 28;
            //programmerEngineer.Birthday = new DateTime(1995, 8, 22);
            //programmerEngineer.KnowledgeAreas = new string[] { "Backend Development", "Database Management" };
            //programmerEngineer.ProgrammingLanguage = "C#";

            //Person[] person = new Person[] { designerEngineer, programmerEngineer };
            ////DesignerEngineer engineer = (DesignerEngineer)person[0];
            //foreach(var item in person)
            //{
            //    DesignerEngineer engineer = item as DesignerEngineer;
            //    if (engineer != null)
            //    {
            //        engineer.DisplayInfo();
            //    }
            //    //if (item is DesignerEngineer engineer)
            //    //{
            //    //    DesignerEngineer engineer = (DesignerEngineer)item;
            //    //    engineer.DisplayInfo();
            //    //}
            //}



            ////foreach (var item in objects)
            ////{
            ////    item.DisplayInfo();
            ////} 

            ////Engineer engineer = new ProgrammerEngineer(); // Upcasting


            //ConcretePerson person = new ConcretePerson()
            //{
            //    Id = 1,
            //    Name = "John Doe",
            //    Age = 25,
            //    Birthday = new DateTime(2007, 8, 25)
            //};
            //person.Detail();

            ProgrammerEngineer programmerEngineer = new ProgrammerEngineer()
            {
                Id = 2,
                Name = "Jane Smith",
                Age = 30,
                Birthday = new DateTime(1993, 3, 15),
                ProgrammingLanguage = "C#"
            };
            ProgrammerEngineer anotherProgrammerEngineer = new ProgrammerEngineer()
            {
                Id = 3,
                Name = "Alice Johnson",
                Age = 28,
                Birthday = new DateTime(1995, 7, 10),
                ProgrammingLanguage = "Java"
            };

            ProgrammerEngineer[] programmers = new ProgrammerEngineer[] { programmerEngineer, anotherProgrammerEngineer };
            Array.Sort(programmers);
            foreach (var prog in programmers)
            {
                Console.WriteLine(prog);
            }
        }
    }
}
