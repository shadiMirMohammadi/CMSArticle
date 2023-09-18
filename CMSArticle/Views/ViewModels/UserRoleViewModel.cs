using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using CMSArticle.ModelsLayer;

namespace CMSArticle.Views.ViewModels
{
    public class UserRoleViewModel
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
        [Display(Name = "تلفن همراه")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }


        [Display(Name = "تاریخ عضویت")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }


        public IEnumerable<Article> Articles { get; set; }
        public Role Role { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}