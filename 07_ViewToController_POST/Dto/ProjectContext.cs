using _07_ViewToController_POST.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _07_ViewToController_POST.DTO
{
    public class ProjectContext:DbContext
    {
        public ProjectContext():base("Server=DESKTOP-G08N4IE\\SQLDERS; Database=LoginRegister; uid=sa;pwd=1") //base("MSSQL")
        {
            //Database.Connection.ConnectionString = "Server=DESKTOP-G08N4IE\\SQLDERS; Database=LoginRegister; uid=sa;pwd=1";
        }
        public DbSet<User> Users { get; set; }
    }
}