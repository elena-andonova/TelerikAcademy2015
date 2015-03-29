using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    //Define abstract class Human with a first name and a last name.
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }
        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }
    }
}
