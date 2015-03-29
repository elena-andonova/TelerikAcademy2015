using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class School
    {
        private string schoolName;
        private List<SchoolClass> schoolClasses;

        public School(string name)
        {
            this.SchoolName = name;
            this.SchoolClasses = new List<SchoolClass> { };
        }
        public string SchoolName
        {
            get { return this.schoolName; }
            private set { this.schoolName = value; }
        }

        public List<SchoolClass> SchoolClasses
        {
            get { return this.schoolClasses; }
            set { this.schoolClasses = value; }
        }
    }
}
