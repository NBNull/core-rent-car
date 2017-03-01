using rentcar.EntityFramework;
using EntityFramework.DynamicFilters;

namespace rentcar.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly rentcarDbContext _context;

        public InitialHostDbBuilder(rentcarDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
