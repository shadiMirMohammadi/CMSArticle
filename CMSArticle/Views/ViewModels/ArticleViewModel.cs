using CMSArticle.ModelsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSArticle.Views.ViewModels
{
    public class ArticleViewModel
    {
        [Display(Name ="آیدی")]
        public int ArticleId { get; set; }


        [MaxLength(80)]
        [Display(Name = "عنوان")]
       
        public string Title { get; set; }


        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Content { get; set; }


        [MaxLength(70)]
        [Display(Name = " تصویر شاخص")]
        public string ImageName { get; set; }


        [Display(Name = "لایک")]
        public int LikeCount { get; set; }


        [Display(Name = "بازدید")]
        public int VisitCount { get; set; }


        [Display(Name = "تاریخ درج")]
        [DisplayFormat(DataFormatString = "{0: dddd, dd MMMM yyyy}")]
        public DateTime RegisterDate { get; set; }


        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }


        public int UserId { get; set; } = 0;

        public int CategoryId { get; set; } = 0;


        public UserRole User { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}