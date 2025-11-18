using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPractice.Interface
{
    internal interface IRepo
    {
        void Create();
        void Update();
        void Delete();
        void GetAll();
        void GetById();
       
    } 
    internal interface IEmail
    {
        void SendEmail();
    }

    public class UserRepo : IRepo, IEmail
    {
        public void Create()
        {
            throw new NotImplementedException();
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }
        public void GetAll()
        {
            throw new NotImplementedException();
        }
        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
        public void SendEmail()
        {
            Console.WriteLine("Email sent");
        }
    }

    interface IWork
    {
        void Work();
        
    }
    interface IEat
    {
        void Eat();
    }

    class Human : IWork, IEat
    {
        public void Work()
        {
            Console.WriteLine("Human is working");
        }
        public void Eat()
        {
            Console.WriteLine("Human is eating");
        }
    }

    class Robot : IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }

    }

    interface IA
    {
        void A();
    }
    interface IB
    {
        void A();
    }

    class AB : IA, IB
    {
        void IA.A()
        {
            Console.WriteLine("Interface A method implementation");
        }
        void IB.A()
        {
            Console.WriteLine("Interface B method implementation");
        }
    }

    public interface Class1
    {
        public int MyProperty { get; set; }
        public void Worker();
    }

    public abstract class CLass2
    {
        public int MyProperty { get; set; }
        public abstract void Worker();
    }

    class Class : Class1
    {
        public int MyProperty {get =>throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void Worker()
        {
            Console.WriteLine("Worker method implementation");
        }
    }
}
