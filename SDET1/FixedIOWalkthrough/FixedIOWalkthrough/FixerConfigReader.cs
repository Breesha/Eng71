using System;
using System.Configuration;

namespace FixerIOWalkthrough
{
    public static class FixerConfigReader
    {
        //call configuration manager so when we call static manager, we can call th info from our app.config
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly string ApiUrlMod = ConfigurationManager.AppSettings["access_key_url_mod"];
    }
}
