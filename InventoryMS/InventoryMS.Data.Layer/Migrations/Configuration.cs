using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMS.Data.Layer.Migrations
{
    public class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "InventoryMS.Data.Layer.AppDbContext";
            CommandTimeout = 0;
        }
    }
}
