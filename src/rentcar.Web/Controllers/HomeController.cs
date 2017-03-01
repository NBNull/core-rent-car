using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace rentcar.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : rentcarControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}