using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Azure.KeyVault;

namespace TokeniserPOC
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var kv = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(KeyVaultHelpers.GetToken));

            var sec = kv.GetSecretAsync(WebConfigurationManager.AppSettings["SecretUri"]).Result;

            //I put a variable in a Utils class to hold the secret for general  application use.
            KeyVaultHelpers.EncryptSecret = sec.Value;

        }
    }
}
