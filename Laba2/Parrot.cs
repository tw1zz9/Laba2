using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public sealed class Parrot : Birds
    {
        private const string _defaultPrefix = "Parrot: ";

        public Parrot(): base() { }
        public Parrot(string name, int age) : base(_defaultPrefix + name, age) { }

        public override string Name
        {
            get => base.Name;
            set
            {
                if (string.IsNullOrEmpty(value) || base.Name.Contains(value)) value = _defaultName;
                base.Name = _defaultPrefix + value;
            }
        }

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
            return "Type - Parrot";
        }
    }
}
