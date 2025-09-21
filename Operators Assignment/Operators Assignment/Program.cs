using System;

namespace Operators_Assignment
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            string compare;

            // Set employee id's
            employee1.Id = 1000;
            employee2.Id = 100;

            // Compare 2 employees
            compare = employee1 == employee2;
            // Display comparison result
            Console.WriteLine(compare);
            Console.ReadLine();
        }
    }
}
