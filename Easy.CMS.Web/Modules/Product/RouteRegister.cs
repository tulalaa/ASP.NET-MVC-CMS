﻿using Easy.Web.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;


namespace Easy.CMS.Product
{
    public class RouteRegister : IRouteRegister
    {
        public IEnumerable<RouteDescriptor> Regist()
        {
            List<RouteDescriptor> routes = new List<RouteDescriptor>();
            routes.Add(new RouteDescriptor()
            {
                RouteName = "productAdmin",
                Url = "admin/{controller}/{action}",
                Defaults = new { controller = "product", action = "home", module = "product" },
                Namespaces = new string[] { "Easy.CMS.Product.Controllers" },
                Priority = 1
            });
            return routes;
        }
    }
}