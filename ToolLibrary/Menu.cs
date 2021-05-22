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

                // select a category
                c1 = Console.ReadLine();

                // Display all the tool types of the selected category
                if (c1.Equals("1"))
                {
                    cat.DisplayGardeningTools();
                    c2 = Int32.Parse(Console.ReadLine());
                    if (c2 == 1)
                    {
                        ToolCollection type = lineTrimmers;
                        t.add(newTool);
                    }
                }
                Console.WriteLine("\nTool '{0}' added to the system successfully.", newTool.Name);
                Console.WriteLine("Press any key to continue...\n");
            }

            // 2. Add new pieces of an existing tool
            else if (num2.Equals("2"))
            {
                
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

                    t.add(member1);

                    Console.WriteLine("Member '{0} {1}' added successfully.", member1.FirstName, member1.LastName);
                    Console.WriteLine("Number(s) of members - {0}\n", t.mc.Number);

                    Console.WriteLine("Press any key to continue.\n");

                    // display members
                    input = Console.ReadLine();

                } while (input.Equals(""));
                StaffMenu();
            }

            // 5. Remove a member
            else if (num2.Equals("5"))
            {
                //Member member = new Member();
                //t.mc.delete(member);
            }

            // 6. Find the contact number of a member
            else if (num2.Equals("6"))
            {
                //Member member = new Member();
                //t.mc.FindContactNumber(member.FirstName, member.LastName);
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
                //ToolCollection tc = new ToolCollection();
                //Console.WriteLine(tc.toArray());
            }
            // 2. Borrow a tool
            else if (num3.Equals("2"))
            {
                //Member aMember = new Member();
                //Tool aTool = new Tool();

                //t.borrowTool(aMember, aTool);
            }
            // 3. Return a tool
            else if (num3.Equals("3"))
            {
                //Member aMember = new Member();
                //Tool aTool = new Tool();

                //t.returnTool(aMember, aTool);
            }
            // 4. List all the tools that I am renting
            else if (num3.Equals("4"))
            {
                //Member aMember = new Member();
                //t.listTools(aMember);
            }
            // 5. Display top three (3) most frequently rented tools
            else if (num3.Equals("5"))
            {
                t.displayTopTHree();
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

        // handle member login - not working yet
        static void MemberLogin()
        {
            PrintLineTitle();
            Console.Write("Enter first name: ");
            string fn = Console.ReadLine();
            Console.Write("Enter last name: ");
            string ln = Console.ReadLine();
            Console.Write("Enter PIN: ");
            string p = Console.ReadLine();

            bool b = t.mc.verifyMember(fn, ln, p);
            if (b == true)
            {
                MemberMenu();
            }
            else
            {
                Console.WriteLine("\n>>> Member does not exist.\n");
            }

            // if member login success, show MemberMenu()
            // MemberMenu();
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

        


    }
}
