using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class UserVM
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Lütfen isim alanını boş geçmeyiniz")]
        [MaxLength(ErrorMessage ="İsim alanı maksimum 20 karakter olabilir")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim alanını boş geçmeyiniz")]
        [MaxLength(ErrorMessage = "Soyisim alanı maksimum 20 karakter olabilir")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Lütfen Email alanını boş geçmeyiniz")]
        [MaxLength(ErrorMessage = "Email alanı maksimum 2-50 karakter olabilir")]
        [EmailAddress(ErrorMessage ="Lütfen mail formatında giriş yapınız")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Lütfen şifre alanını boş geçmeyiniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet alanını boş geçmeyiniz")]
        public bool Gender { get; set; }
    }
}