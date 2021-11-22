using System;
using System.Collections.Generic;
using System.Text;

namespace dlegates
{
    public delegate void mydel2(string msg);

    class string_delegate
    {

        static void main(string[] args)
        {
            mydel2 d4 = new mydel2(mylower);
            d4.Invoke("anika");
            mydel2 d5 = new mydel2(myupper);
            d5.Invoke("richa");
            mydel2 d6 = new mydel2(myrev);
            d6.Invoke("niharika");

        }
        



        static void mylower(string msg)
        {
            Console.WriteLine("{0}", msg.ToLower());
        }

        static void myupper(string msg)
        {
            Console.WriteLine("{0}", msg.ToUpper());
        }
        static void myrev(string msg)
        {
            string rev = "";
            for (int i = msg.Length - 1; i >= 0; i--)
                rev = rev + msg.Substring(i, 1);
            Console.WriteLine("{0}", rev);
        }

    }
}
