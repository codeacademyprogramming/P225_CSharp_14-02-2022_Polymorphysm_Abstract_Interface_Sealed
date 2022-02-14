using System;

namespace P225Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher teacher = new Teacher();

            //Student student = new Student();
            //student.Name = "Ismayil";
            //student.SurName = "Cabbarli";
            //student.Age = 21;
            //student.IsMarred = false;

            //Console.WriteLine(student.Info());

            //Mentor mentor = new Mentor();

            //Employee employee = new Employee();
            //Human human = new Human();

            Carr carr = new Carr();
            Console.WriteLine(carr.Move());

            Student student = new Student();
            Console.WriteLine(student.Move());

            Developer developer = new Developer();
        }
    }
}
