using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class ToolLibrarySystem : iToolLibrarySystem
    {
        public MemberCollection memberCollection = new MemberCollection();
        public ToolCollection toolCollection = new ToolCollection();

        // initialize array to store tools borrowed
        private Tool[] toolsBorrowed = new Tool[0];
        private Tool[] topThreeTools = new Tool[3];

        /* add new tool to the system */
        public void add(iTool aTool)
        {
            toolCollection.add(aTool);
        }
        
        /* add new pieces of an existing tool to the system */
        public void add(iTool aTool, int quantity)
        {
            aTool.Quantity += quantity;
        }

        /* add a new member to the system */
        public void add(iMember aMember)
        {
            memberCollection.add(aMember);
        }

        /* member borrowing tool */
        public void borrowTool(iMember aMember, iTool aTool)
        {
            // reduce the available quantity
            aTool.AvailableQuantity--;

            // add tool to member
            aMember.addTool(aTool);

            // add member to tool
            aTool.addBorrower(aMember);

            // add tools to borrowings
            toolsBorrowed = AddToolArr(toolsBorrowed, (Tool)aTool);
        }

        /* delete a tool from the system */
        public void delete(iTool aTool)
        {
            // delete a tool from the collection
            toolCollection.delete(aTool);
        }

        /* remove some pieces of tool from the system */
        public void delete(iTool aTool, int quantity)
        {
            int con = aTool.Quantity - quantity;
            // check quantity of tool before delete performs
            if (con <= 0)
            {
                delete(aTool);
            }
            else
            {
                aTool.Quantity--;
            }
        }

        /* delete a member from the system */
        public void delete(iMember aMember)
        {
            memberCollection.delete(aMember);
        }

        /* display all the tools that a member is borrowing */
        public void displayBorrowingTools(iMember aMember)
        {
            string[] a = listTools(aMember);
            if (a.Length < 0)
            {
                Console.WriteLine("\n>>> There are no borrowed tools.");
            }
            else
            {
                Console.WriteLine("\n   My Borrowed tools"   );
                Console.WriteLine("=======================");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("{0}. {1}\n", i + 1, a[i]);
                }
            }
        }

        /* display tools according to tool type */
        public void displayTools(string aToolType)
        {
            Console.WriteLine(aToolType);
        }

        /* display top three tools borrowed */
        public void displayTopTHree()
        {
            //throw new NotImplementedException();
            if (toolsBorrowed.Length > 0)
            {
                Sort(toolsBorrowed);

                int i, j;

                for (i = 0; i < topThreeTools.Length; i++)
                {
                    for (j = 0; j < toolsBorrowed.Length; j++)
                    {
                        if (i == 0)
                        {
                            topThreeTools[i] = toolsBorrowed[j];
                            break;
                        }
                        else if (i == 1 && topThreeTools[i] == null && topThreeTools[0] != null && !topThreeTools[0].Name.Equals(toolsBorrowed[j].Name))
                        {
                            topThreeTools[i] = toolsBorrowed[j];
                            break;
                        }
                        else if (i == 2 && topThreeTools[i] == null && topThreeTools[0] != null && topThreeTools[1] != null && !topThreeTools[1].Name.Equals(toolsBorrowed[j].Name) && !topThreeTools[0].Name.Equals(toolsBorrowed[j].Name))
                        {
                            topThreeTools[i] = toolsBorrowed[j];
                            break;
                        }
                    }
                }

                Console.WriteLine("\n     Top three most borrowed tools     ");
                Console.WriteLine("=======================================");

                for (int k = 0; k < topThreeTools.Length; k++)
                {
                    Tool tools = topThreeTools[k];

                    if (tools != null)
                    {
                        Console.WriteLine("{0}. Name - {1} | Times borrowed - {2}", k + 1, tools.Name, tools.NoBorrowings);
                    }
                }
            }
            else
            {
                Console.WriteLine("\n>>> The library does not have tools borrowed.");
            }
        }

        // done /* get a list of tools held by a member */
        public string[] listTools(iMember aMember)
        {
            // number of tools
            int j = aMember.Tools.Length;

            string[] tools = new string[j];

            // using for loop, add to tools string array
            for (int i = 0; i < tools.Length; i++)
            {
                tools[i] = aMember.Tools[i].Name;
            }
            return tools;
        }

        // done /* return a tool to the library */
        public void returnTool(iMember aMember, iTool aTool)
        {
            // increase the number of tool to available quantity
            aTool.AvailableQuantity++;

            // remove a tool from the member
            aMember.deleteTool(aTool);
            
            // remove a member from the tool
            aTool.deleteBorrower(aMember);
        }

        // helper method
        private Tool[] AddToolArr(Tool[] tools, Tool aTool)
        {
            Tool[] newSizeTools = new Tool[tools.Length + 1];
            for (int i = 0; i < tools.Length; ++i)
                newSizeTools[i] = tools[i];
            newSizeTools[newSizeTools.Length - 1] = aTool;
            return newSizeTools;
        }

        private void Sort(Tool[] arr)
        {
            // length of array
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = 0; j < n; j++)
                {
                    if (arr[j].NoBorrowings < arr[min_idx].NoBorrowings)
                    {
                        min_idx = j;
                    }
                }
                Tool temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
