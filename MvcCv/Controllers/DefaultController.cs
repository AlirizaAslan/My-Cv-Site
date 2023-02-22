using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using MvcCv.Models.Entity;



namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        

       
        private UygulamaDbContext _context;
        private readonly TblHakkimda _hakkimda;
        private readonly TblDeneyimlerim _deneyimlerim;
        private readonly Tblİletisim _iletisim;
        public DefaultController(UygulamaDbContext context)
        {

            _hakkimda=new TblHakkimda();
            _deneyimlerim=new TblDeneyimlerim();
            _iletisim=new Tblİletisim();


            _context = context;


        }

        public IActionResult Index()
        {

            var degerler = _context.TblHakkimda.ToList();

            return View(degerler);
        }


        public PartialViewResult Deneyim()
        {
            var deneyimler=_context.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }


        [HttpGet]
        public PartialViewResult iletisim()
        {

            return PartialView();
        }

        [HttpPost]
        public PartialViewResult iletisim(Tblİletisim t)
        {
            _context.Tblİletisim.Add(t);
            _context.SaveChanges();
            return PartialView();
        }


    }
}
