﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}