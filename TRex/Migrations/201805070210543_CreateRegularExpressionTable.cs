namespace TRex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRegularExpressionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegularExpressions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Expression = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegularExpressions");
        }
    }
}
