using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSArticle.RepositoryLayer;
using CMSArticle.ModelsLayer;
using CMSArticle.ModelsLayer.Context;

namespace CMSArticle.ServiceLayer
{
    public class EntityService<T> : GenericRepository<T> where T : BaseEntity
    {
        public EntityService(CMSContext context) : base(context)
        {
        }
    }
}
