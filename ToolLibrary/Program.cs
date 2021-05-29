using System;
using ToolLibrary.Classes;

namespace ToolLibrary
{
    /// <summary>
    /// The main Program class.
    /// Contains all the methods from ToolLibrarySysten.cs
    /// </summary>
    class Program
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

        // field for adding a appropriate collection to category
        static ToolCollection category;

        // fields for appropriate tool categories 
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
        private static void Main(string[] args)
        {
            // members added default to test the software
            // adding member 3
            Member member3 = new Member();
            member3.FirstName = "a";
            member3.LastName = "a";
            member3.ContactNumber = "a";
            member3.PIN = "a";
            t.add(member3);

            Tool tool1 = new Tool
            {
                Name = "Irwin 125mm Orbital Sander",
                Quantity = 5
            };

            Tool tool2 = new Tool
            {
                Name = "Rocket Sanding Block Holder",
                Quantity = 2
            };

            Tool tool3 = new Tool
            {
                Name = "PowerFit 120 Triangular Sander",
                Quantity = 1
            };

            Tool tool4 = new Tool
            {
                Name = "trimmer",
                Quantity = 6
            };

            t.toolCollection = sandingTools;
            t.add(tool1);
            t.add(tool2);
            t.add(tool3);

            t.toolCollection = lineTrimmers;
            t.add(tool4);

            // program starts with main menu
            MainMenu();
        }

