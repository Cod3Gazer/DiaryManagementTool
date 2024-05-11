namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AliasNames",
                c => new
                    {
                        AliasNameId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AliasNameId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        PrintName = c.String(),
                        LedgerType = c.String(),
                        PhoneNumber = c.String(),
                        AlternativePhoneNumber = c.String(),
                        Address = c.String(),
                        CreditDays = c.Int(nullable: false),
                        FollowUpBy = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Excuses",
                c => new
                    {
                        ExcuseId = c.Int(nullable: false, identity: true),
                        ExcuseDate = c.DateTime(nullable: false),
                        ExcuseTime = c.Time(nullable: false, precision: 7),
                        NextFollowUpDate = c.DateTime(nullable: false),
                        ExcuseDesc = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExcuseId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ReceiptId = c.Int(nullable: false, identity: true),
                        DairyDate = c.DateTime(nullable: false),
                        DairyVoucherNumber = c.String(),
                        DairyTime = c.Time(nullable: false, precision: 7),
                        Date = c.DateTime(nullable: false),
                        PartyName = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentMode = c.String(),
                        Remarks = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReceiptId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SalesId = c.Int(nullable: false, identity: true),
                        DairyDate = c.DateTime(nullable: false),
                        DairyVoucherNumber = c.String(),
                        DairyTime = c.Time(nullable: false, precision: 7),
                        InvoiceDate = c.DateTime(nullable: false),
                        InvoiceNumber = c.String(),
                        PartyName = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remarks = c.String(),
                        FileUrl = c.String(),
                        SalesType = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalesId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        FullName = c.String(),
                        Password = c.String(),
                        UserType = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Receipts", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Excuses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.AliasNames", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropIndex("dbo.Receipts", new[] { "CustomerId" });
            DropIndex("dbo.Excuses", new[] { "CustomerId" });
            DropIndex("dbo.AliasNames", new[] { "CustomerId" });
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.Receipts");
            DropTable("dbo.Excuses");
            DropTable("dbo.Customers");
            DropTable("dbo.AliasNames");
        }
    }
}
