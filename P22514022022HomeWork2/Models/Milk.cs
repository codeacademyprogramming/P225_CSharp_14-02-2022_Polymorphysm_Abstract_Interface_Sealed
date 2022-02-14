using System;
using System.Collections.Generic;
using System.Text;

namespace P22514022022HomeWork2.Models
{
    class Milk : Product
    {
        public double Volume { get; set; }
        public double FatRate { get; set; }

        public Milk(string name) : base(name)
        {
        }
    }
}
