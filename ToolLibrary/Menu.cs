using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    class Menu
    {
        static string num1;
        static string num2;
        static string num3;
        static string staffUsername = "staff";
        static string staffPassword = "today123";
        static void Main(string[] args)
        {
            MainMenu();
            do
            {
                num1 = Console.ReadLine();
                if (num1.Equals("1"))
                {
                    Console.Clear();
                    StaffLogin("staff", "today123");
                }
                else if (num1.Equals("2"))
                {
                    Console.Clear();
                    MemberMenu();
                }
            } while (!num1.Equals("0"));
        }

        static void MainMenu()
        {
            Console.Clear();
            PrintLineTitle();
            PrintLine("===========Main Menu===========");
            PrintLine("1. Staff Login");
            PrintLine("2. Member Login");
            PrintLine("0. Exit");
            PrintLine("===============================\n");
            Print("Please make a selection (1-2, or 0 to exit): ");
        }

        static void StaffMenu()
        {
            PrintLineTitle();
            PrintLine("================Staff Menu================");
            PrintLine("1. Add a new tool");
            PrintLine("2. Add new pieces of an existing tool");
            PrintLine("3. Remove some pieces of a tool");
            PrintLine("4. Register a new member");
            PrintLine("5. Remove a member");
            PrintLine("6. Find the contact number of a member");
            PrintLine("0. Return to main menu");
            PrintLine("==========================================\n");
            Print("Please make a selection (1-6, or 0 to return to main menu): ");
            num2 = Console.ReadLine();
            if (num2.Equals("0"))
            {
                MainMenu();
            } 
            else if (num2.Equals("1"))
            {
                // call methods ToolLibrarySystem.cs
            }
            else if (num3.Equals("2"))
            {

            }
        }

        static void MemberMenu()
        {
            PrintLineTitle();
            PrintLine("===============Member Menu===============");
            PrintLine("1. Display all the tools of a tool type");
            PrintLine("2. Borrow a tool");
            PrintLine("3. Return a tool");
            PrintLine("4. List all the tools that I am renting");
            PrintLine("5. Display top three (3) most frequently rented tools");
            PrintLine("0. Return to main menu");
            PrintLine("=========================================\n");
            Print("Please make a selection (1-5, or 0 to return to main menu): ");
            num3 = Console.ReadLine();
            if (num3.Equals("0"))
            {
                MainMenu();
            }
        }

        static void StaffLogin(string username, string password)
        {
            PrintLineTitle();
            PrintLine("==========Staff Login==========");
            Print("Username: ");
            staffUsername = Console.ReadLine();
            Print("Password: ");
            staffPassword = Console.ReadLine();
            if (username.Equals(staffUsername) && password.Equals(staffPassword))
            {
                Console.Clear();
                StaffMenu();
            }
            else
            {
                PrintLine("\nStaff not found.");
            }
        }

        static void MemberLogin()
        {

        }

        private static void Print(string text)
        {
            Console.Write(text);
        }
        private static void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        private static void PrintLineTitle()
        {
            Console.WriteLine("Welcome to the Tool Library");
        }
    }
}
