using System;
using System.Collections.Generic;
using System.Text;

namespace dlegates
{
    public delegate int mydel1(int x, int y);
    class oneclass_multicast_delegate
    {
        static void Main(string[] args)
        {
            mydel1 d = new mydel1(add);
            Console.WriteLine("ADDITION::{0}", d.Invoke(20, 2));
            mydel1 d1 = new mydel1(sub);
            Console.WriteLine("SUBTRACTION::{0}", d1.Invoke(20, 2));
            mydel1 d2 = new mydel1(mul);
            Console.WriteLine("MULTIPLICATION::{0}", d2.Invoke(20, 2));
            mydel1 d3 = new mydel1(div);
            Console.WriteLine("DIVISION::{0}", d3.Invoke(20, 2));
            Console.Read();
        }

        public static int add(int x,int y)
        {
            return x + y;
        }

        public static int mul(int x, int y)
        {
            return x * y;
        }

        public static int div(int x, int y)
        {
            return x / y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
    }
}
