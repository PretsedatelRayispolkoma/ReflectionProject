using Microsoft.AspNetCore.Components;
using ReflectionRoject.Classes;
using System.Collections;

namespace BlazorReflectionProject.Data
{
    public class ArrayListComponent : ComponentBase
    {
        public static ArrayList Vehicles { get; set; }
        Truck truck = new Truck("Mersedis", "Actros", 45, true);
        Horse horse = new Horse("Apple", 5, false);
        public static List<string> messages;

        protected override Task OnInitializedAsync()
        {
            Vehicles = new ArrayList();
            Vehicles.Add(horse);
            Vehicles.Add(truck);

            messages = new List<string>();

            ReflectionRoject.Methods.Reflector.GetTypeInfoEvent += ReturnString;
            ReflectionRoject.Methods.Reflector.GetAllTypes(Vehicles);

            return base.OnInitializedAsync();

        }

        private static void ReturnString(string message)
        {
            messages.Add(message);
        }
    }
}
