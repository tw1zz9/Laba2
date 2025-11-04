using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public sealed class Tiger: Mammals
    {
        public Tiger(): base() { }
        public Tiger(string name, int age): base(name, age) { }

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
            => base.Descrition() + "\n\tTigers are bigger and stronger that Lions, but they don`t have a crown..";

        public override string Sound() => base.Sound() + "Tiger are really LOUD!";

        public override string ToString() => "Type - Tiger\n" + Descrition();
    }
}
