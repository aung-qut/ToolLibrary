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
            tools = new Tool[10];
            noTools = 0;
        }

        public int Number => noTools;

        public void add(iTool aTool)
        {
            tools[noTools] = (Tool)aTool;
            noTools++;
        }

        public void delete(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public bool search(iTool aTool)
        {
            int i = 0;
            while (tools[i] != null)
            {
                if (aTool.Name.Equals(tools[i].Name))
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public iTool[] toArray()
        {
            //tools.Add(new Tool() { Name = "Gardening tools" });
            ////return tools.ToArray();
            //throw new NotImplementedException();
            return tools;
        }

        public void Display()
        {
            for (int i = 0; i < noTools; i++)
            {
                Console.WriteLine(tools[i]);
            }
        }
    }
}
