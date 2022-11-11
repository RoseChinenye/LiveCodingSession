using System;

namespace MyConsoleApp
{
    internal class LibraryManagement
    {
        public static void Library()
        {
            bool BookOptions = true;
            while (BookOptions)
         
            {
                Console.WriteLine("Choose an option to see available books from c, o, d and e");
                string Case = Console.ReadLine().ToUpper();
                switch (Case)
                { 
                    case "C":
                        Console.WriteLine("C# books");
                        break;
                    case "O":
                        Console.WriteLine(".NET books");
                        break;
                    case "D":
                        Console.WriteLine("Clean Code Books");
                        break;
                    case "E":
                        Console.WriteLine("EFCore Books");
                        break;
                    default:
                        Console.WriteLine("Try again Later...");
                        break;
                     
                }
            }
        }
    }
}
