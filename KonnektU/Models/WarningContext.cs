using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class WarningContext : DbContext
    {
        public DbSet<Warning> Warnings { get; set; }
    }
}