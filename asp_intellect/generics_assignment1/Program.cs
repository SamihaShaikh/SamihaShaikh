using System;
using System.Collections;
using System.Collections.Generic;


namespace generics_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            genericcollection();
            Console.Read();
        }

        public static void genericcollection()
        {
            string[] cust1 = new string[] {"samiha","30","samiha@gmail.com" ,"7418529631"};
            string[] cust2 = new string[] { "Arpita", "20", "arpita@gmail.com","7412589630"};
            string[] cust3 = new string[] { "Arjun", "50", "arjun@gmail.com","8523697410" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

            dict.Add(1,cust1);
            dict.Add(2,cust2);
            dict.Add(3,cust3);


            foreach(var value in dict)
            {
                string[] custinfo = value.Value;

                foreach(var cust in custinfo)
                {
                    Console.WriteLine(cust);
                }
                
            }

        }
    }
}
