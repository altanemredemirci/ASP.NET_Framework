using _10_AdminPanel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _10_AdminPanel.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext():base("MSSQL")
        {
            Database.SetInitializer(new MyInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}