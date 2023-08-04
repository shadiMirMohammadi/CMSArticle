using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMSArticle.ModelsLayer
{
    [Table("T_Article")]
    public class Article : BaseEntity
    {
        [Key]
        [Required]
        public int ArticleId { get; set; }

        [Required]
        [MaxLength(80)]
        [Column(TypeName = "nvarchar")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Content { get; set; }

        [Required]
        [MaxLength(70)]
        [Column(TypeName = "varchar")]
        public string ImageName { get; set; }

        public int LikeCount { get; set; }
        public int VisitCount { get; set; }

        [Required]
        public DateTime RegisterDate { get; set; }

        [Required]
        public bool IsActive { get; set; }


        [Required]
        public int UserId { get; set; } = 0;

        [Required]
        public int CategoryId { get; set; } = 0;

        public User User { get; set; }

        public Category Category { get; set; }
        public IEnumerable<Comment> Comments { get; set; }

    }
}
