using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KonnektU.Models
{
    public class ParameterContext : DbContext
    {
        public DbSet<Parameter> Parameters { get; set; }
    }
}