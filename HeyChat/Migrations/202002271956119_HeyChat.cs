namespace HeyChat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HeyChat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Conversations", "createdAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Conversations", "createdAt", c => c.DateTime(nullable: false));
        }
    }
}
