using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class DeneyimController : Controller
    {
        private UygulamaDbContext _context;
        private  DeneyimRepository _repo;
        public DeneyimController(UygulamaDbContext context)
        {
            _repo = new DeneyimRepository(context);
            _context = context;
        }
       

        public IActionResult Index()
        
        {
            var degerler = _repo.List();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult DeneyimEkle() 
        {
        return View();
        }

        [HttpPost]
        public IActionResult DeneyimEkle(TblDeneyimlerim p)
        {
            _repo.TAdd(p);
            return RedirectToAction("Index");   
        }

        public ActionResult DeneyimSil(int id)
        {
            TblDeneyimlerim t = _repo.Find(x=> x.ID==id); //oluşturduğumuz nesne tablodaki id olacak şekilde atama yaptık
            _repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet] //düzenle butonuna bastığında çalışacak kısım
        public ActionResult DeneyimGetir(int id)
        {
            TblDeneyimlerim t = _repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost] //düzenle dedikten sonra verileri postla gönderirken
        public ActionResult DeneyimGetir(TblDeneyimlerim p)
        {
            TblDeneyimlerim t = _repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.AltBaslik = p.AltBaslik;
            t.Aciklama = p.Aciklama;
            t.Tarih = p.Tarih;

            _repo.TUpdate(t);

            return RedirectToAction("Index");
        }


    }
}
