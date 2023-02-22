using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class YeteneklerimRepository : GenericRepository<TblYeteneklerim>
    {
        public YeteneklerimRepository(UygulamaDbContext context) : base(context)
        {
        }
    }
}
