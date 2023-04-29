using _08_Models.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _08_Models.Dto
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("Server=DESKTOP-G08N4IE\\SQLDERS; Database=LoginRegister; uid=sa;pwd=1") //base("MSSQL")
        {
            //Database.Connection.ConnectionString = "Server=DESKTOP-G08N4IE\\SQLDERS; Database=LoginRegister; uid=sa;pwd=1";
        }
        public DbSet<User> Users { get; set; }
    }
}