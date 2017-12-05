using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingCustomAttributes;


namespace AttributeReflectionEarlyBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Value of VehicleDescriptionAttribute ***\n");
            ReflectOnAttributesUsingEarlyBinding();
            Console.ReadLine();
        }

        private static void ReflectOnAttributesUsingEarlyBinding()
        {
            // get a type representing the Winnebago
            Type t = typeof(Winnebago);

            // get all attributes on the Winnebago
            object[] customAtts = t.GetCustomAttributes(false);

            // print the description
            foreach(VehicleDescriptionAttribute v in customAtts)
            {
                Console.WriteLine($"-> {v.Description}\n");
            }
        }

    }
}
