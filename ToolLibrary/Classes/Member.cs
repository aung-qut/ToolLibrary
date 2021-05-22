using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class Member : iMember, IComparable
    {
        private string firstName;     // firstName field
        private string lastName;      // lastName field
        private string contactNumber; // contactNumbe field
        private string pin;           // pin field
        private string[] tools;

        private ToolCollection toolCollection = new ToolCollection();

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string PIN { get => pin; set => pin = value; }

        public string[] Tools => tools;

        public void addTool(iTool aTool)
        {
            toolCollection.add(aTool);
        }

        public void deleteTool(iTool aTool)
        {
            toolCollection.delete(aTool);
        }

        public override string ToString()
        {
            return "\nFirst name - " + this.firstName + "\nLast name - " + this.lastName + "\nContact number - " + this.contactNumber;
        }

        public int CompareTo(object obj)
        {
            Member another = (Member)obj;
            if (this.lastName.CompareTo(another.LastName) < 0)
                return -1;
            else
                    if (this.lastName.CompareTo(another.LastName) == 0)
                return this.firstName.CompareTo(another.FirstName);
            else
                return 1;
        }
    }
}
