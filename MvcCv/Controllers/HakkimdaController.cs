using Microsoft.AspNetCore.Mvc;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
