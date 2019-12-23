using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClass
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
            }
        }
    }

    public class User
    {
        private static List<string> listOfUserName { get; set; }
        public User()
        {
            if (listOfUserName == null)
                listOfUserName = new List<string>();
        }
        public void Add(string userName)
        {
            listOfUserName.Add(userName);
        }
        public object GetUsersCount()
        {
            return listOfUserName.Count;
        }
    }

}
