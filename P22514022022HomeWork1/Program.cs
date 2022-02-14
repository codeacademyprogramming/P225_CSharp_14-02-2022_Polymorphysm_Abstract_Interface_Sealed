using System;

namespace P22514022022HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserName Daxil Et");
            string username = Console.ReadLine();

            Console.WriteLine("Passwordu Daxil Et");
            string passsword = Console.ReadLine();

            User user = new User(username);
            user.Password = passsword;

            Console.WriteLine("Duzgundur");
        }
    }
}
