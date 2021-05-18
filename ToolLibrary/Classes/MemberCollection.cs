using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class MemberCollection : iMemberCollection
    {
        private List<iMember> members = new List<iMember>();

        public int Number
        {
            get
            {
                return members.Count;
            }
        }

        public void add(iMember aMember)
        {
            members.Add(aMember);
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
            return members.ToArray();
        }

        public void FindContactNumber()
        {

        }
    }
}
