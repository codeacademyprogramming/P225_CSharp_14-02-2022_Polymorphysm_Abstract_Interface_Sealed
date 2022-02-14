using System;

namespace P225polymorphysm
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "Hamid";
            teacher.SurName = "Mammadov";
            teacher.Age = 31;
            teacher.IsMarred = true;
            teacher.Subject = "Programming";
            teacher.Experiance = 1;

            teacher.Info();
        }
    }
}
