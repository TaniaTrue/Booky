namespace Booky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES(1, 'Science fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(2, 'Satire')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(3, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(4, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(5, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(6, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(7, 'Mystery')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(8, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(9, 'Fantasy')");
        }

        public override void Down()
        {
        }
    }
}
