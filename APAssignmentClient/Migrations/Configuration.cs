﻿namespace APAssignmentClient.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using APAssignmentClient.DataService;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            string relative = @"..\..\Data Service";
            string absolute = Path.GetFullPath(relative);
            absolute = Path.GetDirectoryName(@absolute);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
        }

        protected override void Seed(Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
