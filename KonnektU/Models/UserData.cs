using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class UserData
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool PersonalDataAgree { get; set; }
        public bool emailSubscribeAgree { get; set; }
        public int GenderId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}