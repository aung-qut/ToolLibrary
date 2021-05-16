using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    class Tool : iTool
    {
        string iTool.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int iTool.Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int iTool.AvailableQuantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int iTool.NoBorrowings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        iMemberCollection iTool.GetBorrowers => throw new NotImplementedException();

        void iTool.addBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }

        void iTool.deleteBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }

        string iTool.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
