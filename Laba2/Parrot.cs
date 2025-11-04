using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public sealed class Parrot : Birds
    {
        public Parrot(): base() { }
        public Parrot(string name, int age) : base(name, age) { }

        public override string Descrition()
        {
            return base.Descrition() + "\n\tParrots van live up to 120 years!";
        }

        public override string Sound()
        {
            return base.Sound() + "\n\tParrots can mimic your voice!";
        }

        public override string ToString()
        {
            return "Type - Parrot\n" + Descrition();
        }
    }
}
