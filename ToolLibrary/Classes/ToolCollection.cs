using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary.Classes
{
    class ToolCollection : iToolCollection
    {
        private List<iTool> tools = new List<iTool>();

        public int Number => tools.Count;

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
            tools.Add(new Tool() { Name = "Gardening tools" });
            return tools.ToArray();
        }
    }
}
