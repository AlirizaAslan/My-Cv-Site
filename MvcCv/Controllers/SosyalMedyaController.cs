using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;


namespace MvcCv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        public GenericRepository<TblSosyalMedya> _repo;
        private UygulamaDbContext context;

        public SosyalMedyaController(UygulamaDbContext context)
        {
            this.context = context;
            _repo = new GenericRepository<TblSosyalMedya>(context);
        }

       

      
        public IActionResult Index()
        {

            var veriler = _repo.List();

            return View(veriler);
        }



        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(TblSosyalMedya p)
        {
            _repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SayfaGetir(int id)
        {
            var hesap = _repo.Find(x=>x.ID == id);
            return View(hesap);

        }

        [HttpPost]
        public ActionResult SayfaGetir(TblSosyalMedya p)
        {
            var hesap = _repo.Find(x => x.ID == p.ID);
            hesap.Ad = p.Ad;
            hesap.Durum = true;
            hesap.Link = p.Link;
            hesap.İkon = p.İkon;
            _repo.TUpdate(hesap);
            

            return RedirectToAction("Index");

        }



        public ActionResult Sil(int id)
        {
            var hesap =_repo.Find(x => x.ID == id);
            if (hesap.Durum == true)

            {

                hesap.Durum = false;

            }

            else

            {

                hesap.Durum = true;

            }
            _repo.TUpdate(hesap);
            return RedirectToAction("Index");
            

        }

    }
}
