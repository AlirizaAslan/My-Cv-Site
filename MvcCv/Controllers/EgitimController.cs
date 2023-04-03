using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class EgitimController : Controller
    {
        private UygulamaDbContext _context;
        public GenericRepository<TblEgitimlerim> _egitimler;

        public EgitimController(UygulamaDbContext context)
        {
            _context = context;
            _egitimler = new GenericRepository<TblEgitimlerim>(context);
        }

        public IActionResult Index()
        {
            var egitim = _egitimler.List();
            return View(egitim);
        }

        [HttpGet] 
        public ActionResult EgitimGetir(int id)
        {
            var egitim = _egitimler.Find(x => x.ID == id);
            
            return View(egitim);
        }

        [HttpPost]
        public ActionResult EgitimGetir(TblEgitimlerim t)
        {
            var egitim = _egitimler.Find(x => x.ID ==t.ID);
            egitim.ID = t.ID;
            egitim.Altbaslik1 = t.Altbaslik1;
            egitim.Altbaslik2 = t.Altbaslik2;
            egitim.Tarih=t.Tarih;
            egitim.GNG=t.GNG;


            _egitimler.TUpdate(egitim);
            return RedirectToAction("Index");   

        }

        public ActionResult EgitimSil(int id)
        {
            var egitim= _egitimler.Find(x=>x.ID==id);
            _egitimler.TDelete(egitim);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(TblEgitimlerim p)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            _egitimler.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
