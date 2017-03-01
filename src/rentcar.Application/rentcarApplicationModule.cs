using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using rentcar.Authorization;

namespace rentcar
{
    [DependsOn(
        typeof(rentcarCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class rentcarApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<rentcarAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}