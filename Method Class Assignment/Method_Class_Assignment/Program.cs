using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate Method class
            Method process = new Method();

            int num1 = 10;
            int num2 = 10;

            // Calling a method in the Method class
            process.DoProcess(num1, num2);

        }
    }
}
