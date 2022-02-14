using System;
using System.Collections.Generic;
using System.Text;

namespace P225polymorphysm
{
    class Teacher : Human
    {
        public string Subject;
        public int Experiance;

        public override string Info()
        {
            return $"{Name} {SurName} {Age} {IsMarred} {Subject} {Experiance}";
        }
    }
}
