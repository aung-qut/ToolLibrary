using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class MemberCollection : iMemberCollection
    {
        private List<iMember> memberList = new List<iMember>();
        private Member[] member;

        public int Number
        {
            get
            {
                return memberList.Count;
            }
        }

        public void add(iMember aMember)
        {
            memberList.Add(aMember);
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
            return memberList.ToArray();
        }

        public string FindContactNumber(string firstName, string lastName)
        {
            Member aMember = new Member(firstName, lastName, "", "");
            iMember[] membersArr = toArray();
            for (int i = 0; i < Number; i++)
            {
                
            }
            return "string";
        }
    }
}
