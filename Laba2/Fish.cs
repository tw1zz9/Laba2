using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Fish : Animals
    {
        private const string _defaultPrefix = "Fish:";
        
        protected Dermis Skin = Dermis.Scales;

        public Fish() : base() { }
        public Fish(string name, int age = _defaultAge) : base(_defaultPrefix, age)
        {
            Name = name;
            Age = age;
        }

        public override string Name
        {
            get => base.Name;
            set
            {
                if (string.IsNullOrEmpty(value) || base.Name.Contains(value)) value = _defaultName;
                base.Name = $"{_defaultPrefix} {value}";
            }
        }
        public override int Age
        {
            get => base.Age;
            set
            {
                if (value < 0 || value > 500) return;
                base.Age = value;
            }
        }

        public override string Descrition()
        {
            return $"{Name}, Age of {Age}, covered in {Skin}";
        }
        public override string Sound()
        {
            return "Fish don`t make sounds, they are busy swiming";
        }
        public override string ToString()
        {
            return "Type - Fish";
        }
    }
}
