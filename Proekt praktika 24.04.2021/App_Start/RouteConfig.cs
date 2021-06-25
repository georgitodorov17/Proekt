using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Proekt_praktika_24._04._2021
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
