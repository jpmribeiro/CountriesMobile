namespace Countries.Prism.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Language
    {
        public string Iso639_1 { get; set; }
        public string Iso639_2 { get; set; }
        public string name { get; set; }
        public string NativeName { get; set; }
        public override string ToString()
        {
            return $"{name}, ( {NativeName} )";
        }
    }
}
