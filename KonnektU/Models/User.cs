using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class User
    {
        public string UserId { get; set; }
        public UserData UserData { get; set; }
        public string SourceId { get; set; }
        public string SourceSecretKey { get; set; }
    }
}