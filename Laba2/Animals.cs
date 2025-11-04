using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{

    public abstract class Animals: IEquatable<Animals>
    {
        protected readonly string _defaultName = "Unknown";
        protected const int _defaultAge = 0;

        private string? _name;
        private int _age;

        // Конструкторы 
        public Animals()
        {
            Name = _defaultName;
            Age = _defaultAge;
        }
        public Animals(string _name, int _age): this()
        {
            Name = _name;
            Age = _age;
        }

        // Свойства класса
        public virtual string Name
        {
            get => _name ??= _defaultName;
            set
            {
                if (string.IsNullOrEmpty(value) || value == _name) return;
                _name = value;
            }
        }
        public virtual int Age
        {
            get => _age;
            set => _age = value;
        }

        public abstract string Descrition();

        public abstract string Sound();


        // Переписанные методы, наследованные от object 
        public override string ToString()
        {
            return "Type - Animal\n" + Descrition();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Animals);
        }

        public bool Equals(Animals? other)
        {
            return other != null && Name == other.Name && Age == other.Age;
        }
    }
}
