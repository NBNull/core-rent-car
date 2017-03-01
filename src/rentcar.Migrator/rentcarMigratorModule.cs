using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using rentcar.Configuration;
using rentcar.EntityFramework;

namespace rentcar.Migrator
{
    [DependsOn(typeof(rentcarEntityFrameworkModule))]
    public class rentcarMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public rentcarMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(rentcarMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<rentcarDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                rentcarConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}