using System;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Samiha","Reema","Abiha","Nitika","Minu"};
            var dt = from name in names where name.Contains('a') select name;

            foreach (var name in dt)
                Console.Write(name + " ");
            Console.Read();
        }
    }
}
