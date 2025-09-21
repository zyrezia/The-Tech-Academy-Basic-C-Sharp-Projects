using System;

namespace Operators_Assignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static string operator ==(Employee EmpId1, Employee EmpId2)
        {
            // Compare employee id's if equal
            if (EmpId1.Id == EmpId2.Id)
            {
                // Employee id's are equal
                return "Equal";
            }

            // Employee id's are not equal
            return "Not Equal";
        }

        public static string operator !=(Employee EmpId1, Employee EmpId2)
        {
            if (EmpId1.Id != EmpId2.Id)
            {
                // Employee id's are not equal
                return "Not Equal";
            }

            // Employee id's are equal
            return "Equal";
        }
    }
}