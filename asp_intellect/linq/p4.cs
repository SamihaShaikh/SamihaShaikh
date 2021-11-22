using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq
{
    class p4
    {
        public static void Main()
        {
            List<student> studentlist = new List<student>()
            {
                new student(){sid=1,sname="jonita",age=13 },
                new student(){sid=1,sname="maliha",age=13 },
                new student(){sid=1,sname="basim",age=13 },
                new student(){sid=1,sname="Ramiya",age=13 },
                new student(){sid=1,sname="Ridhima",age=13 }
            };

            var dt = from s in studentlist orderby s.sname descending select s;
            Console.WriteLine("Query Method");
            foreach(student std in dt)
            {
                Console.WriteLine(std.sname);
            }

            var dt1 = studentlist.OrderBy(s => s.sname);
            Console.WriteLine("Lambda Expression");
            foreach(student std in dt1)
            {
                Console.WriteLine(std.sname);
            }

            var dt2 = studentlist.OrderByDescending(s => s.sname);
            Console.WriteLine("Lambda Expression");
            foreach(student std in dt2)
            {
                Console.WriteLine(std.sname);
            }
        }
    }
}

