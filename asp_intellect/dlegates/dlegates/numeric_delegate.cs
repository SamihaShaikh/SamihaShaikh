using System;
using System.Collections.Generic;
using System.Text;

namespace dlegates
{
    public delegate void mynumberdel(int n);
    class numeric_delegate
    {
        static void main(string[] args)
        {
            mynumberdel d1 = new mynumberdel(square);
            mynumberdel d2 = new mynumberdel(cube);
            mynumberdel d3 = new mynumberdel(fact);
            mynumberdel d4 = new mynumberdel(rev);
            mynumberdel d5 = d1 + d2 + d3 + d4;
            d5.Invoke(5);
            Console.Read();

        }

        static void square(int n)
        {
            Console.WriteLine("square is::", n * n);
        }

        static void cube(int n)
        {
            Console.WriteLine("cube is ::", n * n * n);
        }

        static void fact(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
                f = f * i;
            Console.WriteLine("factorial is ::", f);
        }
         static void rev(int n)
        {
            int r, rev = 0;
            while(n>0)
            {
                r = n % 10;
                n = n / 10;
                rev = rev * 10 + r;
            }
            Console.WriteLine("Reverse of number is  ::  ", rev);
        }
    }
}
