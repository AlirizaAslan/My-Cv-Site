using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.ViewComponents
{
    public class Deneyimler:ViewComponent
    {

        private UygulamaDbContext _context;
        private readonly TblDeneyimlerim _deneyimlerim;
        public Deneyimler(UygulamaDbContext context)
        {

           
            _deneyimlerim = new TblDeneyimlerim();

            _context = context;


        }

        
                

        public IViewComponentResult Invoke()
        {


            var deneyimler = _context.TblDeneyimlerim.ToList();

             
            return View(deneyimler);

        }



    }
}
