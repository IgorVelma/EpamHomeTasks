using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11_12_Wolf_And_3Pigs
{
    class PigArg : EventArgs
    {
        private string Who { get; set; }
        public PigArg(string s)
        {
            this.Who = s;
        }
        public override string ToString()
        {
            return Who;
        }
    }
}
