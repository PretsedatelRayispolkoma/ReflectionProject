using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionRoject.Classes
{
    public abstract class AutoMobile
    {
        private string _brand;

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }

        private string _model;

        public AutoMobile(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
    }
}
