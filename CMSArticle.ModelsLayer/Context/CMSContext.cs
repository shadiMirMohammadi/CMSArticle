using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CMSArticle.ModelsLayer.Context
{
    public class CMSContext : DbContext
    {
        public DbSet<AdminRole> Admins { get; set; }
        public DbSet<UserRole> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