        /* Display contents for main menu */
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library\n");
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
                StaffLogin(staffUsername, staffPassword);
            }
            else if (num1.Equals("2"))
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Tool Library\n");
                Console.WriteLine("   Member log in");
                Console.WriteLine("===================");

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

                MemberLogin(firstName, lastName, pin);
            }
            else if (num1.Equals("0"))
            {
                Environment.Exit(0);
            }
            else
            {
                InvalidInput(num1);
                Console.WriteLine("\nPress enter to return to Main Menu...");
                Console.ReadLine();
                MainMenu();
            }
        }

        /* Menu items for staff menu */
        static void StaffMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library\n");
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
            Console.WriteLine();
            if (num2.Equals("0"))
            {
                MainMenu();
            }
            // 1. Add a new tool
            else if (num2.Equals("1"))
            {
                // enter tool name 
                Console.Write("Enter the name of a new tool: ");

                // read the tool name
                string toolName = Console.ReadLine();
                Console.WriteLine();

                Tool[] tools = (Tool[])t.toolCollection.toArray();

                for (int i = 0; i < tools.Length; i++)
                {
                    if (toolName == tools[i].Name)
                    {
                        Console.WriteLine(">>> Tool with the name '{0}' already existed. Please enter a different name.", toolName);
                    }
                    else
                    {
                        // add name to tool object name with default quantity 1
                        Tool newTool = new Tool
                        {
                            Name = toolName,
                            Quantity = 1 // default quantity is 1
                        };

                        // Display all the nine (9) tool categories 
                        DisplayToolCategories();

                        // add the tool to the system
                        t.add(newTool);

                        Console.WriteLine("\n>>> Tool '{0}' added to the system successfully.", newTool.Name);
                    }
                }

                Console.WriteLine("\nPress enter to return to Staff Menu...");
                Console.ReadLine();
                Console.Clear();

                // call Staff Menu when any key is pressed
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
                RemovePieces();
            }

            // 4. Register a new member
            else if (num2.Equals("4"))
            {
                RegisterNewMember();
            }

            // 5. Remove a member
            else if (num2.Equals("5"))
            {
                RemoveMember();
            }

            // 6. Find the contact number of a member
            else if (num2.Equals("6"))
            {
                Console.Write("Enter member's first name: ");
                string firstName = Console.ReadLine().Trim();

                Console.Write("Enter member's last name: ");
                string lastName = Console.ReadLine().Trim();

                FindContactNumber(firstName, lastName);

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
                StaffMenu();
            }
            else
            {
                InvalidInput(num2);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
                StaffMenu();
            }
        }

        /* 2. add quantity of tools */
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

        /* 3. remove quantity of tools */
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

        /* 4. Register new member */
        private static void RegisterNewMember()
        {
            // ask first name
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            // ask last name
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            // ask contact number
            Console.Write("Enter contact number: ");
            string contactNumber = Console.ReadLine();

            // ask pin
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();

            // member object
            Member aMember = new Member
            {
                FirstName = firstName,
                LastName = lastName,
                ContactNumber = contactNumber,
                PIN = pin
            };

            if (t.memberCollection.search(aMember) == true)
            {
                Console.WriteLine("\n>>> Member is registered already in the system. Please enter a new member.");
            }
            else
            {
                // method to add new member to the system 
                t.add(aMember);
                Console.WriteLine("\n>>> New member '{0} {1}' added successfully to the system.", aMember.FirstName, aMember.LastName);
            }

            // console output
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            StaffMenu();
        }

        /* 5. Remove a member */
        static void RemoveMember()
        {
            Member[] registeredMembers = (Member[])t.memberCollection.toArray();

            if (MembersResult(registeredMembers))
            {
                //ask the user input
                Console.Write("\nEnter the number of member to remove: ");

                try
                {
                    //read the number of member
                    int b = Int32.Parse(Console.ReadLine());

                    if (b > registeredMembers.Length || b < 1)
                    {
                        Console.WriteLine("\n>>> Member not found.");
                    }
                    else
                    {
                        // search the member using index 
                        Member member = registeredMembers[b - 1];

                        // delete the member from the collection 
                        t.memberCollection.delete(member);

                        // message is shown on the screen when success
                        Console.WriteLine("\n>>> Member '{0} {1}' successfully removed from the system.", member.FirstName, member.LastName);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid input.");
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            StaffMenu();
        }

        /* 6. Find contact number of a member */
        static void FindContactNumber(string firstName, string lastName)
        {
            Member[] registerMembers = (Member[])t.memberCollection.toArray();

            Member aMember = new Member
            {
                FirstName = firstName,
                LastName = lastName,
            };

            if (registerMembers.Length > 0)
            {
                for (int i = 0; i < registerMembers.Length; i++)
                {
                    if (t.memberCollection.search(aMember) == true && registerMembers[i].FirstName.Trim().Equals(firstName) && registerMembers[i].LastName.Trim().Equals(lastName))
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

        // contents for member menu
        static void MemberMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===============Member Menu===============");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all the tools that I am renting");
            Console.WriteLine("5. Display top three (3) most frequently rented tools");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("=========================================\n");
            Console.Write("Please make a selection (1-5, or 0 to return to main menu): ");
            num3 = Console.ReadLine(); // read the number input
            Console.WriteLine();
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
                ReturnTool();
            }
            // 4. List all the tools that I am renting
            else if (num3.Equals("4"))
            {
                ListMyTools();
            }
            // 5. Display top three (3) most frequently rented tools
            else if (num3.Equals("5"))
            {
                DisplayTopThreeTools();
            }
        }

        /* 1. Display all the tools of a tool type */
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
            DisplayToolCategories();

            Tool[] tools = (Tool[])t.toolCollection.toArray();

            if (ToolsResult(tools))
            {
                Console.Write("\nEnter the name of the tool: ");
                string toolName = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < tools.Length; i++)
                {
                    Tool tool = tools[i];
                    if (toolName == tool.Name && tool.AvailableQuantity > 0)
                    {
                        t.borrowTool(loggedInMember, tools[i]);
                        Console.WriteLine("You borrowed one '{0}'.\n", tool.Name);
                        tool.NoBorrowings++;
                        break;
                    }
                    else if (toolName == tool.Name && tool.AvailableQuantity <= 0)
                    {
                        Console.WriteLine("Not enough available quantity to borrow.\n");
                    }
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            MemberMenu();
        }

        /* 3. Return a tool */
        static void ReturnTool()
        {
            Tool[] tools = (Tool[])loggedInMember.Tools;

            if (tools.Length > 0)
            {
                Console.WriteLine("    Borrowed Tools    ");
                Console.WriteLine("======================");
                int i; 
                for (i = 0; i < tools.Length; i++)
                {
                    Console.Write("{0}. {1}", i + 1, tools[i].Name);
                }

                Console.Write("\nPlease make a selection to return (1-{0}): ", i);
                int choice = Int32.Parse(Console.ReadLine());

                Tool selectedTool = tools[choice - 1];
                t.returnTool(loggedInMember, selectedTool);

                Console.WriteLine("You returned '{0}' to the library.", selectedTool.Name);
            }
            else
            {
                Console.WriteLine("\n>>> No borrowed tools found.");
            }
            Console.WriteLine("\nPress enter to return to Member Menu...");
            Console.ReadLine();
            Console.Clear();
            MemberMenu();
        }

        /* 4. List all tools that I am renting*/
        static void ListMyTools()
        {
            t.displayBorrowingTools(loggedInMember);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            MemberMenu();
        }
        
        /* 5. Display top three (3) most frequently rented tools */
        static void DisplayTopThreeTools()
        {
            // to do 
            t.displayTopTHree();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            MemberMenu();
        }

        // handle staff login using default values 
        static void StaffLogin(string username, string password)
        {
            bool verifyStaff;
            do
            {
                Console.WriteLine("Welcome to the Tool Library\n");
                Console.WriteLine("==========Staff Login==========");
                
                Console.Write("Username: ");
                username = Console.ReadLine();

                Console.Write("Password: ");
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
        static void MemberLogin(string firstName, string lastName, string pin)
        {

            // get members in the system
            Member[] registeredMembers = (Member[])t.memberCollection.toArray();

            // create object for member sign in 
            loggedInMember = new Member {
                FirstName = firstName,
                LastName = lastName,
                PIN = pin
            };

            // loop around the members
            for (int i = 0; i < registeredMembers.Length; ++i)
            {
                if (t.memberCollection.search(loggedInMember) == true)
                {
                    loggedInMember = registeredMembers[i];
                }
                else
                {
                    loggedInMember = null;
                }
            }

            // if there is no logged in member set to null and show main menu
            if (loggedInMember == null)
            {
                Console.WriteLine(">>> Login failed. Member not found \n");
                Console.WriteLine("Press any key to return to Main Menu...");
                Console.ReadLine();
                MainMenu();
            }

            // else show it success and show the member menu
            else
            {
                Console.Clear();
                Console.WriteLine(">>> Member '{0} {1}' logged in successfully.\n", loggedInMember.FirstName, loggedInMember.LastName);
                MemberMenu();
            }
        }

        // display members
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

        // display tools
        private static bool ToolsResult(Tool[] tools)
        {
            bool b;
            if (tools.Length > 0)
            {
                Console.WriteLine("\n                                     Tools in the system                                 ");
                Console.WriteLine("===========================================================================================");
                Console.WriteLine("{0}.  {1,-50} {2,-20} {3,10}", "No", "Name", "Available Quantity", "Total Quantity");
                Console.WriteLine("===========================================================================================");
                for (int i = 0; i < tools.Length; i++)
                {
                    Console.Write(" {0}.  ", i + 1);
                    t.displayTools(tools[i].ToString());
                }
                b = true;
            }
            else
            {
                b = false;
                Console.WriteLine("\n>>> There are no tools in the system.");
            }
            return b;
        }

        // to handle invlaid inputs
        private static void InvalidInput(string num)
        {
            Console.WriteLine("\n>>> Error, input '{0}' is invalid", num);
        }

        private static void DisplayToolCategories()
        {
            ToolCategories tc = new ToolCategories();

            // Display the tool categories 
            tc.DisplayToolCategories();

            // ask for the user selection of category
            Console.Write("Please make a selection (1-9): ");

            // read the input
            int choice1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            int choice2;

            // 1. Gardening Tools
            if (choice1 == 1)
            {
                tc.DisplayGardeningTools();
                Console.Write("\nPlease make a selection: ");
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