using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    //All animals are described by age, name and sex.
    abstract class Animal 
    {
        private string name;        
        private int age;
        private char sex;
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name, int age, char sex)
            : this(name, age)
        {
            this.Sex = sex;
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 300)
                {
                    throw new ArgumentException("age range [0; 300]");
                }
                this.age = value;
            }
        }

        public char Sex
        {
            get { return this.sex; }
            protected set
            {
                if (value != 'M' && value != 'F')
                {
                    throw new ArgumentException("only M - male or F - female");
                }
                this.sex = value; 
            }
        }

        public static double CalcAverageAge(Animal[] arr)
        {
            double sum = 0;
            foreach (var animal in arr)
            {
                sum += animal.age;
            }
            return sum / (arr.Length);
        }
    }
}
