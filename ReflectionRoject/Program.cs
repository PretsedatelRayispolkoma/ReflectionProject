using ReflectionRoject.Classes;
using System.Collections;
using System.Reflection;
using ReflectionRoject.Methods;

Car car = new Car("BMW", "5-Series", 3);
Horse horse = new Horse("Apple", 5, false);
Plane plane = new Plane(2, 20);
Truck truck = new Truck("Volvo", "FH16", 44, true);

ArrayList vehicles = new ArrayList();
vehicles.Add(car);
vehicles.Add(horse);
vehicles.Add(plane);
vehicles.Add(truck);

Reflector.GetTypeInfoEvent += ShowMessage;
Reflector.GetAllTypes(vehicles);

static void ShowMessage(string message)
{
    Console.WriteLine(message);
}
