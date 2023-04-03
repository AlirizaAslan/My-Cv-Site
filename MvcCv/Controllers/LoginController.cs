using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class LoginController : Controller
    {


		UygulamaDbContext _context;

		public LoginController(UygulamaDbContext context)
		{
			_context = context;
		}

		public LoginController()
		{
		}

		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public IActionResult Index(TblAdmin p)
		{

            var bilgi=_context.TblAdmin.FirstOrDefault(
				x=>x.KullaniciAdi==p.KullaniciAdi&& x.Sifre==p.Sifre);

			return View();
		}
	}
}
