using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Static_Methods_and_Classes
{
    static internal class useFullTools
    {
        public static void sayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));
            useFullTools.sayHi("Moloko");
            Console.ReadLine();
        }
    }
}
