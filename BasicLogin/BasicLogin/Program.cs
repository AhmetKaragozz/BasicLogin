using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin
{
    class BasicLogin
    {
        static void Main(string[] args)
        {

            string correctUsername = "admin";
            string correctPassword = "password";


            int loginAttempts = 3;


            Console.WriteLine("Please enter your username and password to login:");


            while (loginAttempts > 0)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();


                if (username == correctUsername && password == correctPassword)
                {

                    Console.WriteLine("Login is successful. Welcome!");
                    break;
                }
                else
                {
                    // The login was unsuccessful
                    loginAttempts--;
                    Console.WriteLine("Username or password wrong. " + loginAttempts + " attempts remain.");
                }
            }

            // If the user has run out of login attempts, exit the program
            if (loginAttempts == 0)
            {
                Console.WriteLine("Program is shuttingdown.");
            }
        }
    }
}