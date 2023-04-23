using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSArticle.ModelsLayer;

namespace CMSArticle.RepositoryLayer
{
    public interface ICommentRepository :IGenericRepository<Comment>
    {
    }
}
