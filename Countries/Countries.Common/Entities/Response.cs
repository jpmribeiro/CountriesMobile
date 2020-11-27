using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Web.Data.Entities
{
    public class Response
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; } //Meaning a Countrie, a successful connection or a list of countries
    }
}
