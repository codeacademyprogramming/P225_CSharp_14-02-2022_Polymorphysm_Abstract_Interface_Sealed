using System;
using System.Collections.Generic;
using System.Text;

namespace P225Abstract
{
    class Student : Human 
    {
        public override string Info()
        {
            return $"{Name} {SurName} {Age} {IsMarred}";
        }
    }
}
