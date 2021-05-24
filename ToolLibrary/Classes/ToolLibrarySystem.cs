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
        
        // done /* add new tool to the system */
        public void add(iTool aTool)
        {
            toolCollection.add(aTool);
        }
        
        // done /* add new pieces of an existing tool to the system */
        public void add(iTool aTool, int quantity)
        {
            aTool.Quantity += quantity;
        }

        // done /* add a new member to the system */
        public void add(iMember aMember)
        {
            memberCollection.add(aMember);
        }

        // done /* member borrowing tool */
        public void borrowTool(iMember aMember, iTool aTool)
        {
            // reduce the available quantity
            aTool.AvailableQuantity--;

            // add member to tool
            aMember.addTool(aTool);

            // add member to tool
            aTool.addBorrower(aMember);

            // add tools to borrowings
            toolsBorrowed = AddToolArr(toolsBorrowed, (Tool)aTool);
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

        // done /* delete a tool from the system */
        public void delete(iTool aTool)
        {
            toolCollection.delete(aTool);
        }

        // done /* remove some pieces of tool from the system */
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

        // done /* delete a member from the system */
        public void delete(iMember aMember)
        {
            memberCollection.delete(aMember);
        }

        /* display all the tools that a member is borrowing */
        public void displayBorrowingTools(iMember aMember)
        {
            string[] a = listTools(aMember);
            if (a.Length != 0)
            {
                Console.WriteLine("You have not borrowed tools.");
            }
            else
            {

            }
        }

        // done /* display tools according to tool type */
        public void displayTools(string aToolType)
        {
            Console.WriteLine(aToolType);
        }

        /* display top three tools borrowed */
        public void displayTopTHree()
        {
            throw new NotImplementedException();
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
    }
}
