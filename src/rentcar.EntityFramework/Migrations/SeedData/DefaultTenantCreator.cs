using System.Linq;
using rentcar.EntityFramework;
using rentcar.MultiTenancy;

namespace rentcar.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly rentcarDbContext _context;

        public DefaultTenantCreator(rentcarDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
