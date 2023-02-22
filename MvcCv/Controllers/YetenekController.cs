using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;


namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        private UygulamaDbContext _context;


       public GenericRepository<TblYeteneklerim> _yeteneklerimRepository;

        public YetenekController(UygulamaDbContext context)
        {
            _context = context; 
            _yeteneklerimRepository=new GenericRepository<TblYeteneklerim>(context); 
        }


        public ActionResult Index()
        {
            var yetenek = _yeteneklerimRepository.List();
            return View(yetenek);
        }

        [HttpGet]
        public ActionResult YeniYetenek() 
        { 

        return View();
        
        }
        [HttpPost]
        public ActionResult YeniYetenek(TblYeteneklerim p)
        {
            _yeteneklerimRepository.TAdd(p);
            return RedirectToAction("Index");   

        }

        public ActionResult YetenekSil(int id)
        { var yetenek=_yeteneklerimRepository.Find(x=>x.ID==id);
           
            _yeteneklerimRepository.TDelete(yetenek);
            return RedirectToAction("Index");   
            
        }

        [HttpGet]
        public ActionResult YetenekDuzenle(int id) 
        { 
            var yetenek=_yeteneklerimRepository.Find(x=>x.ID==id);
            return View(yetenek);
        }

        [HttpPost]
        public ActionResult YetenekDuzenle(TblYeteneklerim t)
        {
            var y = _yeteneklerimRepository.Find(x => x.ID == t.ID);
            y.Yetenek=t.Yetenek;    
            y.Oran=t.Oran;
            _yeteneklerimRepository.TUpdate(y);
            return RedirectToAction("Index");
        }

    }
}
