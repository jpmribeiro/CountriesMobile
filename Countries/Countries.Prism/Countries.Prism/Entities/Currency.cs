namespace Countries.Prism.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Currency
    {
        public string Code { get; set; }
        public string name { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
        {
            return $"{Code}, ({Symbol})";
        }
    }
}
