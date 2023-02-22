using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class İletisimRepository : GenericRepository<Tblİletisim>
    {
        public İletisimRepository(UygulamaDbContext context) : base(context)
        {
        }
    }
}
