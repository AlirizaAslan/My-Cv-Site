namespace MvcCv.Models.Entity
{
    public class TblSosyalMedya
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string? Link { get; set; }
        public string İkon { get; set; }

        public bool Durum { get; set; }
    }
}
