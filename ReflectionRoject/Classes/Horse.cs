using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionRoject.Classes
{
    public class Horse
    {
        private string _name;

        private int _age;

        private bool _isMale;

        public int Age { get => _age; set => _age = value; }
        public bool IsMale { get => _isMale; set => _isMale = value; }
        public string Name { get => _name; set => _name = value; }

        public Horse(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }
    }
}
