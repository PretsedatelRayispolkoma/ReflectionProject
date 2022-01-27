using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionRoject.Classes
{
    internal class Truck : AutoMobile
    {
        private double _capacity;

        private bool _doesHaveSemiTrailer;

        public double Capacity { get => _capacity; set => _capacity = value; }
        public bool DoesHaveSemiTrailer { get => _doesHaveSemiTrailer; set => _doesHaveSemiTrailer = value; }

        internal Truck(string brand, string model, double capacity, bool doesHaveTrailer) : base(brand, model)
        {
            this.Brand = brand;
            this.Model = model;
            this.Capacity = capacity;
            this.DoesHaveSemiTrailer = doesHaveTrailer;
        }
    }
}
