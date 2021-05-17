using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class MemberCollection : iMemberCollection
    {
        private int number;
        // private List<iMember> members = new List<iMember>();
        private iMember[] members;

        private int capacity;
        private int count;

        public int Number => number;

        public MemberCollection()
        {
            count = 0;
            capacity = 20;
            members = new iMember[capacity];
        }

        public void add(iMember aMember)
        {
            if (count < capacity)
            {
                members[count] = aMember;
                count++;
            }

            Console.WriteLine("Number(s) of members: {0}", count);
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

        public void FindContactNumber()
        {

        }
    }
}
