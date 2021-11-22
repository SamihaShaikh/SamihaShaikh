using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace linq
{
    class p2
    {
        public static void Main()
        {
            string[] names = {"Nidhi","Nirali","Abhinav","Anika","Manisha" };
            var dt = from name in names where name.StartsWith("N") select name;

            foreach(var name in dt)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine("\n lambda Expression");
            var dt2 = names.Where(s => s.StartsWith("N"));

            Console.WriteLine("Direct Print ::{0}", String.Join(",", dt2));
            foreach(var name in dt2)
            {
                Console.Write(name + " ");
            }


        }
    }
}
