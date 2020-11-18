using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Web.Data.Entities
{
    public class Request
    {
        public int used { get; set; }
        public int available { get; set; }
        public string resets { get; set; }
    }
}
