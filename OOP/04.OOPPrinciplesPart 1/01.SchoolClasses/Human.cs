using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        protected string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        protected string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }
    }
}
