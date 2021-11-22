using System;
using System.Collections.Generic;
using System.Text;

namespace generics
{
    class stack<T>
    { 
    public T[] ar;
    int top;
    public stack(int n)
    {
        ar = new T[n];
        top = -1;
    }
    public void push(T x)
    {
            if(top==5)
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                top = top + 1;
                ar[top] = x;
                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    Console.WriteLine("Enter the data");
                    if (typeof(T).Name.Equals("Int32"))
                        ar[i] = (dynamic)Int32.Parse(Console.ReadLine());
                    if (typeof(T).Name.Equals("Int64"))//long
                        ar[i] = (dynamic)Int64.Parse(Console.ReadLine());
                    if (typeof(T).Name.Equals("Int16"))//short
                        ar[i] = (dynamic)Int16.Parse(Console.ReadLine());
                }

            }
        }

     public void pop(T x)
     {
           if(top==-1)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                top=top-1;
            }
     }
    
    public void show()
    {
        for (int i = 0; i < ar.GetLength(0); i++)
        {
            Console.WriteLine("{0}", ar[i]);

        }
    }

}
    class Program2
    {

        static void Main(string[] args)
        {
            stack<short> s1 = new stack<short>(5);
            //s1.input();
            s1.push(25);
            s1.push(63);
            s1.show();
            s1.pop(25);
            s1.show();        


        }
    }
}