using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSArticle.ModelsLayer;
using CMSArticle.ModelsLayer.Context;

namespace CMSArticle.ServiceLayer
{
    public class ArticleService : EntityService<Article>, IArticleService
    {
        public ArticleService(CMSContext context) : base(context)
        {
        }
    }
}
