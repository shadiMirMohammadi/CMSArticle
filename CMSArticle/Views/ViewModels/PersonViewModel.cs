using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMSArticle.Views.ViewModels
{
    public class PersonViewModel
    {
        [Display(Name = "شماره موبایل")]
        public string PhoneNumber { get; set; }


        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Display(Name = "آدرس بازگشتی")]
        public string ReturnUrl { get; set; }



        [Display(Name = "مرا به خاطر بسپار")]
        public bool SavePassword { get; set; }
    }
}