using System;

namespace Polymorphism_Assignment
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstname + " " + lastname);
        }

        public void Quit()
        {
            Console.WriteLine("The Quit method is called");
        }
    }
}
