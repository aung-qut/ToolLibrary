using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class MemberCollection : iMemberCollection
    {
        //private List<iMember> memberList = new List<iMember>();
        private Member[] members;
        private int noMembers;

        public MemberCollection()
        {
            members = new Member[2];
            noMembers = 0;
        }

        public int Number
        {
            get
            {
                //return memberList.Count + count;
                return members.Length;
            }
        }

        public void add(iMember aMember)
        {
            // using list to add member
            //memberList.Add(aMember);

            // using array to add member
            for (int i = 1; i < members.Length; i++)
            {
                members[i] = (Member)aMember;
                noMembers++;
            }
            foreach (var item in members)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count: " + noMembers);
        }

        public void delete(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public bool search(iMember aMember)
        {
            //throw new NotImplementedException();

            if (true) //
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public iMember[] toArray()
        {
            return members;
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

        public void Sort()
        {
            int min;
            Member temp;
            for (int i = 0; i < (noMembers -2); i++)
            {
                min = i;
                for (int j = (i + 1); j < (noMembers - 1); j++)
                {
                    if (members[j].CompareTo(members[min]) == -1)
                    {
                        min = j;
                    }
                }
                temp = members[i];
                members[i] = members[min];
                members[min] = temp;
            }
        }
    }
}
