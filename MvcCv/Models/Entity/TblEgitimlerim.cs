using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MvcCv.Models.Entity
{
    public class TblEgitimlerim
    {
        public int ID { get; set; }       
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage ="Burayı Boş geçemezsiniz")]  //değer girme zorunluluğu
        public string? Baslik { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Burayı Boş geçemezsiniz")]
        public string? Altbaslik1 { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Burayı Boş geçemezsiniz")]
        public string? Altbaslik2 { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Burayı Boş geçemezsiniz")]
        [StringLength(10,ErrorMessage ="en fazla 10 karakter")]
        public string? GNG { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Burayı Boş geçemezsiniz")]
        public string? Tarih { get; set; }
    }
}
