using System;
using System.Collections;
using System.Collections.Generic;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> a1 = new List <int> ();


            a1.Add(25);
            a1.Add(35);
            
                foreach (int i in a1)
                {
                    Console.WriteLine(i);
                }
            
            
        }
    }
}
