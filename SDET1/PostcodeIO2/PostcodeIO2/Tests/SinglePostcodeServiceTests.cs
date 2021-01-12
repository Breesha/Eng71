using NUnit.Framework;

namespace PostcodesIO
{
	public class SinglePostcodeServiceTests
	{
		SinglePostcodeService _singlePostCodeService = new SinglePostcodeService();

		public SinglePostcodeServiceTests()
		{
			_singlePostCodeService.GetSinglePostCode("se120nb");
		}

		[Test]
		public void StatusIs200()
		{
			//var ex = _singlePostCodeService.PostcodeSingleResponseContent["status"];
			Assert.That(_singlePostCodeService.PostcodeSingleResponseContent["status"].ToString(), Is.EqualTo("200"));
		}

		[Test]
		public void CorrectPostcodeReturned()
		{
			var jtoken = _singlePostCodeService.PostcodeSingleResponseContent["result"]["postcode"];
			Assert.That(jtoken.ToString(), Is.EqualTo("SE12 0NB"));
		}

		[Test]
		public void CorrectAdminCountyReturned()
		{
			var jtoken = _singlePostCodeService.PostcodeSingleResponseContent["result"]["codes"]["admin_county"];
			Assert.That(jtoken.ToString(), Is.EqualTo("E99999999"));
		}
	}
}
