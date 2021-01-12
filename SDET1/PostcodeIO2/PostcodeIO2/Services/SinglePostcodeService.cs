using System;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace PostcodesIO
{
	public class SinglePostcodeService
	{
		////Properties


		//The restsharp object which handles comms with the API (i.e. where we make our calls)
		public RestClient Client { get; set; }

		//A JObject representing the JSON response
		public JObject PostcodeSingleResponseContent { get; set; }

		//The postcode used in our API request!!
		public string PostcodeSelected { get; set; }

		public SinglePostcodeService()
		{
			//Our client property is equaly to a new RestClient (which is part of the RestSharp library)
			//Creating a URI object and get the object from the APpConfigReader class we created
			// Encapsulating all the info we need to make our API call""
			// RestClient allows you to send authenticated HTTP requests
			Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
		}

		//method that makes our api request and stores it.
		public void GetSinglePostCode(string postcode)
		{
			//set up a request object. Will store request info.
			var request = new RestRequest();

			//Add header - we want our request to be in JSON
			request.AddHeader("Content-Type", "application/json");

			// Store our variable postcode in our property - Postcodeselected
			PostcodeSelected = postcode;

			// Adding a resource to the request
			request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

			//Making a request call and we get back a reponse as an IRestResponse
			var response = Client.Execute(request);

			//We are pasring a JSON string from response content
			PostcodeSingleResponseContent = JObject.Parse(response.Content);
		}

	}
}
