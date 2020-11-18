using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Web.Data.Entities
{
    public class Weekday
    {
        public Date date { get; set; }
        public Observed observed { get; set; }
    }
}
