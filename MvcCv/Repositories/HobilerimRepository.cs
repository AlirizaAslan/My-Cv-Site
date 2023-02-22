using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class HobilerimRepository : GenericRepository<TblHobilerim>
    {
        public HobilerimRepository(UygulamaDbContext context) : base(context)
        {
        }
    }
}
