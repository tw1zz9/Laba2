using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Birds: Animals
    {
        private const string _defaultPrefix = "Bird: ";
        private readonly Dermis Skin = Dermis.Feathers;

        private string _realName;

        public Birds() : base() { }
        public Birds(string name, int age = _defaultAge) : base(_defaultPrefix, age) 
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
                _realName = value;
            }
        }

        public override int Age 
        {
            get => base.Age;
            set
            {
                if (value < 0 || value > 122) return;
                base.Age = value;
            }
        }

        public override string Descrition()
        {
            return $"Bird: {_realName}, age of {Age}, covered in {Skin}";
        }
        public override string Sound()
        {
            return "Birds can make a lot of sound, like \"CAAWR!\"";
        }

        public override string ToString()
        {
            return "Type - Bird";
        }
    }
}
