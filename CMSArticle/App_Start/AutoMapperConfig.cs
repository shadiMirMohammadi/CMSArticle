using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CMSArticle.ModelsLayer;
using CMSArticle.Views.ViewModels;

namespace CMSArticle.App_Start
{
    public class AutoMapperConfig
    {
        public static IMapper mapper;

        public static void Configuration()
        {
            MapperConfiguration configuration = new MapperConfiguration(t =>
            {
                t.CreateMap<Category,CategoryViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                t.CreateMap<CategoryViewModel,Category>().IgnoreAllPropertiesWithAnInaccessibleSetter();

                t.CreateMap<Article, ArticleViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                t.CreateMap<ArticleViewModel, Article>().IgnoreAllPropertiesWithAnInaccessibleSetter();

                t.CreateMap<Comment, CommentViewModel>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                t.CreateMap<CommentViewModel, Comment>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            });
            mapper = configuration.CreateMapper();
        }
    }
}