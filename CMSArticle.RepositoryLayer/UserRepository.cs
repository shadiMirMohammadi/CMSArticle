﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSArticle.ModelsLayer;
using CMSArticle.ModelsLayer.Context;

namespace CMSArticle.RepositoryLayer
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CMSContext context) : base(context)
        {
        }
    }
}
