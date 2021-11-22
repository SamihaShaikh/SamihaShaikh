using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq
{
    class p3
    {
        public static void Main()
        {
            List<student> studentlist = new List<student>()
            {
                new student(){sid=1,sname="jiya",age=13},
               new student(){sid=2,sname="Minaal",age=21},
               new student(){sid=3,sname="Barira",age=18},
                new student(){sid=4,sname="Rameen",age=21},
                new student(){sid=5,sname="Rakib",age=18}
            };

            Console.WriteLine("Query method");
            var grpres = from s in studentlist group s by s.age;
            foreach(var agegrp in grpres)
            {
                Console.WriteLine("Age Group ::{0}", agegrp.Key);

                foreach(student s in agegrp)
                {
                    Console.WriteLine("Student Name:: {0} ",s.sname);
                }
            }


            Console.WriteLine("Lambda Expression");
            var grpres2 = studentlist.GroupBy(s => s.age);
            foreach(var agegrp in grpres2)
            {
                Console.WriteLine("Age Group ::{0} ", agegrp.Key);

                foreach(student s in agegrp)
                {
                    s.show();
                }
            }







        }
    }
}

public class student
{
    public int sid { get; set; }
    public string sname { get; set; }
    public int age { get; set; }
    public void show()
    {
        Console.WriteLine("{0} {1} {2}", sid, sname, age);
    }
}