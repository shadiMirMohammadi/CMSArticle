using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GSD.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using CMSArticle.App_Start;

namespace CMSArticle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfiguration.RegisterBundle(BundleTable.Bundles);


            AutoMapperConfig.Configuration();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var persianCulture = new PersianCulture();
            persianCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd";
            persianCulture.DateTimeFormat.LongDatePattern = "dddd d MMMM yyyy";
            persianCulture.DateTimeFormat.AMDesignator = "ق.ظ";
            persianCulture.DateTimeFormat.PMDesignator = "ب.ظ";
            Thread.CurrentThread.CurrentCulture = persianCulture;
            Thread.CurrentThread.CurrentUICulture = persianCulture;
        }
    }
}
