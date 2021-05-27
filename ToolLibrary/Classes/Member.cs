using System;

namespace ToolLibrary.Classes
{
    class Member : iMember, IComparable
    {
        private string firstName;     // firstName field
        private string lastName;      // lastName field
        private string contactNumber; // contactNumbe field
        private string pin;           // pin field

        private ToolCollection toolCollection = new ToolCollection();

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string PIN { get => pin; set => pin = value; }

        public iTool[] Tools => toolCollection.toArray();

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
            return "First name - " + this.firstName + " | Last name - " + this.lastName + " | Contact number - " + this.contactNumber + "\n";
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
