using LibraryAppUOW.WebApi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LibraryAppUOW.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

         

            config.Filters.Add(new UnitOfWorkActionFilter());

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
        }
    }
}
