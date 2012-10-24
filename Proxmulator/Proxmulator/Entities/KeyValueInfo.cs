using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxmulator.Entities
{
    public class KeyValueInfo
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KeyValueInfo()
        {

        }

        public KeyValueInfo(string k, string v)
        {
            Key = k;
            Value = v;
        }
    }
}
