using System;

namespace MyConsoleApp
{
    public static class AuthenticationSystem
    {
         internal static void BasicAuthentication()
        {

                //Registering the user
                Console.WriteLine("Enter Your Username");
                string username = Console.ReadLine().ToLower();

                Console.WriteLine("Enter your password");
                string Password = Console.ReadLine();

                //Logging in the user
                Console.WriteLine("Enter username to login");
                string userName = Console.ReadLine().ToLower();
                    if (userName == username)
                    {
                        Console.WriteLine("Enter your password:");
                     
                    }
                    else
                    {
                        Console.WriteLine("Enter your correct username: ");
                    }

                    string userPassword = Console.ReadLine();
                    {
                        if (userPassword == Password && userName == username)
                        {
                            Console.WriteLine($"Your Login was Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Enter a correct password");
                        }
                    }


            }
            
        }
}
