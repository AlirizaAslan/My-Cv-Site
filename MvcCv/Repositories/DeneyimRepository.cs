using Microsoft.AspNetCore.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class DeneyimRepository : GenericRepository<TblDeneyimlerim>
    {
        public DeneyimRepository(UygulamaDbContext context) : base(context)
        {
        }

            

    } 

}
