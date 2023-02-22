using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class SertifikalarımRepository : GenericRepository<TblSertifiklarim>
    {
        public SertifikalarımRepository(UygulamaDbContext context) : base(context)
        {
        }
    }
}
