using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMSArticle.ModelsLayer
{
    [Table("T_User")]
    public class User : Person
    {
        public IEnumerable<Article> Articles { get; set; }
        public Role Role { get; set; }
        public IEnumerable<Comment> Comments { get; set; }

    }
}
