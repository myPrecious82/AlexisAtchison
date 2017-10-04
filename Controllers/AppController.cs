using Microsoft.AspNetCore.Mvc;
using AlexisAtchison.Interfaces;
using AlexisAtchison.Models;

namespace AlexisAtchison.Controllers
{
    public class AppController : Controller
    {
        private readonly IAppRepository _appRepository;

        public AppController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        [HttpGet]
        [ActionName("Property")]
        public JsonResult GetProperties()
        {
            var listings = _appRepository.GetAllPropertyListings();

            return Json(listings);
        }

        [HttpPost]
        [ActionName("Lead")]
        public JsonResult SaveLead([FromBody]Lead lead)
        {
            _appRepository.SaveLead(lead);

            return Json(lead);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
