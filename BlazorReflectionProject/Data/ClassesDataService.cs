using ReflectionRoject.Classes;
using System.Collections;

namespace BlazorReflectionProject.Data
{
    public class ClassesDataService
    {
        public static ArrayList GetTheArray()
        {
            ArrayList arrayList = new ArrayList();
            Car car = new Car("BMW", "5-Series", 3);
            Horse horse = new Horse("Apple", 5, false);
            Plane plane = new Plane(2, 20);
            Truck truck = new Truck("Volvo", "FH16", 44, true);
            arrayList.Add(car);
            arrayList.Add(horse);
            arrayList.Add(plane);
            arrayList.Add(truck);

            return arrayList;
        }
    }

}
