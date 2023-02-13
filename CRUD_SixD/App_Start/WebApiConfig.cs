﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CRUD_SixD
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
                   .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                               "text/html",
                               StringComparison.InvariantCultureIgnoreCase,
                               true,
                               "application/json")
                   );
        }
    }
}
