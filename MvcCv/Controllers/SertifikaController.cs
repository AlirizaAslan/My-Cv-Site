using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SertifikaController : Controller
    {
        public GenericRepository<TblSertifiklarim> _sertifika;

       public  UygulamaDbContext _context;

       public SertifikaController(UygulamaDbContext context)
        {
            _context = context;
            _sertifika =new  GenericRepository<TblSertifiklarim>(context);
        }

        public IActionResult Index()
        {
            var sertifika = _sertifika.List();
            return View(sertifika);
        }



        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika = _sertifika.Find(x => x.ID == id);
            return View(sertifika);
        }

        [HttpPost]
        public ActionResult SertifikaGetir(TblSertifiklarim t)
        {
            var sertifika = _sertifika.Find(x => x.ID == t.ID);
            sertifika.Aciklama = t.Aciklama;
            sertifika.Tarih = t.Tarih;
            _sertifika.TUpdate(sertifika);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult yenisertifika()
        {
            return View();
        }

        [HttpPost]
        public ActionResult yenisertifika(TblSertifiklarim t)
        {
            _sertifika.TAdd(t);
            return RedirectToAction("Index");
        }
    }
}
