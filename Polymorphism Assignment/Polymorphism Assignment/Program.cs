using System;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main()
        {
            // Create an object of type IQuittable
            IQuittable call = new Employee();

            //  Call the Quit() method
            call.Quit();
            Console.ReadLine();
        }
    }
}
