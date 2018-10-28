namespace EntityFramework_Prueba.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework_Prueba.CarPartsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // is true becouse we need a automatic migration if a change ocur.
        }

        protected override void Seed(EntityFramework_Prueba.CarPartsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
