using System;
using System.Collections.Generic;
using System.Text;

namespace dlegates
{
    class sorting_delegate
    {
        public delegate bool compare(person p1, person p2);
        static void main(string[] args)
        {
            person[] p = new person[3];
            for(int i=0;i<p.Length;i++)
            {
                p[i] = new person();
                p[i].input();
            }
            compare c1 = new compare(person.chkage);
            sort(p, c1);

            Console.WriteLine("SORTING AGE WISE");

            for(int i = 0; i < p.Length; i++)
            {
                p[i].show();
            }


             c1 = new compare(person.chkincome);
            sort(p, c1);

            Console.WriteLine("SORTING INCOME  WISE");

            for (int i = 0; i < p.Length; i++)
            {
                p[i].show();
            }


            c1 = new compare(person.chkname);
            sort(p, c1);

            Console.WriteLine("SORTING NAME WISE");

            for (int i = 0; i < p.Length; i++)
            {
                p[i].show();
            }

        }


        public static void sort(person[] p,compare c)
        {
            for (int i=0;i<p.Length;i++)
            {
                for(int j=i+1;j<p.Length;j++)
                {
                    if(c.Invoke(p[i],p[j]))
                    {
                        person temp = p[i];
                        p[i] = p[j];
                        p[j] = temp;
                    }
                }
            }
        }
    }

    class person
    {
        public int income, age;
        public string name;

        public person()
        {
            name = "";
            income = age = 0;
        }

        public person(int income,int age,string name)
        {
            this.name = name;
            this.age = age;
            this.income = income;
        }

        public void input()
        {
            Console.WriteLine("enter name ,age ,income::");
            name = Console.ReadLine();
            age = Int16.Parse(Console.ReadLine());
            income = Int32.Parse(Console.ReadLine());
        }

        public void show()
        {
            Console.WriteLine("{0} {1} {2}", name, age, income);
        }

        public static bool chkage(person p1,person p2)
        {
            if(p1.age>p2.age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool chkincome(person p1, person p2)
        {
            if (p1.income > p2.income)
     
                return true;
            
            else
            
                return false;
            
        }

        public static bool chkname(person p1, person p2)
        {
            if (p1.name.CompareTo(p2.name)>0)
            
                return true;
            
            else
            
                return false;
            
        }
    }

}
