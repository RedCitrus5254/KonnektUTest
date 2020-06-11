using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class UserDataResponce
    {
        public string UserId { get; set; }
        public string SecretKey { get; set; }
        public IList<Parameter> Parameters { get; set; }
    }
}