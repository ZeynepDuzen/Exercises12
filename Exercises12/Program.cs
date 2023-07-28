using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** match the username - password and login ***

            Heading();
            Login();

            Console.Read();
        }

        static void Heading()
        {
            Console.WriteLine("*** Welcome ***");
            Console.WriteLine();
        }

        static bool CheckTheUserInformation()
        {
            string dataUserName = "pamuk";
            string dataPassword = "123***123";

            Console.WriteLine("Please enter the user name : ");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter the password");
            string password = Console.ReadLine();

            if (dataUserName == userName && dataPassword == password)
            {
                return true;
            }
                return false;
        }

        static void Login()
        {
            bool result = CheckTheUserInformation();

            if (result)
            {
                Console.WriteLine("Your login is successful");
            }
            else
            {
                Console.WriteLine("Your login is incorrect");
            }
        }
    }
}
