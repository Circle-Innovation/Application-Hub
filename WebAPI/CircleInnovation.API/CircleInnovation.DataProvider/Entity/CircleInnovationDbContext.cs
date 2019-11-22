using CircleInnovation.DataProvider.Entity.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleInnovation.DataProvider.Entity
{
    public class CircleInnovationDbContext : DbContext
    {
        public CircleInnovationDbContext()
            : base("CircleInnovationDbContext")
        {
            this.SetCommandTimeOut(180);
            Database.SetInitializer<CircleInnovationDbContext>(null);
        }
        public void SetCommandTimeOut(int Timeout)
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = Timeout;
        }

        public DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}
