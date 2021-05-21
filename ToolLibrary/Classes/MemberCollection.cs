﻿// code borrowed from week 7 question 4 solution

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

        private BTreeNode root;


        public MemberCollection()
        {
            //before implementing bst
            //members = new Member[10];
            //noMembers = 0;

            root = null;
        }

        public int countLeaves(BTreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            else if (node.LChild == null && node.RChild == null)
            {
                return 1;
            }
            else
            {
                return countLeaves(node.LChild) + countLeaves(node.RChild) + 1;
            }
        }

        public int Number
        {
            get
            {
                return countLeaves(root);
            }
        }

        public void add(iMember aMember)
        {
            //before implementing bst
            //members[noMembers] = (Member)aMember;
            //noMembers++;

            if (root == null)
            {
                root = new BTreeNode((IComparable)aMember);
            }
            else
            {
                add((Member)aMember, root);
            }
        }

        private void add(Member aMember, BTreeNode ptr)
        {
            if (aMember.CompareTo(ptr.Item) < 0)
            {
                if (ptr.LChild == null)
                    ptr.LChild = new BTreeNode(aMember);
                else
                    add(aMember, ptr.LChild);
            }
            else
            {
                if (ptr.RChild == null)
                    ptr.RChild = new BTreeNode(aMember);
                else
                    add(aMember, ptr.RChild);
            }
        }

        public void delete(iMember aMember)
        {
            // search for item and its parent
            BTreeNode ptr = root; // search reference
            BTreeNode parent = null; // parent of ptr
            while ((ptr != null) && (((Member)aMember).CompareTo(ptr.Item) != 0))
            {
                parent = ptr;
                if (((Member)aMember).CompareTo(ptr.Item) < 0) // move to the left child of ptr
                    ptr = ptr.LChild;
                else
                    ptr = ptr.RChild;
            }

            if (ptr != null) // if the search was successful
            {
                // case 3: item has two children
                if ((ptr.LChild != null) && (ptr.RChild != null))
                {
                    // find the right-most node in left subtree of ptr
                    if (ptr.LChild.RChild == null) // a special case: the right subtree of ptr.LChild is empty
                    {
                        ptr.Item = ptr.LChild.Item;
                        ptr.LChild = ptr.LChild.LChild;
                    }
                    else
                    {
                        BTreeNode p = ptr.LChild;
                        BTreeNode pp = ptr; // parent of p
                        while (p.RChild != null)
                        {
                            pp = p;
                            p = p.RChild;
                        }
                        // copy the item at p to ptr
                        ptr.Item = p.Item;
                        pp.RChild = p.LChild;
                    }
                }
                else // cases 1 & 2: item has no or only one child
                {
                    BTreeNode c;
                    if (ptr.LChild != null)
                        c = ptr.LChild;
                    else
                        c = ptr.RChild;

                    // remove node ptr
                    if (ptr == root) //need to change root
                        root = c;
                    else
                    {
                        if (ptr == parent.LChild)
                            parent.LChild = c;
                        else
                            parent.RChild = c;
                    }
                }
            }
        }

        // implemented
        public bool search(iMember aMember)
        {
            // before implementing bst
            //int i = 0;
            //while (members[i] != null)
            //{
            //    if (aMember.FirstName.Equals(members[i].FirstName) && aMember.LastName.Equals(members[i].LastName))
            //    {
            //        return true;
            //    }
            //    i++;
            //}
            //return false;

            return Search((Member)aMember, root);
        }
        private bool Search(Member aMember, BTreeNode r)
        {
            if (r != null)
            {
                if (aMember.CompareTo(r.Item) == 0)
                    return true;
                else
                    if (aMember.CompareTo(r.Item) < 0)
                    return Search(aMember, r.LChild);
                else
                    return Search(aMember, r.RChild);
            }
            else
                return false;
        }

        public iMember[] toArray()
        {
            // not implemented yet
            throw new NotImplementedException();
        }

        public void InOrderTraverse()
        {
            Console.Write("InOrder: ");
            InOrderTraverse(root);
            Console.WriteLine();
        }

        private void InOrderTraverse(BTreeNode root)
        {
            if (root != null)
            {
                InOrderTraverse(root.LChild);
                Console.Write(root.Item);
                InOrderTraverse(root.RChild);
            }
        }

        public bool verifyMember(string firstName, string lastName, string pin)
        {
            bool b = false;
            if (root == null)
            {
                for (int i = 0; i < members.Length; i++)
                {
                    if (members[i] != null)
                    {
                        if (firstName.Equals(members[i].FirstName) && lastName.Equals(members[i].LastName) && pin.Equals(members[i].PIN))
                        {
                            Console.WriteLine(firstName + members[i].FirstName);
                            b = true;
                        }
                        else
                        {
                            b = false;
                        }
                    }
                }
            }
            return b;
        }

        //public void Display()
        //{
        //    for (int i = 0; i < noMembers; i++)
        //    {
        //        Console.WriteLine(members[i]);
        //    }
        //}

        public string FindContactNumber(string firstName, string lastName)
        {
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

        public void Clear()
        {
            root = null;
        }
    }
}
