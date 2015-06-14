namespace ProjectMovieDB.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doittoit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        ActorFullName = c.String(),
                        Awards = c.Int(nullable: false),
                        Movies_MovieId = c.Int(),
                    })
                .PrimaryKey(t => t.ActorId)
                .ForeignKey("dbo.Movies", t => t.Movies_MovieId)
                .Index(t => t.Movies_MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        NameOfFilm = c.String(),
                        Rating = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actors", "Movies_MovieId", "dbo.Movies");
            DropIndex("dbo.Actors", new[] { "Movies_MovieId" });
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
