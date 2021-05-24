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
        static Member loggedInMember;

        static ToolCollection category;

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

        /* Main method for the program */
        static void Main(string[] args)
        {
            // members added default to test the software
            // adding member 1
            Member member1 = new Member();
            member1.FirstName = "Aung Khant";
            member1.LastName = "Kyaw";
            member1.ContactNumber = "0474268017";
            member1.PIN = "0000";
            t.add(member1);

            // adding member 2
            Member member2 = new Member();
            member2.FirstName = "Saw Soe";
            member2.LastName = "Moe";
            member2.ContactNumber = "049640180";
            member2.PIN = "0000";
            t.add(member2);

            // adding member 3
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
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===========Main Menu===========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===============================\n");
            Console.Write("Please make a selection (1-2, or 0 to exit): ");
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
                Environment.Exit(0);
            }
        }

        /* Menu items for staff menu */
        static void StaffMenu()
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("================Staff Menu================");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add new pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of a tool");
            Console.WriteLine("4. Register a new member");
            Console.WriteLine("5. Remove a member");
            Console.WriteLine("6. Find the contact number of a member");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("==========================================");
            Console.Write("\nPlease make a selection (1-6, or 0 to return to main menu): ");
            num2 = Console.ReadLine();

            if (num2.Equals("0"))
            {
                MainMenu();
            }

            // done // 1. Add a new tool
            else if (num2.Equals("1"))
            {
                // enter tool name 
                Console.Write("\nEnter the name of a new tool: ");

                // read the tool name
                string toolName = Console.ReadLine();
                Console.WriteLine();

                // add name to tool object name with default quantity 1
                Tool newTool = new Tool();
                newTool.Name = toolName;
                newTool.Quantity = 1;

                // Display all the nine (9) tool categories 
                DisplayToolCategories();

                // add the tool to the system
                t.add(newTool);

                Console.WriteLine("\n>>> Tool '{0}' added to the system successfully.", newTool.Name);

                Console.WriteLine("\nPress any key to continue...\n");
                Console.ReadLine();

                // call Staff Menu when any key is pressed
                StaffMenu();
            }

            // done // 2. Add new pieces of an existing tool
            else if (num2.Equals("2"))
            {
                AddPieces();
            }

            // done // 3. Remove some pieces of a tool
            else if (num2.Equals("3"))
            {
                RemovePieces();
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

        // done /* 2. add quantity of tools */
        static void AddPieces()
        {
            // display the tool categories 
            DisplayToolCategories();
            Tool[] tools = (Tool[])t.toolCollection.toArray();

            if (ToolsResult(tools))
            {
                Console.Write("Please make a selection: ");
                int choice = Int32.Parse(Console.ReadLine());
                Tool selectedTool = tools[choice - 1];

                Console.Write("\nEnter quantity: ");
                int quantity = Int32.Parse(Console.ReadLine());
                t.add(selectedTool, quantity);

                Console.WriteLine("\n>>> '{0}' more tool(s) added to '{1}'.", quantity, selectedTool.Name);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            StaffMenu();
        }

        // done /* 3. remove quantity of tools */
        private static void RemovePieces()
        {
            DisplayToolCategories();
            Tool[] tools = (Tool[])t.toolCollection.toArray();
            if (ToolsResult(tools))
            {
                Console.Write("Please make a selection: ");
                int choice = Int32.Parse(Console.ReadLine());
                Tool selectedTool = tools[choice - 1];

                Console.Write("\nEnter quantity: ");
                int quantity = Int32.Parse(Console.ReadLine());

                int remaining = selectedTool.Quantity - quantity;

                if (remaining >= 0)
                {
                    t.delete(selectedTool, quantity);
                    Console.WriteLine("Quantity removed - {0}.\nTotal quantity of '{1}' - {2}", quantity, selectedTool.Name, remaining);
                }
                else
                {
                    Console.WriteLine("Tool {0} removed from the system.", selectedTool.Name);
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            StaffMenu();
        }

        // done /* 4. Register new member */
        private static void RegisterNewMember()
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

                //read the number of member
                int b = Int32.Parse(Console.ReadLine());

                // check member size
                if (b > registeredMembers.Length || b < 1)
                {
                    // alert if there is no member 
                    Console.WriteLine("\nMember not found.");
                }
                else
                {
                    // search the member using index 
                    Member member = registeredMembers[b - 1];

                    // delete the member from the collection 
                    t.memberCollection.delete(member);

                    // message is shown on the screen when success
                    Console.WriteLine("\n>>>Member '{0} {1}' removed from the system.", member.FirstName, member.LastName);
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            StaffMenu();
        }

        // done /* 6. Find contact number of a member */
        static void FindContactNumber(string firstName, string lastName)
        {
            Member[] registerMembers = (Member[])t.memberCollection.toArray();
            if (registerMembers.Length > 0)
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
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===============Member Menu===============");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all the tools that I am renting");
            Console.WriteLine("5. Display top three (3) most frequently rented tools");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("=========================================\n");
            Print("Please make a selection (1-5, or 0 to return to main menu): ");
            num3 = Console.ReadLine(); // read the number input
            if (num3.Equals("0"))
            {
                MainMenu(); // show the main menu
            }
            // done // 1. Display all the tools of a tool type
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

        // done /* 1. Display all the tools of a tool type */
        static void DisplayAllTools()
        {
            DisplayToolCategories();
            ToolsResult((Tool[])t.toolCollection.toArray());
            Console.WriteLine();
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

        
        // done // handle staff login using default values 
        static void StaffLogin(string username, string password)
        {
            bool verifyStaff;
            do
            {
                Console.WriteLine("Welcome to the Tool Library");
                Console.WriteLine("==========Staff Login==========");
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
            Console.WriteLine("Welcome to the Tool Library");
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
                    Console.Write("{0}. ", i + 1);
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
        private static void invalidInput(string num)
        {
            Console.WriteLine("Error, input '{0}' is invalid", num);
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
            ToolCategories tc = new ToolCategories();

            tc.DisplayToolCategories();

            Console.Write("Please make a selection (1-9): ");

            int choice1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            int choice2;

            // 1. Gardening Tools
            if (choice1 == 1)
            {
                tc.DisplayGardeningTools();
                Console.Write("Please make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = GardeningTools(choice2 - 1);
            }
            // 2. Flooring Tools
            else if (choice1 == 2)
            {
                tc.DisplayFlooringTools();
                Console.Write("\nPlease make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = FlooringTools(choice2 - 1);
            }
            // 3. Fencing Tools
            else if (choice1 == 3)
            {
                tc.DisplayFencingTools();
                Console.Write("\nPlease make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = FencingTools(choice2 - 1);
            }
            // 4. Measuring Tools
            else if (choice1 == 4)
            {
                tc.DisplayMeasuringTools();
                Console.Write("\nPlease make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = MeasuringTools(choice2 - 1);
            }
            // 5. Cleaning Tools
            else if (choice1 == 5)
            {
                tc.DisplayCleaningTools();
                Console.Write("\nPlease make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = CleaningTools(choice2 - 1);
            }
            // 6. Painting Tools
            else if (choice1 == 6)
            {
                tc.DisplayPaintingTools();
                Console.Write("\nPlease make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = PaintingTools(choice2 - 1);
            }
            // 7. Electronic Tools
            else if (choice1 == 7)
            {
                tc.DisplayElectronicTools();
                Console.Write("\nPlease make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = ElectronicTools(choice2 - 1);
            }
            // 8. Electricity Tools
            else if (choice1 == 8)
            {
                tc.DisplayElectricityTools();
                Console.Write("\nPlease make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = ElectricityTools(choice2 - 1);
            }
            // 9. Automotive Tools
            else if (choice1 == 9)
            {
                tc.DisplayAutomotiveTools();
                Console.Write("\nPlease make a selection: ");
                choice2 = Int32.Parse(Console.ReadLine());
                t.toolCollection = AutomotiveTools(choice2 - 1);
            }
        }
        private static ToolCollection GardeningTools(int j)
        {
            gardeningTools = new ToolCollection[] { lineTrimmers, lawnMowers, handTools, wheelbarrows, gardenPowerTools };
            for (int i = 0; i < gardeningTools.Length; i++)
            {
                category = gardeningTools[j];
            }
            return category;
        }

        private static ToolCollection FlooringTools(int j)
        {
            flooringTools = new ToolCollection[] { scrapers, floorLasers, floorLevellingTools, floorLevellingMaterials, floorHandTools, tilingTools };
            for (int i = 0; i < flooringTools.Length; i++)
            {
                category = flooringTools[j];
            }
            return category;
        }

        private static ToolCollection FencingTools(int j)
        {
            fencingTools = new ToolCollection[] { fHandTools, electricFencing, steelFencingTools, powerTools, fencingAccessories };
            for (int i = 0; i < fencingTools.Length; i++)
            {
                category = fencingTools[j];
            }
            return category;
        }

        private static ToolCollection MeasuringTools(int j)
        {
            measuringTools = new ToolCollection[] { distanceTools, laserMeasurer, measuringJugs, temperatureAndHumidityTools, levellingTools, markers };
            for (int i = 0; i < measuringTools.Length; i++)
            {
                category = measuringTools[j];
            }
            return category;
        }

        private static ToolCollection CleaningTools(int j)
        {
            cleaningTools = new ToolCollection[] { draining, carCleaning, vacuum, pressureCleaners, poolCleaning, floorCleaning };

            for (int i = 0; i < cleaningTools.Length; i++)
            {
                category = cleaningTools[j];
            }
            return category;
        }
        private static ToolCollection PaintingTools(int j)
        {
            paintingTools = new ToolCollection[] { sandingTools, brushes, rollers, paintRemovalTools, paintScrapers, sprayers };

            for (int i = 0; i < paintingTools.Length; i++)
            {
                category = paintingTools[j];
            }
            return category;
        }
        private static ToolCollection ElectronicTools(int j)
        {
            electronicTools = new ToolCollection[] { voltageTester, oscilloscopes, thermalImaging, dataTestTool, insulationTesters };

            for (int i = 0; i < electronicTools.Length; i++)
            {
                category = electronicTools[j];
            }
            return category;
        }
        private static ToolCollection ElectricityTools(int j)
        {
            electricityTools = new ToolCollection[] { testEquipment, safetyEquipment, basicHandTools, circuitProtection, cableTools };

            for (int i = 0; i < electricityTools.Length; i++)
            {
                category = electricityTools[j];
            }
            return category;
        }
        private static ToolCollection AutomotiveTools(int j)
        {
            automotiveTools = new ToolCollection[] { jacks, airCompressors, batteryChargers, socketTools, braking, drivetrain };

            for (int i = 0; i < automotiveTools.Length; i++)
            {
                category = automotiveTools[j];
            }
            return category;
        }
    }
}
