using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionRoject.Classes
{
    public class Plane
    {
        private int _countOfEngines;

        private int _countOfSeats;

        public int CountOfEngines { get => _countOfEngines; set => _countOfEngines = value; }
        public int CountOfSeats { get => _countOfSeats; set => _countOfSeats = value; }

        public Plane(int countOfEngines, int countOfSeats)
        {
            this.CountOfEngines = countOfEngines;
            this.CountOfSeats = countOfSeats;
        }
    }
}
