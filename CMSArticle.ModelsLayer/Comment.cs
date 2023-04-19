using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMSArticle.ModelsLayer
{
    [Table("T_Comment")]
    public class Comment
    {
        [Key]
        [Required]
        public int CommentId { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "nvarchar")]
        public string Content { get; set; }

        [Required]
        public DateTime RegisterDate { get; set; }

        [Required]
        public bool IsActive { get; set; }




        public Admin Admin { get; set; }
        public User User { get; set; }
        public Article Article { get; set; }


    }
}
