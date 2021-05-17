using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class Member : iMember
    {
        private string firstName; // firstName field
        private string lastName; // lastName field
        private string contactNumber; // contactNumbe field
        private string pin; // pin field
        private string[] tools; // tools field

        public Member(string firstName, string lastName, string contactNumber, string pin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
            this.pin = pin;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string PIN { get => pin; set => pin = value; }

        public string[] Tools => tools;

        public void addTool(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void deleteTool(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "First name: " + this.firstName + "\nLast name: " + this.lastName + "\nContact number: " + this.contactNumber;
        }
    }
}
