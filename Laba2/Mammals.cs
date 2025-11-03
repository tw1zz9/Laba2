using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Mammals: Animals
    {
        private const string _defaultPrefix = "Mammal:";
        
        protected Dermis Skin = Dermis.Fur;

        public Mammals(): base() { }
        public Mammals(string name, int age = _defaultAge) : base(_defaultPrefix, age) 
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
                if (value < 0 || value > 200) return;
                base.Age = value;
            }
        }

        public override string Descrition()
        {
            return new string($"{Name}, Age of {Age}, covered in {Skin}");
        }
        public override string Sound()
        {
            return "Mammals can make a loud \"ROAR\" sound";
        }
        public override string ToString()
        {
            return "Type - Mammal";
        }
    }
}
