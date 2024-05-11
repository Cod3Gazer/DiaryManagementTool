namespace DataAcessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Salesupdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sales", "DairyVoucherNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sales", "DairyVoucherNumber", c => c.String());
        }
    }
}
