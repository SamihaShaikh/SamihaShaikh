using System;
using System.Collections.Generic;
using System.Text;

namespace dlegates
{
    public delegate void mydel(int x,int y);
    class dif_class_multicast_delegate
    {

        static void Main(string[] args)
        {
            mydel d1 = new mydel(mymaths.add);
            d1.Invoke(10, 20);
            d1 += new mydel(mymaths.div);
            d1 += new mydel(mymaths.mul);
            d1 += new mydel(mymaths.sub);
            d1.Invoke(30, 5);
            d1 -= new mydel(mymaths.mul);
            d1.Invoke(20, 5);
            mydel d2 = new mydel(mymaths.add);
            mydel d3 = new mydel(mymaths.sub);
            mydel d4 = d2 + d3;
            d4.Invoke(10, 5);
            Console.Read();


        }

    }

    class mymaths
    {
        public static void add(int x,int y)
        {
            Console.WriteLine("ADDITION ====={0}", x + y);
        }

        public static void mul(int x,int y)
        {
            Console.WriteLine("MULTIPLICATION============{0}", x * y);
        }

        public static void div(int x, int y)
        {
            Console.WriteLine("DIVISION============{0}", x / y);
        }

        public static void sub(int x, int y)
        {
            Console.WriteLine("SUBTRACTION============{0}", x - y);
        }


    }
}
