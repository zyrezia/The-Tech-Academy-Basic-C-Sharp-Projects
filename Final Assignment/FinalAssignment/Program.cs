using System;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

            Console.Write("Student saved successfully!");
            Console.ReadLine();
        }
    }
}
