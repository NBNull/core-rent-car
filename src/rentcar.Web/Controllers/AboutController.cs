using Microsoft.AspNetCore.Mvc;

namespace rentcar.Web.Controllers
{
    public class AboutController : rentcarControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}