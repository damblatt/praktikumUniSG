using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexV2
{
    public class Values
    {
        public string[] Content { get; set; }
        public Values(params string[] args)
        {
            foreach(var arg in args)
            {
                Content.Append(arg);
            }
        }
    }
}
