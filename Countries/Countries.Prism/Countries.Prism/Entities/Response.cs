namespace Countries.Prism.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; } //Meaning a Countrie, a successful connection or a list of countries
    }
}
