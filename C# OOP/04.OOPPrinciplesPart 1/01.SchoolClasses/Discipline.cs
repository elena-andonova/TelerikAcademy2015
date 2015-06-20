using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Discipline
    {
        private string name;
        private uint numberOfLectures;
        private uint numberOfExercises;

        public Discipline(string name, uint lect, uint exer)
        {
            this.Name = name;
            this.NumberOfLectures = lect;
            this.NumberOfExercises = exer;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public uint NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }

        public uint NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }  
            
    }
}
