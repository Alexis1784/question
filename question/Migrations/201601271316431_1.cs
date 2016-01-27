namespace question.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Phones");
            AddColumn("dbo.Phones", "Ident", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Phones", "Ident");
            DropColumn("dbo.Phones", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Phones");
            DropColumn("dbo.Phones", "Ident");
            AddPrimaryKey("dbo.Phones", "Id");
        }
    }
}
