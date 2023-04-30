using _10_AdminPanel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _10_AdminPanel.Context
{
    public class MyInitializer : CreateDatabaseIfNotExists<ProjectContext> // Database oluşturulurken hazır datalar kaydeder.
    {
        protected override void Seed(ProjectContext context)
        {

            Product p = new Product();
            p.Name = "Nokia 3310";
            p.Price = 300;
            p.Image = "1.jpg";

            context.Products.Add(p);
           

            Product p1 = new Product()
            {
                Name = "Nokia 6600",
                Price = 500,
                Image = "2.jpg",
            };

            context.Products.Add(p1);


            List<Product> list = new List<Product>()
            {
                new Product(){Name="Samsung E250",Price=450,Image="3.jpg"},
                new Product(){Name="Motorola C180",Price=250,Image="4.jpg"},
                new Product(){Name="Ericsson 688",Price=150,Image="5.jpg"},
                new Product(){Name="Nokia NGage",Price=650,Image="6.jpg"}
            };

            context.Products.AddRange(list);
            context.SaveChanges();

            User user = new User()
            {
                Username = "admin",
                Password = "1"
            };
            context.Users.Add(user);
            context.SaveChanges();


            base.Seed(context);
        }
    }
}