using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.ViewComponents
{
    public class Sertifikalar : ViewComponent
    {
        private UygulamaDbContext _context;
        private readonly TblSertifiklarim _sertifiklarim;
        public Sertifikalar(UygulamaDbContext context)
        {

            _sertifiklarim = new TblSertifiklarim();
            _context = context;


        }



        public IViewComponentResult Invoke()
        {
            var sertifika = _context.TblSertifiklarim.ToList();
            return View(sertifika);
        }
    }
}
