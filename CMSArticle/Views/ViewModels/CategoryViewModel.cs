using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CMSArticle.ModelsLayer;

namespace CMSArticle.Views.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        [Display(Name ="آیدی")]
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [Display(Name = "عنوان")]
        public string Title { get; set; }



        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}