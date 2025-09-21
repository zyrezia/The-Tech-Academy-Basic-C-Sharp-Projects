using System;

namespace Polymorphism_Assignment
{
    public abstract class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public abstract void SayName();
    }
}
