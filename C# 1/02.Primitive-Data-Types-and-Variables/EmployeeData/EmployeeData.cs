using System;


namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string lastName = "Petkov";
            byte age = 32;
            char gender = 'm';
            long personalID = 8306112507;
            int employeeNum = 27569999;
            Console.WriteLine("The information for our single employee is:\n First Name:{0} \n Last Name:{1} \n Age:{2} \n Gender:{3} \n Personal ID:{4} \n Unique Employee Number:{5}",
                                firstName, lastName, age, gender, personalID, employeeNum);
        }
    }
}
