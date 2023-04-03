using Microsoft.EntityFrameworkCore;

namespace MvcCv.Models.Entity
{
    public class UygulamaDbContext : DbContext
    {
      

        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }



        public DbSet<TblAdmin> TblAdmin { get; set; }
        public DbSet<TblDeneyimlerim> TblDeneyimlerim { get; set; }
        public DbSet<TblEgitimlerim> TblEgitimlerim { get; set; }
        public DbSet<TblHakkimda> TblHakkimda { get; set; }
        public DbSet<TblHobilerim> TblHobilerim { get; set; }
        public DbSet<TblSertifiklarim> TblSertifiklarim { get; set; }
        public DbSet<TblYeteneklerim> TblYeteneklerim { get; set; }
        public DbSet<Tblİletisim> Tblİletisim { get; set; }
        public DbSet<TblSosyalMedya> TblSosyalMedya { get; set; }
    }
}
