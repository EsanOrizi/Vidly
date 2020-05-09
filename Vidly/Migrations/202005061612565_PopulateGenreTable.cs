﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy' )");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action' )");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Thriller' )");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance' )");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Family' )");
        }

        public override void Down()
        {
        }
    }
}