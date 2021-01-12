using System;
using RestSharp;

namespace FixerIOWalkthrough
{
    public class FixerLatestCallManager
    {
        //the RestSharp object which handles the API calls

        private readonly IRestClient _client;

        public FixerLatestCallManager()
        {
            //Our _client firl is equal to a new RestSharp. We create a URI object or we can use a string URI.
            _client = new RestClient(FixerConfigReader.BaseUrl);
        }

        public string GetLatestRates()
        {
            var request = new RestRequest("/latest" + FixerConfigReader.ApiUrlMod + FixerConfigReader.ApiKey);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
