using MvcCv.Models.Entity;
using System.Linq.Expressions;

namespace MvcCv.Repositories
{
    public class GenericRepository<T>where T:class,new() //T bizim göndereceğimiz sınıflar olacak
    {
        private UygulamaDbContext _context;
       

        public GenericRepository(UygulamaDbContext context)
        {
            
            _context = context;
        }


        public List<T> List() 
        {
        
        return _context.Set<T>().ToList();  //burdaki t  tüm tablolar olaiblir
        }

        public void TAdd(T item)
        {

            _context.Set<T>().Add(item);  //parametre olarak aldığımız veriiyi ekliyoruz

           _context.SaveChanges();           

        }

        public void TDelete(T item) 
        {
        _context.Set<T>().Remove(item);

        _context.SaveChanges();
        }

        public T TGet(int id) //id bulmak için
        {
            return _context.Set<T>().Find(id);

        }

        public void TUpdate(T item) 
        {
            _context.Set<T>().Update(item);    
            _context.SaveChanges();

        }

        public T Find(Expression<Func<T,bool>>where)
        {
            return _context.Set<T>().FirstOrDefault(where);  //ilk değeri döndür where şartına göre
        }

    }
}
