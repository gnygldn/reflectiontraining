using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Assembly Name: " + assembly.GetName().Name);
            Console.WriteLine("Version: " + assembly.GetName().Version.ToString());
            var assembly2 =
                Assembly.LoadFile(
                    "C:/Users/gnygl/Desktop/projects/currencyhelper/gnygldn.currencycalculator/gnygldn.currencycalculator/bin/Debug/gnygldn.currencycalculator.exe");
            var types = assembly2.GetTypes();
            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                Console.WriteLine("Type " + type.FullName + " has " + typeInfo.DeclaredProperties.Count().ToString() + " properties");
            }


            Console.ReadKey();
        }
    }
}
