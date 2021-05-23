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
        static MemberCollection memberCollection = new MemberCollection();
        static ToolCollection toolCollection = new ToolCollection();
        static Member loggedInMember;

        static int tableWidth = 75;

        public static ToolCollection[] gardeningTools;
        private static ToolCollection lineTrimmers = new ToolCollection();
        private static ToolCollection lawnMowers = new ToolCollection();
        private static ToolCollection handTools = new ToolCollection();
        private static ToolCollection wheelbarrows = new ToolCollection();

        public Menu()
        {
            gardeningTools = new ToolCollection[] { lineTrimmers, lawnMowers, handTools, wheelbarrows };
        }

        /* Main method for the program */
        static void Main(string[] args)
        {

            Member aMember = new Member();
            aMember.FirstName = "a";
            aMember.LastName = "a";
            aMember.ContactNumber = "a";
            aMember.PIN = "a";
            t.add(aMember);

            Console.WriteLine(t.memberCollection.Number);

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

        /* Display contents for main menu */
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
                Console.Write("\nEnter the name of a new tool: ");
                string toolName = Console.ReadLine();

                Tool newTool = new Tool();
                newTool.Name = toolName;
                newTool.Quantity = 1;

                // Display all the nine (9) tool categories
                cat.DisplayToolCategories();
                DisplayToolCategories();

                // select a category
                c1 = Console.ReadLine();

                // Display all the tool types of the selected category
                if (c1.Equals("1"))
                {
                    cat.DisplayGardeningTools();
                    c2 = Int32.Parse(Console.ReadLine());
                    if (c2 == 1)
                    {
                        // add to line trimmer
                        t.add(newTool);
                    }
                    else if (c2 == 2)
                    {
                        
                        t.add(newTool);
                    }
                }
                Console.WriteLine("\nTool '{0}' added to the system successfully.", newTool.Name);
                Console.WriteLine("Press any key to continue...\n");
            }

            // 2. Add new pieces of an existing tool
            else if (num2.Equals("2"))
            {
                //AddPieces();
            }

            // 3. Remove some pieces of a tool
            else if (num2.Equals("3"))
            {
                cat.DisplayToolCategories();

                Tool aTool = new Tool();

                int quantity = Int32.Parse(Console.ReadLine());

                t.delete(aTool, quantity);
            }

            // 4. Register a new member
            else if (num2.Equals("4"))
            {
                RegisterNewMember();
            }

            // 5. Remove a member
            else if (num2.Equals("5"))
            {
                //RemoveMember();
            }

            // 6. Find the contact number of a member
            else if (num2.Equals("6"))
            {
                //FindContactNumber();
            }
        }

        static void AddPieces()
        {
            Tool[] tools = (Tool[])t.toolCollection.toArray();
        }

        //private bool ShowTools(Tool[] tool)
        //{
        //    bool b = tool.Length == 0;
        //    if (b == true)
        //    {
        //        Console.WriteLine("There are no tools to display.");
        //        b = false;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < tool.Length; i++)
        //        {
        //            int index = i + 1;
        //        }
        //    }
        //}

        static void RegisterNewMember()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter contact number: ");
            string contactNumber = Console.ReadLine();
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();
            Member aMember = new Member();
            aMember.FirstName = firstName;
            aMember.LastName = lastName;
            aMember.ContactNumber = contactNumber;
            aMember.PIN = pin;
            t.add(aMember);
            Console.WriteLine("\nNew member '{0} {1}' added successfully to the system.\n", aMember.FirstName, aMember.LastName);
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
                DisplayAllTools();
            }
            // 2. Borrow a tool
            else if (num3.Equals("2"))
            {
                BorrowTool();
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
        }

        /* Display all the tools of a tool type */
        static void DisplayAllTools()
        {

        }

        static void BorrowTool()
        {

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

        /* ask member details to login */
        static void MemberLogin()
        {
            PrintLineTitle();
            Console.WriteLine("Member log in");
            Console.WriteLine("==================");

            // ask member first name
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            // ask member last name
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            // ask member pin
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();

            Member[] currentMembers = (Member[])t.memberCollection.toArray();

            for (int i = 0; i < currentMembers.Length; ++i)
                if (currentMembers[i].FirstName == firstName && currentMembers[i].LastName == lastName && currentMembers[i].PIN == pin)
                    loggedInMember = currentMembers[i];
            if (loggedInMember == null)
            {
                Console.WriteLine("Invalid login details.\n");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Logged in successfully!\n");
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
            Console.WriteLine("\nWelcome to the Tool Library");
        }
        private static void invalidInput(string num)
        {
            Console.WriteLine("Error, input '{0}' is invalid", num);
        }

        // link: https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c
        private static void PrintDash()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        private static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }
            Console.WriteLine(row);
        }

        private static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        // not done yet
        // ref: https://www.geeksforgeeks.org/heap-sort/
        private static void HeapSort(Tool[] t)
        {
            // length of array
            int n = t.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {

            }
        }
        
        private static void DisplayToolCategories()
        {
            Console.WriteLine("Select a category");
            Console.WriteLine("=================");
            Console.WriteLine("1. Gardening Tools");
            Console.WriteLine("2. Flooring Tools");
            Console.WriteLine("3. Fencing Tools");
            Console.WriteLine("4. Measuring Tools");
            Console.WriteLine("5. Cleaning Tools");
            Console.WriteLine("6. Painting Tools");
            Console.WriteLine("7. Electronic Tools");
            Console.WriteLine("8. Electricity Tools");
            Console.WriteLine("9. Automotive Tools");
            Console.Write("Select a category (1-9): ");

            int choice1 = Int32.Parse(Console.ReadLine());
            if (choice1 == 1)
            {
                Console.WriteLine("\nGardening Tools");
                Console.WriteLine("===============");
                Console.WriteLine("1. Line Trimmers");
                Console.WriteLine("2. Lawn Mowers");
            }
        }
        


    }
}
