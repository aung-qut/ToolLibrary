﻿using System;
using System.Collections.Generic;
using System.Text;
using ToolLibrary.Classes;

namespace ToolLibrary
{
    class Menu
    {
        // variables to read menu items
        static string num1; // menu number for main menu
        static string num2; // menu number for sub-menu 1
        static string num3; // menu number for sub-menu 2

        // default values for staff login
        static string staffUsername = "staff";
        static string staffPassword = "today123";

        // main method for the program to run
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

        // contents for main menu
        static void MainMenu()
        {
            PrintLineTitle();
            PrintLine("===========Main Menu===========");
            PrintLine("1. Staff Login");
            PrintLine("2. Member Login");
            PrintLine("0. Exit");
            PrintLine("===============================\n");
            Print("Please make a selection (1-2, or 0 to exit): ");
        }

        // contents for staff menu
        static void StaffMenu()
        {
            ToolLibrarySystem tls = new ToolLibrarySystem();
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
            // 1. Add a new tool
            if (num2.Equals("1"))
            {
                // call methods ToolLibrarySystem.cs
                PrintLine("Let's add a new tool");
                Tool aTool = new Tool();
            }
            // 2. Add new pieces of an existing tool
            else if (num2.Equals("2"))
            {
                
            }
            // 3. Remove some pieces of a tool
            else if (num2.Equals("3"))
            {

            }
            // 4. Register a new member
            else if (num2.Equals("4"))
            {
                string firstName, lastName, contactNumber, pin;
                // call methods from Member.cs and MemberCollection.cs
                Print("----First Name: ");
                firstName = Console.ReadLine();
                Print("-----Last Name: ");
                lastName = Console.ReadLine();
                Print("Contact Number: ");
                contactNumber = Console.ReadLine();
                Print("-----------PIN: ");
                pin = Console.ReadLine();
                Member newMember = new Member(firstName, lastName, contactNumber, pin);
                tls.add(newMember);
                Console.WriteLine("Member added successfully.");
                Console.WriteLine("Number(s) of members - {0}\n", tls.mc.Number + 1);
                StaffMenu();
            }
            // 5. Remove a member
            else if (num2.Equals("5"))
            {
                
            }
            // 6. Find the contact number of a member
            else if (num2.Equals("6"))
            {

            }
        }

        // contents for member menu
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
            num3 = Console.ReadLine(); // read the number input
            if (num3.Equals("0"))
            {
                MainMenu(); // show the main menu
            }
            // 1. Display all the tools of a tool type
            else if (num3.Equals("1"))
            {

            }
            // 2. Borrow a tool
            else if (num3.Equals("2"))
            {
                
            }
            // 3. Return a tool
            else if (num3.Equals("3"))
            {

            }
            // 4. List all the tools that I am renting
            else if (num3.Equals("4"))
            {

            }
            // 5. Display top three (3) most frequently rented tools
            else if (num3.Equals("5"))
            {

            }
            else
            {
                invalidInput(num3);
            }
        }

        // handle staff login using default values 
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
                Console.Clear(); // clear the console
                StaffMenu(); 
            }
            else
            {
                Console.WriteLine("\nStaff '{0}' not found.", username); // show the error when staff is not found
            }
        }

        // handle member login
        static void MemberLogin(string firstName, string lastName, string pin)
        {
            PrintLineTitle();
            //PrintLine("Fist name: ");
            //mfirstName = Console.ReadLine();
            //PrintLine("Last name: ");
            //mlastName = Console.ReadLine();
            //PrintLine("      PIN: ");
            //mpin = Console.ReadLine();
            //if (mfirstName.Equals(firstName) && mlastName.Equals(lastName) && mpin.Equals(pin))
            //{
            //    Console.Clear(); // clear the console
            //    MemberMenu(); // display member menu
            //}
            //else
            //{
            //    Console.WriteLine("Member '{0}' does not exist. Please register to use the system.", firstName + " " + lastName);
            //}
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
        private static void invalidInput(string num)
        {
            Console.WriteLine("Error, input '{0}' is invalid", num);
        }
    }
}