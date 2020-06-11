using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class RegisterResponse
    {
        public UserDataResponce UserData { get; set; }
        public string SourceId { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public int ErrorCode { get; set; }
        public Warning Warnings { get; set; }
    }
}