using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adını Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Girin Girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Resim URL Değeri Girin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Girin")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
        public string ConfrimPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Girin")]
        public string Mail { get; set; }
    }
}
