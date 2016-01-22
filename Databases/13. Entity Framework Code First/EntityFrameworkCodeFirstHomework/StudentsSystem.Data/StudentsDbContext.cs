namespace StudentsSystem.Data
{
    using Models;
    using System.Data.Entity;

    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext()
            :base("StudentsDb")
        {

        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }
    }
}
