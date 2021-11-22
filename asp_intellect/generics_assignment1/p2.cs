using System;
using System.Collections.Generic;
using System.Text;

namespace generics_assignment1
{
    class p2
    {
        static void Main(string[] args)
        {
            customcollection();
            Console.Read();
        }


        public static void customcollection()
        {
            List<user> users = new List<user>();
            users.Add(new user { userid = 1, name = "samiha", age = 21, email = "sami@gmail.com" });
            users.Add(new user { userid = 2, name = "ridhima", age = 18, email = "ridhima@gmail.com" });
            users.Add(new user { userid = 3, name = "abhay", age = 15, email = "abhay@gmail.com" });
            foreach (var user in users)
            {
                Console.WriteLine(string.Format("NAME : {0} AGE : {1} EMAIL:{2}", user.name, user.age, user.email));
            }

        }
    }
}

public class user
{
    public int userid { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public string email { get; set; }
}
