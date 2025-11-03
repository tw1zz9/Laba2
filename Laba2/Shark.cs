using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public sealed class Shark: Fish
    {
        private const string _defaultPrefix = "Shark: ";

        private readonly double _defaultWeight = 0;
        private readonly double _defaultLength = 0;

        private double _weight;
        private double _length;
        
        public double Weight
        {
            get => _weight;
            set
            {
                if (value < 0) value = _defaultWeight;
                _weight = value;
            }
        }

        public double Length
        {
            get => _length;
            set
            {
                if (value < 0) value = _defaultLength;
                _length = value;
            }
        }

        public override string Name
        {
            get => base.Name;
            set
            {
                if (string.IsNullOrEmpty(value)) value = _defaultName;
                base.Name = value;
            }
        }

        public Shark(): base()
        {
            Weight = _defaultWeight;
            Length = _defaultLength;
        }

        public Shark(string name, int age, double weight, double length): base(_defaultPrefix + name, age)
        {
            Weight = weight;
            Length = length;
        }

        public override string Descrition()
            => $"Fish: {Name}, age of {Age}, covered in placoid {Skin}\n\tWeight: {Weight} kg, Length: {Length} m";
        public override string Sound() 
        => "Fish don`t make sounds, they are busy swiming.\n\tAnd Sharks can kill you, you know..";
        public override string ToString() => "Type - Shark";
    }
}
