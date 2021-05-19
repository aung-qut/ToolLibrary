using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class ToolCollection : iToolCollection
    {
        //private List<Tool> tools = new List<Tool>(); // tool list
        private Tool[] tools = new Tool[100];
        private int noTools;

        public ToolCollection()
        {
            tools = new Tool[0];
            noTools = 0;
        }

        public int Number => tools.Length;

        public void add(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public bool search(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public iTool[] toArray()
        {
            //tools.Add(new Tool() { Name = "Gardening tools" });
            //return tools.ToArray();
            throw new NotImplementedException();
        }
    }
}
