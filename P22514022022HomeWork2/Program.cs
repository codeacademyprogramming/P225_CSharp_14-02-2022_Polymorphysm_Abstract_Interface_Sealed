using System;
using P22514022022HomeWork2.Models;

namespace P22514022022HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Zavod Coreyi");
            product.Count = 5;
            product.Price = 0.5;

            //Console.WriteLine(product.Count);
            //Console.WriteLine(product.TotalIncome);
            //product.Sell();
            //Console.WriteLine(product.Count);
            //Console.WriteLine(product.TotalIncome);
            //product.Sell();
            //Console.WriteLine(product.Count);
            //Console.WriteLine(product.TotalIncome);
            //product.Sell();
            //Console.WriteLine(product.Count);
            //Console.WriteLine(product.TotalIncome);
            //product.Sell();
            //Console.WriteLine(product.Count);
            //Console.WriteLine(product.TotalIncome);
            //product.Sell();
            //Console.WriteLine(product.Count);
            //Console.WriteLine(product.TotalIncome);
            //product.Sell();
            //Console.WriteLine(product.Count);
            //Console.WriteLine(product.TotalIncome);

            Milk milk = new Milk("milla");
            milk.Count = 3;
            milk.Price = 2;
            Console.WriteLine(milk.Count);
            Console.WriteLine(milk.TotalIncome);
            milk.Sell();
            Console.WriteLine(milk.Count);
            Console.WriteLine(milk.TotalIncome);
            milk.Sell();
            Console.WriteLine(milk.Count);
            Console.WriteLine(milk.TotalIncome);
        }
    }
}
