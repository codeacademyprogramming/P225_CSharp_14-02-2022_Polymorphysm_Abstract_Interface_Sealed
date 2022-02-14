using System;
using System.Collections.Generic;
using System.Text;

namespace P225Abstract
{
    abstract class Human:IMove
    {
        public string Name;
        public string SurName;
        public int Age;
        public bool IsMarred;

        public string Test { set => throw new NotImplementedException(); }

        public abstract string Info();

        public string Move()
        {
            return "human";
        }

        //public abstract string Move();
        //public abstract string Move(string a);
    }
}
