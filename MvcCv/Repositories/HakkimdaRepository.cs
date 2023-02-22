using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class HakkimdaRepository : GenericRepository<TblHakkimda>
    {
        public HakkimdaRepository(UygulamaDbContext context) : base(context)
        {
        }
    }
}
