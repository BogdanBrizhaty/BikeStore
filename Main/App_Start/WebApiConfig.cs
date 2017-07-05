﻿using Main.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Main
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new ProductsMetadataHeaderFilter());
            //GlobalConfiguration.Configuration.DependencyResolver = new 
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
