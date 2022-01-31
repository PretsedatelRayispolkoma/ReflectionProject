using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionRoject.Classes
{
    public class Car : AutoMobile
    {

        public double EngineCapacity { get => _engineCapacity; set => _engineCapacity = value; }

        private double _engineCapacity;

        public Car(string name, string model, double engineCapacity) : base(name, model)
        {
            this.EngineCapacity = engineCapacity;
        }
    }
}
