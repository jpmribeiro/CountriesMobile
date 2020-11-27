using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Web.Data.Entities
{
    public class Currency
    {
        public string Code { get; set; }
        public string CurrencyName { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
        {
            return $"{Code}, ({Symbol})";
        }
    }
}
