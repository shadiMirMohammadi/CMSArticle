using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMSArticle.ModelsLayer
{
    [Table("T_Category")]
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(80)]
        [Column(TypeName = "nvarchar")]
        public string Title { get; set; }

        [MaxLength(70)]
        [Column(TypeName = "varchar")]
        public string ImageName { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}
