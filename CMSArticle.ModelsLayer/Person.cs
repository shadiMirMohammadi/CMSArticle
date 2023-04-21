using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMSArticle.ModelsLayer
{
    public abstract class Person : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string Family { get; set; }

        [Required]
        [MaxLength(15)]
        [Column(TypeName = "char")]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }


        [MaxLength(70)]
        [Column(TypeName = "varchar")]
        public string ImageName { get; set; }



        [Required]
        public DateTime RegisterDate { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
