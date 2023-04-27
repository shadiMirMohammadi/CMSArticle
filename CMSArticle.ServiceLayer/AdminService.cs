using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSArticle.ModelsLayer;
using CMSArticle.ModelsLayer.Context;

namespace CMSArticle.ServiceLayer
{
    public class AdminService : EntityService<Admin>, IAdminService
    {
        public AdminService(CMSContext context) : base(context)
        {
        }
    }
}
