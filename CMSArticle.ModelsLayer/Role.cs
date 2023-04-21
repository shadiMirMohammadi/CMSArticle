using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMSArticle.ModelsLayer
{
    [Table("T_Role")]
    public class Role : BaseEntity
    {
        [Key]
        [Required]
        public int RoleId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Title { get; set; }


        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Admin> Admins { get; set; }

    }
}
