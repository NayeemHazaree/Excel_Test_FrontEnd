using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(Guid id)
        {
            // return (id != Guid.Empty) ? 
            ViewBag.Id = id;
            if (id != Guid.Empty)
            {
                //update view
                return View(id);
            }
            else
            {
                //create view
                return View();
            }
        }
    }
}
