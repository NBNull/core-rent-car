using Abp.AspNetCore.Mvc.Authorization;
using rentcar.Authorization;
using rentcar.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace rentcar.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : rentcarControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}