using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public sealed class Lion : Mammals
    {
        public Lion() : base() { }
        public Lion(string name, int age) : base(name, age) { }

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
            return base.Descrition() + "\n\tLions are KINGS of the savanna!";
        }

        public override string Sound()
        {
            return base.Sound() + "\n\tLoin does ECXACTLY that!";
        }

        public override string ToString()
        {
            return "Type - Lion\n" + Descrition();
        }
    }
}
