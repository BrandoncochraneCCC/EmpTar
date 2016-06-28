namespace EmpTar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmpTar.Models.EmployeeTargetDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EmpTar.Models.EmployeeTargetDBContext";
        }

        protected override void Seed(EmpTar.Models.EmployeeTargetDBContext context)
        {
            context.EmployeeTargets.AddOrUpdate(i => i.ID,
    new Models.EmployeeTarget
    {
        ID = 0,
        EmployeeID = 0,
        TargetHour = 40,
        Month = "January",
        Year = "2016"
    }
    );
        }
    }
}
