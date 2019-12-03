using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiparisTakip.MvcUI.Models
{
    public class ViewKullanici
    {
        [DisplayName("Kullanıcı Kodu")]
        [Required(ErrorMessage ="{0} Kodu Boşgeçilemez."),
        MinLength(4,ErrorMessage = "{0} En Az {1} Karakterden Oluşmalıdır."),
        MaxLength(20,ErrorMessage = "{0} En Fazla {1} Karakterden Oluşmalıdır.")]
        public string KullaniciKodu { get; set; }

        [DisplayName("Parola")]
        [Required(ErrorMessage = "{0} Boşgeçilemez."),
        MinLength(4, ErrorMessage = "{0} En Az {1} Karakterden Oluşmalıdır."),
        MaxLength(8, ErrorMessage = "{0} En Fazla {1} Karakterden Oluşmalıdır."),
        DataType(DataType.Password)]
        public string Parola { get; set; }
    }
}