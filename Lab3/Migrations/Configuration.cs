namespace Lab3.Migrations
{
    using Lab3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab3.Data.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Lab3.Data.StoreContext";
        }

        protected override void Seed(Lab3.Data.StoreContext context)
        {
            context.Customers.AddOrUpdate(
                  c => c.Id,
                  new Customer { Id = 1, Name = "Apple, Inc" },
                  new Customer { Id = 2, Name = "Bunge Ltd" },
                  new Customer { Id = 3, Name = "FedEx Corp" },
                  new Customer { Id = 4, Name = "Microsoft Corp" },
                  new Customer { Id = 5, Name = "Amazon.com, Inc" },
                  new Customer { Id = 6, Name = "Gazprom PJSC" },
                  new Customer { Id = 7, Name = "MegaFon PJSC" },
                  new Customer { Id = 8, Name = "Mosenergo OAO" }
                );
            context.Orders.AddOrUpdate(
                  o => o.Id,
                  new Order { Id = 1, Description = "Some order description for Apple", CustomerId = 1 },
                  new Order { Id = 2, Description = "Apple order description", CustomerId = 1 },
                  new Order { Id = 6, Description = "1 notebook, 2 phones", CustomerId = 1 },
                  new Order { Id = 4, Description = "Lorem Ipsum", CustomerId = 2 },
                  new Order { Id = 5, Description = "Dolor sir amet", CustomerId = 2 },
                  new Order { Id = 3, Description = "Some text for some customer", CustomerId = 2 },
                  new Order { Id = 7, Description = "network", CustomerId = 3 },
                  new Order { Id = 8, Description = "Some phones", CustomerId = 4 },
                  new Order { Id = 9, Description = "c# lessons", CustomerId = 4 },
                  new Order { Id = 10, Description = "i love java", CustomerId = 4 },
                  new Order { Id = 11, Description = "Microsoft SQL Server", CustomerId = 4 },
                  new Order { Id = 12, Description = "Some text", CustomerId = 5 },
                  new Order { Id = 13, Description = "Some letters", CustomerId = 6 },
                  new Order { Id = 14, Description = "abc", CustomerId = 6 },
                  new Order { Id = 15, Description = "300$", CustomerId = 6 },
                  new Order { Id = 16, Description = "gaz", CustomerId = 7 }
                );
        }
    }
}
