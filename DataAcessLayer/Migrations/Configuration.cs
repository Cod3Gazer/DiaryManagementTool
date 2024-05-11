namespace DataAcessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.AppDbContext context)
        {
            // Ensure that LedgerType entries are created or updated
            context.LedgerTypes.AddOrUpdate(
                lt => lt.LedgerTypeId,
                new LedgerType { LedgerTypeId = 1, LedgerTypeValue = "General Ledger" },
                new LedgerType { LedgerTypeId = 2, LedgerTypeValue = "Sub Ledger" }
            );

            // Save changes explicitly if you are not calling this method from a migration
            context.SaveChanges();
        }
    }
}
