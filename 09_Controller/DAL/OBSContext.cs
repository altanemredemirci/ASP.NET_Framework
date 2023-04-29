using _09_Controller.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace _09_Controller.DAL
{
    public class OBSContext:DbContext
    {
        public OBSContext():base("Server=DESKTOP-G08N4IE\\SQLDERS; Database=Universite; uid=sa;pwd=1"){ }
        public DbSet<Fakulte> Fakulteler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // Entity => Table dönüşürken isimlerin sonuna 's' takısı gelir. Bu method sayesinde Pluralize yapılmaz.
        }
    }
}