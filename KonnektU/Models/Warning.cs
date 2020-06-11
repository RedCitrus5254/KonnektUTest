using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class Warning
    {
        public int Code { get; set; }
        public string FieldName { get; set; }
        public string Message { get; set; }
    }
}