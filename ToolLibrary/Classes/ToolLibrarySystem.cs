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
                Console.WriteLine("\n   My Borrowed tools");
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
            // if borrowed tools is greater than 0
            if (toolsBorrowed.Length > 0)
            {
                // Sort the borrowed tools using selection sort. 
                Sort(toolsBorrowed);

                // diplay the title to console. 
                Console.WriteLine("     Top three most borrowed tools     ");
                Console.WriteLine("=======================================");

                int i, j;

                if (toolsBorrowed[0] != null)
                {
                    // loop around topthreetools array
                    for (i = 0; i < topThreeTools.Length; i++)
                    {
                        // loop around toolsborrowed array
                        for (j = 0; j < toolsBorrowed.Length; j++)
                        {
                            if (i == 0)
                            {
                                topThreeTools[i] = toolsBorrowed[j];
                                break;
                            }
                            // checking names
                            else if (i == 1 && !topThreeTools[0].Name.Equals(toolsBorrowed[j].Name))
                            {
                                topThreeTools[i] = toolsBorrowed[j];
                                break;
                            }
                            // checking names
                            else if (i == 2 && topThreeTools[1] != null && !topThreeTools[1].Name.Equals(toolsBorrowed[j].Name) && !topThreeTools[0].Name.Equals(toolsBorrowed[j].Name))
                            {
                                topThreeTools[i] = toolsBorrowed[j];
                                break;
                            }
                        }
                        // display the top three tools
                        if (topThreeTools[i] != null)
                        {
                            Console.WriteLine("{0}. Name - {1} | Times borrowed - {2}", i + 1, topThreeTools[i].Name, topThreeTools[i].NoBorrowings);

                        }
                    }
                }
            }
            // if there are not borrowed tools 
            else
            {
                Console.WriteLine("\n>>> The library does not have tools borrowed.");
            }
        }

        /* get a list of tools held by a member */
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

        /* return a tool to the library */
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

        /// <summary>
        /// This method uses Selection sort.
        /// </summary>
        /// <param name="arr"></param>
        private Tool[] Sort(Tool[] arr)
        {
            // length of array
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = 0; j < n; j++)
                {
                    if (arr[j].NoBorrowings < arr[min_idx].NoBorrowings)
                    {
                        min_idx = j;
                    }
                }
                // Swap the found minimum element with the first element
                Tool temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        //n = size of array
        //for i=0 to n-1
        //  min_idx = i
        //  for j=0 to n
        //      if arr[j] < arr[min_idx] then
        //          min_idx = j;
        //      end if
        //  end for
        //  temp = arr[min_idx]
        //  swap arr[i] and arr[min_idx]
        //end for

    }
}
