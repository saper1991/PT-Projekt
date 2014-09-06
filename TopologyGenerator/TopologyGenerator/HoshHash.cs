using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopologyGenerator
{
    class HostHash
    {
        private int index;
        private string name;
        private int counter = 0;

        public HostHash(string name)
        {
            index = counter;
            counter++;
        }

        public int getHash()
        {
            return index;
        }

        public string GetName()
        {
            return name;
        }
    }
}
