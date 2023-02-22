using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class EgitimRepository : GenericRepository<TblEgitimlerim>
    {
        public EgitimRepository(UygulamaDbContext context) : base(context)
        {
        }
    }
}
