using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;

namespace FixerIOWalkthrough
{
	public class FLService
	{
		//Instance of the call manager that manages the call to the API to get the data
		public FixerLatestCallManager FixerLatestCallManager { get; set; } = new FixerLatestCallManager();

		//Deserialises our call into the format of our specified model
		public FixerLatestDTO FixerLatestDTO { get; set; } = new FixerLatestDTO();

		//the last set of rates retrieved
		public string LiveRates { get; set; }

		public JObject Json_rates { get; set; }



		public FLService()
		{
			//The api call is set to the LiveRates property
			LiveRates = FixerLatestCallManager.GetLatestRates();


			//Take the live rates and deserialise it to a JObject
			Json_rates = JsonConvert.DeserializeObject<JObject>(LiveRates);

			//Another version of the response we get back from the HTTP maanger as a DTO
			FixerLatestDTO.DeserializeRates(LiveRates);
		}

		public int RatesCount()
		{
			var count = 0;
			foreach (var item in Json_rates["rates"])
			{
				count++;
			}

			return count;
		}

		public bool CheckGBPIsMoreThanEUR()
		{
			if (FixerLatestDTO.LatestRates.rates.GBP < 1)

				return true;

			else return false;
		}

	}


}
