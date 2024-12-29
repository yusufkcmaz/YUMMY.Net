using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YUMMY.Net.Models
{
    public class Feature /*==>entity*/
    {
        public int FeatureId { get; set; }
        [Required(ErrorMessage ="Resim Url Boş Geçilmez.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Başlık Boş Geçilmez")]
        [MinLength(5,ErrorMessage ="Başlık En az 5 karakter olmalıdır.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Açıklma Boş Geçilmez")]
        [MaxLength(100,ErrorMessage ="Açıklma maksimim 100 karakter olmalı.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Video Url Boş Geçilmez")]
        public string VideoUrl { get; set; }


    }
}