using System;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main()
        {
            IQuittable call = new Employee();

            call.Quit();
            Console.ReadLine();
        }
    }
}
