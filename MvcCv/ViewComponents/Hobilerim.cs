using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.ViewComponents
{
    public class Hobilerim : ViewComponent
    {
        private UygulamaDbContext _context;
        private readonly TblHobilerim _hobilerim;
        public Hobilerim(UygulamaDbContext context)
        {


            _hobilerim = new TblHobilerim();
            _context = context;


        }

        public IViewComponentResult Invoke()
        {
           var hobi=_context.TblHobilerim.ToList();


            return View(hobi);
        }

    }
}
