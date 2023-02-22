using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.ViewComponents
{
    public class Egitim :ViewComponent
    {
        private UygulamaDbContext _context;
        private readonly TblEgitimlerim _egitimlerim;
        public Egitim(UygulamaDbContext context)
        {

            _egitimlerim=new TblEgitimlerim();

            _context = context;


        }


        
        public IViewComponentResult Invoke()
        { 
            var egitim =_context.TblEgitimlerim.ToList();
            return View(egitim);
        }
    }
}
