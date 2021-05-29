namespace ToolLibrary.Classes
{
    class Tool : iTool
    {
        private string name; // name field
        private int quantity; // quantity field
        private int availableQuantity; // availableQuantity field
        private int noBorrowings; // noBorrowings field
        private int borrowedQuantity; // borrowedQuantity field

        private MemberCollection memberCollection = new MemberCollection();

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
                return memberCollection;
            }
        }

        public void addBorrower(iMember aMember)
        {
            memberCollection.add(aMember);
        }

        public void deleteBorrower(iMember aMember)
        {
            memberCollection.delete(aMember);
        }


        public override string ToString()
        {
            //return "Tool name - " + name + " | Available Quantity - " + availableQuantity + " | Total Quantity - " + quantity;
            return name.PadRight(60) + availableQuantity.ToString().PadRight(19) + quantity;
        }
    }
}
