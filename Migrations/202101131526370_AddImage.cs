namespace IlCicerone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArticleCollections", "CollectionImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ArticleCollections", "CollectionImage");
        }
    }
}
