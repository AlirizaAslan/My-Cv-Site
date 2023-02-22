using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.ViewComponents
{
    public class İletisim : ViewComponent
    {
        private UygulamaDbContext _context;
        private readonly Tblİletisim _iletisim;
        public İletisim(UygulamaDbContext context)
        {


            _iletisim = new Tblİletisim();
            _context = context;


        }
        //public IViewComponentResult Invoke()
        //{
            
        //    return View();
        //}



        
        public IViewComponentResult Invoke()
        {
            
                return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Tblİletisim t)
        //{
        //    _context.Tblİletisim.Add(t);
        //    _context.SaveChanges();
        //    return View();
        //}
    }
}
