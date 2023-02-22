namespace MvcCv.Models.Entity
{
    public class Tblİletisim
    {
        public string ID { get; set; }

        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }        
        public string Mesaj { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }

    }
}
