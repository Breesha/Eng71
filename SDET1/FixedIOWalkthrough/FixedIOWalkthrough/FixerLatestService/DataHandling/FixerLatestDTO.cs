using Newtonsoft.Json;

namespace FixerIOWalkthrough
{
    public class FixerLatestDTO
    {

        public LatestRatesRoot LatestRates { get; set; }
        public void DeserializeRates(string latestRatesResponse)
        {
            LatestRates = JsonConvert.DeserializeObject <LatestRatesRoot>(latestRatesResponse);
        }
    }
}
