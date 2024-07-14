using InventoryMS.Data.Layer.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMS.Data.Layer
{
    public class AppDbContext : DbContext
    {
        public static readonly string ConnectionString = "Data Source=.; Initial Catalog=InventoryMsDB; MultipleActiveResultSets=True;;Integrated Security=True";


        public AppDbContext() : this(ConnectionString) {}

        public AppDbContext(string ConnectionString) : base(ConnectionString)
        {
            Database.CreateIfNotExists();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
        }





    }
}
