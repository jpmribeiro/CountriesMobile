using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Web.Data.Entities
{
    public class Holiday
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public override string ToString()
        {
            return $"{Name}, Celebrated at {Date};";
        }
    }
}
