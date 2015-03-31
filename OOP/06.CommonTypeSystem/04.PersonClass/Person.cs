using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonClass
{
    //Problem 4. Person class

    //Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
    //Write a program to test this functionality.

    class Person
    {
        private string name;
        private uint? age;

        public Person(string name, uint? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public uint? Age
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format(@"
Name: {0}
Age: {1}",
         this.Name, this.Age.HasValue ? this.Age.ToString() : "Not specified");
        }
    }
}
