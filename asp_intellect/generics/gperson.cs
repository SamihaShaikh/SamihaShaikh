using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class gperson
    {
        static void Main(String[] args)
        {
            person p1 = new person();
            mycollection<person> cm = new mycollection<person>();
            cm.add(p1);
            cm.show();
            
            Console.Read();
        }
    }
    class person
    {
        public string name;
        public int age;

         
        public person()
        {
            Console.WriteLine("enter name");
             name = Console.ReadLine();

            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
            
        }

        public void setdata()
        {
            Console.Write("NAME :"+name);
            Console.WriteLine("AGE :"+age);
        }
    }

    class mycollection<T>
    {
        List<T> lst = new List<T>();

        public void add(T obj)
        {
            lst.Add(obj);
        }

        public void remove(T obj)
        {
            lst.Remove(obj);
        }

        public void show()
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (typeof(T).Name.Equals("person"))
                {
                    person ps = (dynamic)lst[i];
                    ps.setdata();
                }
            }
        }
    }


}
