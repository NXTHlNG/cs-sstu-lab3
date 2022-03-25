namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name) VALUES " +
                "('Apple, Inc'), " +
                "('Bunge Ltd'), " +
                "('FedEx Corp'), " +
                "('Microsoft Corp'), " +
                "('Amazon.com, Inc'), " +
                "('Gazprom PJSC')," +
                "('MegaFon PJSC')," +
                "('Mosenergo OAO')");

            Sql("INSERT INTO Orders(Description, CustomerId) VALUES " +
                "('Some order description for Apple', 1)," +
                "('Apple order description', 1)," +
                "('1 notebook, 2 phones', 1)," +
                "('Lorem Ipsum', 2)," +
                "('Dolor sir amet', 2)," +
                "('Some text for some customer', 2)," +
                "('gaz', 3)," +
                "('network', 4)," +
                "('Some phones', 4)," +
                "('c# lessons', 4)," +
                "('i love java', 4)," +
                "('Microsoft SQL Server', 5)," +
                "('Some text', 6)," +
                "('Some letters', 6)," +
                "('abc', 6)," +
                "('300$', 7)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Customers");
            Sql("DELETE FROM Orders");
        }
    }
}
