using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreyaSDK.Models.json
{

    public class BTCInfo
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public DateTime datetime { get; set; }
        public float amount { get; set; }
    }

}
