using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionRoject.Methods
{
    internal class Reflector
    {
        internal delegate void GetTypeInfoDelegate(string info);

        public static void GetAllTypes(ArrayList arrayList)
        {
            Type type;
            foreach(var item in arrayList)
            {
                type = item.GetType();
                MemberGetter(type);
            }
        }

        private static void MemberGetter(Type type)
        {
            ArrayList members = new ArrayList();
            foreach (var item in type.GetMembers())
            {
                //Console.WriteLine($"{type}, {item.MemberType}, {item.Name}");
                GetTypeInfoEvent?.Invoke($"{type}, {item.MemberType}, {item.Name}");
            }
        }

        internal static event GetTypeInfoDelegate GetTypeInfoEvent;
    }
}
