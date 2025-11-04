using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public sealed class Owl : Birds
    {
        public Owl(): base() { }
        public Owl(string name, int age) : base("Owl: " + name) { }

        public override string Name
        {
            get => base.Name;
            set
            {
                if (string.IsNullOrEmpty(value) || base.Name.Contains(value)) value = _defaultName;
                base.Name = value;
            }
        }

        public override string Descrition()
        {
            return base.Descrition() + "\n\tOwls can rotate their heads in 360 degrees!";
        }

        public override string Sound()
        {
            return "Owls create a \"U-U, U-U\" low-pitched sound";
        }

        public override string ToString()
        {
            return "Type - Owl\n" + Descrition();
        }
    }
}
