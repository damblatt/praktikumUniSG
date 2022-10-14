using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace treeStructureV2
{
    internal class Manager
    {
        public int GetNumberOfTabs(string s)
        {
            return s.Count(ch => ch == '\t');
        }
    }
}
