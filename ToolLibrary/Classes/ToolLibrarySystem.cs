using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class ToolLibrarySystem : iToolLibrarySystem
    {
        public MemberCollection memberCollection = new MemberCollection();
        private ToolCollection toolCollection = new ToolCollection();

        ToolCategories cat = new ToolCategories();
        
        public void add(iTool aTool)
        {
            toolCollection.add(aTool);
        }

        /* add new pieces of an existing tool to the system */
        public void add(iTool aTool, int quantity)
        {
            aTool.Quantity++;
        }

        /* add a new member to the system */
        public void add(iMember aMember)
        {
            memberCollection.add(aMember);
        }

        public void borrowTool(iMember aMember, iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool, int quantity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
