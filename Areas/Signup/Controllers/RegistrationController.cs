using iTS_ApartBillingCheckList.Areas.InterfaceCollection;
using iTS_ApartBillingCheckList.Areas.Signup.Models;
using Microsoft.AspNetCore.Mvc;

namespace iTS_ApartBillingCheckList.Areas.Signup.Controllers
{
    [Area("Signup")]
    public class RegistrationController : Controller
    {

        private readonly IRegistrationRepository _registrationRepository;

        public RegistrationController(IRegistrationRepository registrationRepo)
        {
            _registrationRepository = registrationRepo;
        }

        
        public async Task<IActionResult> Index()
        {
            var regis = await _registrationRepository.FindAll(); 
            return View(regis); 
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Registration entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _registrationRepository.Add(entity);
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model State Invalid.";
                }

                return View();
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }
    }
}
