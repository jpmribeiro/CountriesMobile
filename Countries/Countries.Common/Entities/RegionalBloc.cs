using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Web.Data.Entities
{
    public class RegionalBloc
    {
        public string Acronym { get; set; }
        public string RegionalBlocName { get; set; }
        public List<object> OtherAcronyms { get; set; }
        public List<object> OtherNames { get; set; }
    }
}
