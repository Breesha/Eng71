using System;
using System.Configuration;

//This allows us to access the app.config file 
namespace PostcodesIO
{
	//static and public so it cannot be overwritten and public so we can access it
	public static class AppConfigReader
	{
		//Goes to the APpSettings with the tagged URL so it can be accessed in our app
		public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];

	}
}
