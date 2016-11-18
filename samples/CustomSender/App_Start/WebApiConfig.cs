using System.Web.Http;

namespace CustomSender
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Load basic support for sending WebHooks
            config.InitializeCustomWebHooks();

            // Load Azure Storage or SQL for persisting subscriptions
            // If we don't put anything...then it uses in memory storage!!!!!!!
            //config.InitializeCustomWebHooksAzureStorage();
            config.InitializeCustomWebHooksSqlStorage();

            // Load Web API controllers for managing subscriptions
            config.InitializeCustomWebHooksApis();
        }
    }
}















//Enable-Migrations -ContextAssemblyName Microsoft.AspNet.WebHooks.Custom.SqlStorage
//Add-Migration WebHookStoreInitialDB
//Update-Database
