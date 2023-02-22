using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.ViewComponents
{
    public class Yeteneklerim : ViewComponent
    {
        private UygulamaDbContext _context;
        private readonly TblYeteneklerim _yeteneklerim;
        public Yeteneklerim(UygulamaDbContext context)
        {

           _yeteneklerim=new TblYeteneklerim();

            _context = context;


        }



        public IViewComponentResult Invoke()
        {
            var yetenek = _context.TblYeteneklerim.ToList();
            return View(yetenek);
        }
    }
}
