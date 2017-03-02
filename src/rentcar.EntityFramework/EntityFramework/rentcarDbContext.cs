using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using rentcar.Authorization.Roles;
using rentcar.Configuration;
using rentcar.MultiTenancy;
using rentcar.Users;
using rentcar.Web;
using rentcar.Cars;

namespace rentcar.EntityFramework
{
    [DbConfigurationType(typeof(rentcarDbConfiguration))]
    public class rentcarDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */
        public DbSet<Car> Cars { get; set; }

        /* Default constructor is needed for EF command line tool. */

        public rentcarDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                rentcarConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of rentcarDbContext since ABP automatically handles it.
         */
        public rentcarDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public rentcarDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public rentcarDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class rentcarDbConfiguration : DbConfiguration
    {
        public rentcarDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
