using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class MemberCollection : iMemberCollection
    {
        private int number;
        private iMember[] array;
        public int Number => throw new NotImplementedException();

        public void add(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void delete(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public bool search(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public iMember[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
