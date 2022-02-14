using System;
using System.Collections.Generic;
using System.Text;

namespace P225polymorphysm
{
    class Human
    {
        public string Name;
        public string SurName;
        public int Age;
        public bool IsMarred;

        public virtual string Info()
        {
            return $"{Name} {SurName} {Age} {IsMarred}";
        }
    }
}
