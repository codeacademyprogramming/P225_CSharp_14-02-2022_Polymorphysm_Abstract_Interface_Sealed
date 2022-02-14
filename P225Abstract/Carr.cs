using System;
using System.Collections.Generic;
using System.Text;

namespace P225Abstract
{
    class Carr : Student,IMove, IRun
    {

        public string Move()
        {
            return "Test";
        }

        public void Run()
        {
            Console.WriteLine("Qacis");
        }
    }
}
