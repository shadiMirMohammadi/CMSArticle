using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CMSArticle.ModelsLayer;

namespace CMSArticle.Views.ViewModels
{
    public class AdminRoleViewModel
    {
        [Display(Name ="آیدی")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Required]
        [Display(Name = "شماره همراه")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }


        [Display(Name = "تصویر")]
        public string ImageName { get; set; }



        [Required]
        [Display(Name = "تاریخ عضویت")]
        public DateTime RegisterDate { get; set; }

        [Required]
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }

        public Role Role { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}