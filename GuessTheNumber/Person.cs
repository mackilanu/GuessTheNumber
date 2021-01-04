using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    class Person
    {
        private string name;
        private int age;

        public void printPerson()
        {
            Console.WriteLine("Hello " + name + ". Your age is " + age);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
    }
}
