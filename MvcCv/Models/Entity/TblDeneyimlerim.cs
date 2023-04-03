namespace MvcCv.Models.Entity
{
    public class TblDeneyimlerim
    {
        public int ID { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Burayı Boş geçemezsiniz")]
        public string? Baslik { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Burayı Boş geçemezsiniz")]
        public string? AltBaslik { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Burayı Boş geçemezsiniz")]
        public string? Aciklama { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Burayı Boş geçemezsiniz")]
        public string? Tarih { get; set;}
        
    }
}
