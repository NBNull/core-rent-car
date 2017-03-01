using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace rentcar.Web.Controllers
{
    public abstract class rentcarControllerBase: AbpController
    {
        protected rentcarControllerBase()
        {
            LocalizationSourceName = rentcarConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}