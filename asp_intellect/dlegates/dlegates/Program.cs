using System;

namespace dlegates
{
    public delegate string strsub(int n1, int n2, string str);
    public delegate string stpali(string n);

    class Program
    {

        

        static void Main(string[] args)
        {
            strsub s1 = new strsub(strsub1);
            s1.Invoke(2, 4, "samiha");
         

            stpali s2 = new stpali(stpali1);
            s2.Invoke("sara");
            Console.Read();

        }


        public static string strsub1(int n1, int n2, string str)
        {
            string st = str.Substring(n1, n2);
            return st;
        }

        public static string stpali1(string n)
        {
            string rev="";
            int i=0;
            for (i = n.Length - 1; i > 0; i--)
            {
                rev = rev + n.Substring(0, 1);
            }

                if(n.CompareTo(rev)==0)
                {
                    return "palindrome";
                }
                else
                {
                    return "not a palindrome";
                }
            
        }
    }
}
