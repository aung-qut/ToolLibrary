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
        private int borrowedQuantity;

        public string Name { get => name; set => name = value; }
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                borrowedQuantity = quantity - availableQuantity;
                quantity = value;
                availableQuantity = quantity - borrowedQuantity;
            }
        }
        public int AvailableQuantity { get => availableQuantity; set => availableQuantity = value; }
        public int NoBorrowings { get => noBorrowings; set => noBorrowings = value; }

        public iMemberCollection GetBorrowers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

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
            return "Tool name - " + this.name + " | Available Quantity - " + this.availableQuantity + " | Total Quantity - " + this.quantity + "\n";
        }
    }
}
