using Microsoft.AspNetCore.Mvc;

namespace iTS_ApartBillingCheckList.Areas.Login.Controllers
{
    [Area("Login")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
