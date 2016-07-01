using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LibraryAppUOW.WebAPI.Helper;

namespace LibraryAppUOW.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new UnitofWorkActionFilter());
        }
    }
}
