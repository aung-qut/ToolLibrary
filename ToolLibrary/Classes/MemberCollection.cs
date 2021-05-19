using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToolLibrary.Classes
{
    class MemberCollection : iMemberCollection
    {
        //private List<iMember> memberList = new List<iMember>();
        private Member[] members;
        private int noMembers;

        public MemberCollection()
        {
            members = new Member[10];
            noMembers = 0;
        }

        public int Number
        {
            get
            {
                //return memberList.Count + count;
                return noMembers;
            }
        }

        public void add(iMember aMember)
        {
            // using list to add member
            //memberList.Add(aMember);

            // using array to add member
            //for (int i = 1; i < members.Length; i++)
            //{
            //    members[i] = (Member)aMember;
                
            //}
            //noMembers++;
            //foreach (var item in members)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Number - " + Number);

            // 2nd option
            members[noMembers] = (Member)aMember;
            noMembers++;
        }

        public void delete(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public bool search(iMember aMember)
        {
            int i = 0;
            while (members[i] != null)
            {
                if (aMember.FirstName.Equals(members[i].FirstName) && aMember.LastName.Equals(members[i].LastName))
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public iMember[] toArray()
        {
            // not implemented yet
            return members;
        }

        public void Display()
        {
            for (int i = 0; i < noMembers; i++)
            {
                Console.WriteLine(members[i]);
            }
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
