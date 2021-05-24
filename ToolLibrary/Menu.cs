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
        private static ToolCollection gardenPowerTools = new ToolCollection();

        public static ToolCollection[] flooringTools;
        private static ToolCollection scrapers = new ToolCollection();
        private static ToolCollection floorLasers = new ToolCollection();
        private static ToolCollection floorLevellingTools = new ToolCollection();
        private static ToolCollection floorLevellingMaterials = new ToolCollection();
        private static ToolCollection floorHandTools = new ToolCollection();
        private static ToolCollection tilingTools = new ToolCollection();

        public static ToolCollection[] fencingTools;
        private static ToolCollection fHandTools = new ToolCollection();
        private static ToolCollection electricFencing = new ToolCollection();
        private static ToolCollection steelFencingTools = new ToolCollection();
        private static ToolCollection powerTools = new ToolCollection();
        private static ToolCollection fencingAccessories = new ToolCollection();

        public static ToolCollection[] measuringTools;
        private static ToolCollection distanceTools = new ToolCollection();
        private static ToolCollection laserMeasurer = new ToolCollection();
        private static ToolCollection measuringJugs = new ToolCollection();
        private static ToolCollection temperatureAndHumidityTools = new ToolCollection();
        private static ToolCollection levellingTools = new ToolCollection();
        private static ToolCollection markers = new ToolCollection();

        public static ToolCollection[] cleaningTools;
        private static ToolCollection draining = new ToolCollection();
        private static ToolCollection carCleaning = new ToolCollection();
        private static ToolCollection vacuum = new ToolCollection();
        private static ToolCollection pressureCleaners = new ToolCollection();
        private static ToolCollection poolCleaning = new ToolCollection();
        private static ToolCollection floorCleaning = new ToolCollection();

        public static ToolCollection[] paintingTools;
        private static ToolCollection sandingTools = new ToolCollection();
        private static ToolCollection brushes = new ToolCollection();
        private static ToolCollection rollers = new ToolCollection();
        private static ToolCollection paintRemovalTools = new ToolCollection();
        private static ToolCollection paintScrapers = new ToolCollection();
        private static ToolCollection sprayers = new ToolCollection();

        public static ToolCollection[] electronicTools;
        private static ToolCollection voltageTester = new ToolCollection();
        private static ToolCollection oscilloscopes = new ToolCollection();
        private static ToolCollection thermalImaging = new ToolCollection();
        private static ToolCollection dataTestTool = new ToolCollection();
        private static ToolCollection insulationTesters = new ToolCollection();

        public static ToolCollection[] electricityTools;
        private static ToolCollection testEquipment = new ToolCollection();
        private static ToolCollection safetyEquipment = new ToolCollection();
        private static ToolCollection basicHandTools = new ToolCollection();
        private static ToolCollection circuitProtection = new ToolCollection();
        private static ToolCollection cableTools = new ToolCollection();

        public static ToolCollection[] automotiveTools;
        private static ToolCollection jacks = new ToolCollection();
        private static ToolCollection airCompressors = new ToolCollection();
        private static ToolCollection batteryChargers = new ToolCollection();
        private static ToolCollection socketTools = new ToolCollection();
        private static ToolCollection braking = new ToolCollection();
        private static ToolCollection drivetrain = new ToolCollection();

        public Menu()
        {
            gardeningTools = new ToolCollection[] { lineTrimmers, lawnMowers, handTools, wheelbarrows, gardenPowerTools };
            flooringTools = new ToolCollection[] { scrapers, floorLasers, floorLevellingTools, floorLevellingMaterials, floorHandTools, tilingTools };
            fencingTools = new ToolCollection[] { fHandTools, electricFencing, steelFencingTools, powerTools, fencingAccessories };
            measuringTools = new ToolCollection[] { distanceTools, laserMeasurer, measuringJugs, temperatureAndHumidityTools, levellingTools, markers };
            cleaningTools = new ToolCollection[] { draining, carCleaning, vacuum, pressureCleaners, poolCleaning, floorCleaning };
            paintingTools = new ToolCollection[] { sandingTools, brushes, rollers, paintRemovalTools, paintScrapers, sprayers };
            electronicTools = new ToolCollection[] { voltageTester, oscilloscopes, thermalImaging, dataTestTool, insulationTesters };
            electricityTools = new ToolCollection[] { testEquipment, safetyEquipment, basicHandTools, circuitProtection, cableTools };
            automotiveTools = new ToolCollection[] { jacks, airCompressors, batteryChargers, socketTools, braking, drivetrain };
        }

        /* Main method for the program */
        static void Main(string[] args)
        {
            Member member1 = new Member();
            member1.FirstName = "Aung Khant";
            member1.LastName = "Kyaw";
            member1.ContactNumber = "0474268017";
            member1.PIN = "0000";
            t.add(member1);

            Member member2 = new Member();
            member2.FirstName = "Saw Soe";
            member2.LastName = "Moe";
            member2.ContactNumber = "049640180";
            member2.PIN = "0000";
            t.add(member2);

            Member member3 = new Member();
            member3.FirstName = "a";
            member3.LastName = "a";
            member3.ContactNumber = "a";
            member3.PIN = "a";
            t.add(member3);

            // program starts with main menu
            MainMenu();
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
            else if (num1.Equals("0"))
            {
                MainMenu();
            }
        }

        /* Menu items for staff menu */
        static void StaffMenu()
        {
            ToolCategories cat = new ToolCategories();
            int c1;
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
            PrintLine("==========================================");
            Print("\nPlease make a selection (1-6, or 0 to return to main menu): ");
            num2 = Console.ReadLine();

            if (num2.Equals("0"))
            {
                MainMenu();
            }

            // 1. Add a new tool
            else if (num2.Equals("1"))
            {
                // enter tool name 
                Console.Write("\nEnter the name of a new tool: ");

                // read the tool name
                string toolName = Console.ReadLine();

                // add name to tool object name with default quantity 1
                Tool newTool = new Tool();
                newTool.Name = toolName;
                newTool.Quantity = 1;

                // Display all the nine (9) tool categories 
                //cat.DisplayToolCategories();
                DisplayToolCategories();

                t.add(newTool);

                // select a category
                //c1 = Int32.Parse(Console.ReadLine());

                // Display all the tool types of the selected category 
                //if (c1.Equals("1"))
                //{
                //    // display gardening tools 
                //    cat.DisplayGardeningTools();

                //    // ask the user input 
                //    Console.Write("\nPlease select the number: ");

                //    // read the user input 
                //    c2 = Int32.Parse(Console.ReadLine());

                //    if (c2 == 1)
                //    {
                //        t.toolCollection = lineTrimmers;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 2)
                //    {
                //        t.toolCollection = lawnMowers;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 3)
                //    {
                //        t.toolCollection = handTools;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 4)
                //    {
                //        t.toolCollection = wheelbarrows;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 5)
                //    {
                //        t.toolCollection = gardenPowerTools;
                //        t.add(newTool);
                //    }
                //}

                //// 2. Flooring tools
                //else if (c1.Equals("2"))
                //{
                //    //cat.DisplayFlooringTools();

                //    Console.Write("\nPlease select the number: ");

                //    c2 = Int32.Parse(Console.ReadLine());

                //    if (c2 == 1)
                //    {
                //        t.toolCollection = scrapers;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 2)
                //    {
                //        t.toolCollection = floorLasers;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 3)
                //    {
                //        t.toolCollection = floorLevellingTools;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 4)
                //    {
                //        t.toolCollection = floorLevellingMaterials;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 5)
                //    {
                //        t.toolCollection = floorHandTools;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 6)
                //    {
                //        t.toolCollection = tilingTools;
                //        t.add(newTool);
                //    }
                //}

                //// 3. Fencing tools
                //else if (c1.Equals("3"))
                //{
                //    //cat.DisplayFlooringTools();

                //    Console.Write("\nPlease select the number: ");

                //    c2 = Int32.Parse(Console.ReadLine());

                //    if (c2 == 1)
                //    {
                //        t.toolCollection = scrapers;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 2)
                //    {
                //        t.toolCollection = floorLasers;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 3)
                //    {
                //        t.toolCollection = floorLevellingTools;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 4)
                //    {
                //        t.toolCollection = floorLevellingMaterials;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 5)
                //    {
                //        t.toolCollection = floorHandTools;
                //        t.add(newTool);
                //    }
                //    else if (c2 == 6)
                //    {
                //        t.toolCollection = tilingTools;
                //        t.add(newTool);
                //    }
                //}
                Console.WriteLine("\n>>> Tool '{0}' added to the system successfully.", newTool.Name);

                ToolsResult((Tool[])t.toolCollection.toArray());

                Console.WriteLine("\nPress any key to continue...\n");
                Console.ReadLine();

                // call Staff Menu when done
                StaffMenu();
            }

            // 2. Add new pieces of an existing tool
            else if (num2.Equals("2"))
            {
                AddPieces();
            }

            // 3. Remove some pieces of a tool
            else if (num2.Equals("3"))
            {
                //cat.DisplayToolCategories();

                Tool aTool = new Tool();

                int quantity = Int32.Parse(Console.ReadLine());

                t.delete(aTool, quantity);
            }

            // done // 4. Register a new member
            else if (num2.Equals("4"))
            {
                RegisterNewMember();
            }

            // done // 5. Remove a member
            else if (num2.Equals("5"))
            {
                RemoveMember();
            }

            // done // 6. Find the contact number of a member
            else if (num2.Equals("6"))
            {
                Console.Write("Enter member's first name: ");
                string firstName = Console.ReadLine().Trim();

                Console.Write("Enter member's last name: ");
                string lastName = Console.ReadLine().Trim();

                FindContactNumber(firstName, lastName);

                Console.WriteLine("\nPress any key to continue...");
                Console.Read();
                StaffMenu();
            }
        }

        /* 2. add quantity of tools */
        static void AddPieces()
        {
            Tool[] tools = (Tool[])t.toolCollection.toArray();
        }

        /* 3. remove quantity of tools */
        static void RemovePieces()
        {

        }

        // done /* 4. Register new member */
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
            Console.WriteLine("\n>>> New member '{0} {1}' added successfully to the system.\n", aMember.FirstName, aMember.LastName);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            StaffMenu();
        }

        // done /* 5. Remove a member */
        static void RemoveMember()
        {
            Member[] registeredMembers = (Member[])t.memberCollection.toArray();
            if (MembersResult(registeredMembers))
            {
                //ask the user input
                Console.Write("Enter the number of member to remove: ");
                int b = Int32.Parse(Console.ReadLine());

                if (b > registeredMembers.Length || b < 1)
                {
                    Console.WriteLine("\nMember not found.");
                }
                else
                {
                    Member member = registeredMembers[b - 1];
                    t.memberCollection.delete(member);
                    Console.WriteLine("\n>>>Member '{0}' removed from the system.", member.FirstName);
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
            }
            StaffMenu();
        }

        // done /* 6. Find contact number of a member */
        static void FindContactNumber(string firstName, string lastName)
        {
            Member[] registerMembers = (Member[])t.memberCollection.toArray();
            if(registerMembers.Length > 0)
            {
                for (int i = 0; i < registerMembers.Length; i++)
                {
                    if (registerMembers[i].FirstName.Trim().Equals(firstName) && registerMembers[i].LastName.Trim().Equals(lastName))
                    {
                        Console.WriteLine("\n>>> The contact number of '{0} {1}' is {2}.", firstName, lastName, registerMembers[i].ContactNumber);
                    }
                }
            }
            else
            {
                Console.WriteLine("\n>>> Member does not exist.");
            }
        }

        // done // contents for member menu
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
            // partially done // 1. Display all the tools of a tool type
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
                //ReturnTool();
            }
            // 4. List all the tools that I am renting
            else if (num3.Equals("4"))
            {
                //ListAllRentedTools
            }
            // 5. Display top three (3) most frequently rented tools
            else if (num3.Equals("5"))
            {
                //DisplayTopThreeTools
            }
        }

        // partially done but not all tool types /* 1. Display all the tools of a tool type */
        static void DisplayAllTools()
        {
            ToolCategories cat = new ToolCategories();
            DisplayToolCategories();

            ToolsResult((Tool[])t.toolCollection.toArray());
            Console.WriteLine();

            ////int choice1 = Int32.Parse(Console.ReadLine());

            ////if (choice1 == 1)
            ////{
            ////    cat.DisplayGardeningTools();

            ////    int choice2 = Int32.Parse(Console.ReadLine());

            ////    if (choice2 == 1)
            ////    {
            ////        t.toolCollection = cat.gardeningTools[0];
            ////        ToolsResult((Tool[])t.toolCollection.toArray());
            ////    }
            ////    else if (choice2 == 2)
            ////    {
            ////        t.toolCollection = lawnMowers;
            ////        ToolsResult((Tool[])t.toolCollection.toArray());
            ////    }
            ////}

            Console.WriteLine("\nPress any key to continue...");

            Console.ReadLine();

            MemberMenu();
        }

        /* 2. Borrow a tool */
        static void BorrowTool()
        {

        }

        /* 3. Return a tool */
        static void ReturnTool()
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

        // done /* ask member details to login */
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
            Console.WriteLine();

            // get members in the system
            Member[] registeredMembers = (Member[])t.memberCollection.toArray();

            // loop around the members
            for (int i = 0; i < registeredMembers.Length; ++i)
            {
                // if details matched, make the member logged in member
                if (registeredMembers[i].FirstName == firstName && registeredMembers[i].LastName == lastName && registeredMembers[i].PIN == pin)
                    loggedInMember = registeredMembers[i];
            } 

            // if there is no logged in member set to null and show main menu
            if (loggedInMember == null)
            {
                Console.WriteLine(">>> Login failed. Member not found \n");
                MainMenu();
            }

            // else show it success and show the member menu
            else
            {
                Console.WriteLine(">>> Member '{0}' logged in successfully.\n", loggedInMember.FirstName);
                MemberMenu();
            }
        }

        private static bool MembersResult(Member[] members)
        {
            bool b;
            if (members.Length > 0)
            {
                Console.WriteLine("    Members in the system    ");
                Console.WriteLine("=============================");
                for (int i = 0; i < members.Length; i++)
                {
                    Console.WriteLine("{0}. {1} {2}", i + 1, members[i].FirstName, members[i].LastName);
                }
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        private static bool ToolsResult(Tool[] tools)
        {
            bool b;
            if (tools.Length > 0)
            {
                Console.WriteLine("\n      Tools in the system     ");
                Console.WriteLine("==============================");
                for (int i = 0; i < tools.Length; i++)
                {
                    Console.WriteLine("{0}. ", i + 1);
                    t.displayTools(tools[i].ToString());
                }
                b = true;
            }
            else
            {
                Console.WriteLine("\n>>>There are no tools in the system.");
                b = false;
            }
            return b;
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

        private static void DisplayToolCategories()
        {
            //Console.WriteLine("Select a category");
            //Console.WriteLine("=================");
            //Console.WriteLine("1. Gardening Tools");
            //Console.WriteLine("2. Flooring Tools");
            //Console.WriteLine("3. Fencing Tools");
            //Console.WriteLine("4. Measuring Tools");
            //Console.WriteLine("5. Cleaning Tools");
            //Console.WriteLine("6. Painting Tools");
            //Console.WriteLine("7. Electronic Tools");
            //Console.WriteLine("8. Electricity Tools");
            //Console.WriteLine("9. Automotive Tools");
            //Console.Write("Select a category (1-9): ");

            //int choice1 = Int32.Parse(Console.ReadLine());
            //if (choice1 == 1)
            //{
            //    Console.WriteLine("\nGardening Tools");
            //    Console.WriteLine("===============");
            //    Console.WriteLine("1. Line Trimmers");
            //    Console.WriteLine("2. Lawn Mowers");
            //}
            ToolCategories tc = new ToolCategories();
            
            tc.DisplayToolCategories();

            Console.Write("\nPlease make a selection (1-9): ");

            int choice1 = Int32.Parse(Console.ReadLine());

            int choice2;

            if (choice1 == 1)
            {
                tc.DisplayGardeningTools();

                Console.Write("\nPlease make a selection: ");

                choice2 = Int32.Parse(Console.ReadLine());


                // change to array in ToolCategories here
                t.toolCollection = lineTrimmers;

                Console.Write("index - " + (choice2 - 1));
            }
        }
    }
}
