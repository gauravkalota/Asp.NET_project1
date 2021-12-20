using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TestRESTApiWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();



            // DATA route 
            //config.Routes.MapHttpRoute(
                //name: "DATA",
                //routeTemplate: "api/{controller}/{MYData}/{id}",
                 //defaults: new { id = RouteParameter.Optional },
                //defaults: new { controllers="DATA",id = RouteParameter.Optional },
                //constraints: new { id ="/d+" }
        
            //);




            // Default route
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
