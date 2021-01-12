using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace PostcodesIO
{

    public static class AppConfigReader
    {
        //Goes to the AppSettings with the tagged URL
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
