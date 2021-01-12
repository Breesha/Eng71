using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace PostcodesIO
{
    public class SinglePostcodeServiceTests
    {
        SinglePostcodeService _singlePostcodeService = new SinglePostcodeService();
        
        public SinglePostcodeServiceTests()
        {
            _singlePostcodeService.GetSinglePostcode("se120nb");
        }

        [Test]
        public void StatusIs200()
        {
            var ex = _singlePostcodeService.PostcodeSingleResponseContent["status"];
            Assert.That(_singlePostcodeService.PostcodeSingleResponseContent["status"].ToString(), Is.EqualTo("200"));
        }
    }
}
