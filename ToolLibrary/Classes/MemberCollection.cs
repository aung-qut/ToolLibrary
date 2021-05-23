// code borrowed from week 7 question 4 solution

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToolLibrary.Classes
{
    class MemberCollection : iMemberCollection
    {
        private List<Member> memberList;

        private BTreeNode root;

        private int noMembers;

        // default null for root
        public MemberCollection()
        {
            root = null;
        }

        /* get the number of members in this collection */
        public int Number
        {
            get
            {
                return noMembers = countLeaves(root);
            }
        }

        /* add member to the collection */
        public void add(iMember aMember)
        {
            Insert((Member)aMember);
            noMembers++; // increase the number of members
        }

        /* delete member from the collection */
        public void delete(iMember aMember)
        {
            Delete((Member)aMember);
            noMembers--; // decrease the number of members
        }

        /* Search a member in the collection and return true or false depening on found */
        public bool search(iMember aMember)
        {
            for (int i = 0; i < Number; i++)
            {
                if (Search((Member)aMember))
                {
                    return true;
                }
            }
            return false;
        }

        /* result array from this collection */
        public iMember[] toArray()
        {
            return memberArray;
        }


        // helper methods below
        private Member[] memberArray
        {
            get
            {
                InOrderTraverse();
                return (Member[])memberList.ToArray();
            }
        }

        private int countLeaves(BTreeNode node)
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

        /* BSTree Insert method */
        private void Insert(Member item)
        {
            if (root == null)
                root = new BTreeNode(item);
            else
                Insert(item, root);
        }

        private void Insert(Member aMember, BTreeNode ptr)
        {
            if (aMember.CompareTo(ptr.Item) < 0)
            {
                if (ptr.LChild == null)
                    ptr.LChild = new BTreeNode(aMember);
                else
                    Insert(aMember, ptr.LChild);
            }
            else
            {
                if (ptr.RChild == null)
                    ptr.RChild = new BTreeNode(aMember);
                else
                    Insert(aMember, ptr.RChild);
            }
        }
        /* -- BSTree Insert method ends -- */

        /* BSTree Delete method start */
        // there are three cases to consider:
        // 1. the node to be deleted is a leaf
        // 2. the node to be deleted has only one child 
        // 3. the node to be deleted has both left and right children
        private void Delete(Member item)
        {
            // search for item and its parent
            BTreeNode ptr = root; // search reference
            BTreeNode parent = null; // parent of ptr
            while ((ptr != null) && (item.CompareTo(ptr.Item) != 0))
            {
                parent = ptr;
                if (item.CompareTo(ptr.Item) < 0) // move to the left child of ptr
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
        /* -- BSTree Delete method ends -- */

        /* BSTree Search methods start */
        private bool Search(Member aMember)
        {
            return Search(aMember, root);
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
        /* -- BSTree Search methods end --*/

        /* BSTree InOrderTraverse Method */
        private void InOrderTraverse()
        {
            // original
            //Console.Write("InOrder: ");
            //InOrderTraverse(root);
            //Console.WriteLine();
            memberList = new List<Member>();
            InOrderTraverse(root);
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

        // not neccessary
        public void Clear()
        {
            root = null;
        }
    }
}
