using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public sealed class Crocodile: Mammals
    {
        public Crocodile() : base() 
        {
            base.Skin = Dermis.Scales;
        }
        public Crocodile(string name, int age) : base(name, age) 
        { 
            base.Skin = Dermis.Scales; 
        }

        public override string Descrition()
        {
            return base.Descrition() + "\n\tCrocodile is queit.. but deadly";
        }

        public override string Sound()
        {
            return base.Sound() + "\n\tCrocodiles sound like a loud car engine! This is crazy..";
        }

        public override string ToString()
        {
            return "Type - Crocodile\n" + Descrition();
        }
    }
}
