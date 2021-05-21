using System;
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
        static ToolLibrarySystem t = new ToolLibrarySystem();
        static Member aMember = new Member();
        static void Main(string[] args)
        {
            // testing

            aMember.FirstName = "aung";
            aMember.LastName = "kyaw";
            aMember.ContactNumber = "1234";
            aMember.PIN = "0000";
            t.add(aMember);

            // -------

            do
            {
                MainMenu();
                num1 = Console.ReadLine();
                if (num1.Equals("1"))
                {
                    Console.Clear();
                    StaffLogin("staff", "today123");
                }
                else if (num1.Equals("2"))
                {
                    Console.Clear();
                    MemberLogin();
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

            ToolCategories cat = new ToolCategories();
            string c1;
            int c2;
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
                // enter tool name
                Console.Write("Enter the name of a new tool: ");
                string toolName = Console.ReadLine();
                Tool newTool = new Tool();
                newTool.Name = toolName;
                newTool.Quantity = 1;
                newTool.AvailableQuantity = 1;
                newTool.NoBorrowings = 0;

                Tool tool1 = new Tool();
                tool1.Name = "Irwin 125mm orbital sander";
                tool1.Quantity = 5;
                tool1.AvailableQuantity = 3;
                tool1.NoBorrowings = 2;
                tls.add(tool1);

                Tool tool2 = new Tool();
                tool2.Name = "Rocket sandling block holder";
                tool2.Quantity = 2;
                tool2.AvailableQuantity = 1;
                tool2.NoBorrowings = 2;
                tls.add(tool2);

                Tool tool3 = new Tool();
                tool3.Name = "Powerfit 120 triangular sander";
                tool3.Quantity = 1;
                tool3.AvailableQuantity = 1;
                tool3.NoBorrowings = 0;
                tls.add(tool3);

                tls.tc.Display();

                // Display all the nine (9) tool categories
                cat.DisplayToolCategories();

                // select a category
                c1 = Console.ReadLine();

                // Display all the tool types of the selected category
                if (c1.Equals("1"))
                {
                    cat.DisplayGardeningTools();
                    c2 = Int32.Parse(Console.ReadLine());

                    // testing ///////////////
                    int[] j = new int[] { 1, 2, 3, 4, 5 };
                    for (int i = 0; i < j.Length; i++)
                    {
                        if (c2 == j[i])
                        {
                            Console.WriteLine(c2 == j[i]);
                            ToolCollection tc = new ToolCollection();
                            tls.tc.add(newTool);
                        }
                    }
                    tls.tc.Display();
                    /////////////////////////
                }
                Console.WriteLine("Tool added to the system successfully.");
                Console.WriteLine("Press any key to continue...");
                // Select a tool type
                // Display all the tools of the selected tool type
                // Add a new tool to the tool type
                // Display all the tools in the selected tool type again
            }
            // 2. Add new pieces of an existing tool
            else if (num2.Equals("2"))
            {
                // Display all the tool categories
                // Select a category
                // Display all the tool types of the selected category
                // Select a tool type
                // Display all the tools of the selected tool type
                // Select a tool from the tool list
                // Add the quantity of the tool
                cat.DisplayToolCategories();

            }
            // 3. Remove some pieces of a tool
            else if (num2.Equals("3"))
            {
                // Display all the nine (9) tool categories
                // Select a category
                // Display all the tool types of the selected category
                // Select a tool type
                // Display all the tools of the selected tool type
                // Select a tool from the tool list
                // Input the number of pieces of the tool to be removed
                // if the number of pieces of the tool is not more than the number of pieces that are currently in the library, reduce the total quantity and the available quantity of the tool
                cat.DisplayToolCategories();
            }
            // 4. Register a new member
            else if (num2.Equals("4"))
            {
                string input;
                do
                {
                    string firstName, lastName, contactNumber, pin;
                    Print("First Name: ");
                    firstName = Console.ReadLine();
                    Print("Last Name: ");
                    lastName = Console.ReadLine();
                    Print("Contact Number: ");
                    contactNumber = Console.ReadLine();
                    Print("PIN: ");
                    pin = Console.ReadLine();

                    Member member1 = new Member();
                    member1.FirstName = firstName;
                    member1.LastName = lastName;
                    member1.ContactNumber = contactNumber;
                    member1.PIN = pin;

                    tls.add(member1);

                    Console.WriteLine("Member '{0} {1}' added successfully.", firstName, lastName);
                    Console.WriteLine("Number(s) of members - {0}\n", tls.mc.Number);

                    Console.WriteLine("Press any key to continue.");

                    // display members
                    tls.mc.Display();
                    input = Console.ReadLine();

                } while (input.Equals(""));
                StaffMenu();
            }
            // 5. Remove a member
            else if (num2.Equals("5"))
            {
                
            }
            // 6. Find the contact number of a member
            else if (num2.Equals("6"))
            {
                //tls.mc.FindContactNumber();
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
                ToolCollection tc = new ToolCollection();
                Console.WriteLine(tc.toArray());
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
            bool verifyStaff;
            do
            {
                PrintLineTitle();
                PrintLine("==========Staff Login==========");
                Print("Username: ");
                username = Console.ReadLine();
                Print("Password: ");
                password = Console.ReadLine();
                verifyStaff = username.Equals(staffUsername) && password.Equals(staffPassword);
                if (verifyStaff == true)
                {
                    Console.Clear(); // clear the console
                    verifyStaff = true;
                    StaffMenu();
                }
                else
                {
                    Console.WriteLine("\nStaff not found.\n");
                }
            } while (verifyStaff == false);

        }

        // handle member login
        static void MemberLogin()
        {
            PrintLineTitle();
            Console.Write("Enter first name: ");
            string fn = Console.ReadLine();
            Console.Write("Enter last name: ");
            string ln = Console.ReadLine();
            Console.Write("Enter PIN: ");
            string p = Console.ReadLine();
            MemberCollection mc = new MemberCollection();
            Console.WriteLine(fn, ln, p);
            if (mc.verifyMember(fn, ln, p))
            {
                MemberMenu();
            }
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
