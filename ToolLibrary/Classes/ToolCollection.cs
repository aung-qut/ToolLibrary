using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class ToolCollection : iToolCollection
    {
        private Tool[] tools; // initializing new array for tools
        private int noTools; // field for number of tools

        public int Number => noTools = tools.Length; // property for number of tools

        /* constructor method for ToolCollection */
        public ToolCollection()
        {
            tools = new Tool[100];
            noTools = 0;
        }

        /* adding a new tool to this tool collection */
        public void add(iTool aTool)
        {
            tools[noTools] = (Tool)aTool; // add tool to tools array
            noTools++; // increment the size of array
        }

        /* deleting the tool */
        public void delete(iTool aTool)
        {
            tools[noTools] = null; // delete the element
            noTools--; // decrement the size of array
        }

        /* search the corresponding tool */
        public bool search(iTool aTool)
        {
            // loop around the tool array
            for (int i = 0; i < Number; i++)
            {
                // compare the tools
                if (tools[i].Equals(aTool))
                {
                    // return true when tool is found
                    return true;
                }
            }
            // return false when tool is not found
            return false;
        }

        /* showing tools in this collection to tool array */
        public iTool[] toArray()
        {
            iTool[] toolArray = new Tool[Number];
            int i, j = 0;
            for (i = 0; i < Number; i++)
            {
                if (IsExist(i))
                {
                    toolArray[j] = tools[i];
                    j++;
                }
            }
            return toolArray;
        }

        // helper method
        //===============

        /* check if tool is not null */
        private bool IsExist(int i)
        {
            if (tools[i] != null)
            {
                return true;
            }
            return false;
        }
    }
}
