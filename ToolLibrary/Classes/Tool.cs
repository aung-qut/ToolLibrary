using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class Tool : iTool
    {
        private string name; // name field
        private int quantity; // quantity field
        private int availableQuantity; // availableQuantity field
        private int noBorrowings; // noBorrowings field

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int AvailableQuantity { get => availableQuantity; set => availableQuantity = value; }
        public int NoBorrowings { get => noBorrowings; set => noBorrowings = value; }

        public iMemberCollection GetBorrowers => throw new NotImplementedException();

        public void addBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void deleteBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Tool name - " + this.name + "\nAvailable Quantity - " + this.availableQuantity + "\nTotal Quantity - " + this.quantity + "\n";
        }
    }
}
