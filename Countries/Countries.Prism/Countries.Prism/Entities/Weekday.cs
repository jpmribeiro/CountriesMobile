namespace Countries.Prism.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Weekday
    {
        public Date date { get; set; }
        public Observed observed { get; set; }
    }
}
