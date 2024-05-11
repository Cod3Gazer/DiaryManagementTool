namespace DataAcessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LedgerTypes",
                c => new
                    {
                        LedgerTypeId = c.Int(nullable: false, identity: true),
                        LedgerTypeValue = c.String(),
                    })
                .PrimaryKey(t => t.LedgerTypeId);
            
            AddColumn("dbo.Customers", "LedgerTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "LedgerTypeId");
            AddForeignKey("dbo.Customers", "LedgerTypeId", "dbo.LedgerTypes", "LedgerTypeId", cascadeDelete: true);
            DropColumn("dbo.Customers", "LedgerType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "LedgerType", c => c.String());
            DropForeignKey("dbo.Customers", "LedgerTypeId", "dbo.LedgerTypes");
            DropIndex("dbo.Customers", new[] { "LedgerTypeId" });
            DropColumn("dbo.Customers", "LedgerTypeId");
            DropTable("dbo.LedgerTypes");
        }
    }
}
