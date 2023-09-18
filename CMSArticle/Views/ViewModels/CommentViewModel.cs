using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CMSArticle.ModelsLayer;

namespace CMSArticle.Views.ViewModels
{
    public class CommentViewModel
    {
        [Key]
        [Required]
        [Display(Name = "آیدی")]
        public int CommentId { get; set; }

        [Required]
        [Display(Name ="کامنت")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "تاریخ درج")]
        [DisplayFormat(DataFormatString = "{0: dddd, dd MMMM yyyy}")]
        public DateTime RegisterDate { get; set; }

        [Required]
        [Display(Name = " وضعیت")]
        public bool IsActive { get; set; }


        public AdminRole Admin { get; set; }
        public UserRole User { get; set; }
        public Article Article { get; set; }
    }
}