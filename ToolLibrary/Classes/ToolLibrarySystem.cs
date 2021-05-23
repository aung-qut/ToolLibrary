using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class ToolLibrarySystem : iToolLibrarySystem
    {
        public MemberCollection memberCollection = new MemberCollection();
        public ToolCollection toolCollection = new ToolCollection();

        ToolCategories cat = new ToolCategories();

        // initialize array to store tools borrowed
        private Tool[] toolsBorrowed = new Tool[0];
        
        public void add(iTool aTool)
        {
            toolCollection.add(aTool);
        }

        /* add new pieces of an existing tool to the system */
        public void add(iTool aTool, int quantity)
        {
            aTool.Quantity++;
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

            // add a tool to the member
            aMember.addTool(aTool);

            // add member to tool
            aTool.addBorrower(aMember);

            // add tools to borrowings
            toolsBorrowed = AddToolArr(toolsBorrowed, (Tool)aTool);
        }


        private Tool[] AddToolArr(Tool[] tools, Tool aTool)
        {
            Tool[] newSizeTools = new Tool[tools.Length + 1];
            for (int i = 0; i < tools.Length; ++i)
                newSizeTools[i] = tools[i];
            newSizeTools[newSizeTools.Length - 1] = aTool;
            return newSizeTools;
        }


        public void delete(iTool aTool)
        {
            toolCollection.delete(aTool);
        }

        /* remove some pieces of tool from the system */
        public void delete(iTool aTool, int quantity)
        {
            delete(aTool);
        }

        public void delete(iMember aMember)
        {
            memberCollection.delete(aMember);
        }

        public void displayBorrowingTools(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void displayTools(string aToolType)
        {
            Console.WriteLine(aToolType);
        }

        public void displayTopTHree()
        {
            throw new NotImplementedException();
        }

        public string[] listTools(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(iMember aMember, iTool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
