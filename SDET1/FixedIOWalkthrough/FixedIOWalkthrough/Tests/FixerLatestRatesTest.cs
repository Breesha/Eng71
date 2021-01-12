using System;
using System.Threading;
using NUnit.Framework;

namespace FixerIOWalkthrough
{
	public class FixerLatestRatesTest
	{
		private FLService _fixerLatestRates = new FLService();

		[Test]
		public void WebCallSuccessCheck()
		{
			Assert.That(_fixerLatestRates.FixerLatestDTO.LatestRates.success);
		}
		[Test]
		public void WebCallSuccessCheckUsingJObject()
		{
			Assert.That(_fixerLatestRates.Json_rates["success"].ToString(), Is.EqualTo("True"));
		}

		[Test]
		public void NumberOfRates()
		{
			Assert.That(_fixerLatestRates.RatesCount(), Is.EqualTo(168));
		}

		[Test]
		public void CheckDate()
		{
			Assert.That(_fixerLatestRates.FixerLatestDTO.LatestRates.date, Is.EqualTo(DateTime.Now.ToString("yyyy-MM-dd")));
		}

		[Test]
		public void CheckGBPRatesIsMoreThanEuro()

		{
			Assert.That(_fixerLatestRates.CheckGBPIsMoreThanEUR());
		}

		[Test]
		public void CheckBase()
		{
			Assert.That(_fixerLatestRates.Json_rates["base"].ToString(), Is.EqualTo("EUR"));
		}
	}


}
