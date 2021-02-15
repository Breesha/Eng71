using NUnit.Framework;
using System.Threading;

namespace BootsSeleniumPOM
{
    public class Boots_No7ShopAll_Tests
    {

        public Boots_Website Boots_Website { get; } = new Boots_Website("Chrome");


        



        [OneTimeTearDown]
        public void Cleanup()
        {
            //Quit this driver, closing every assocciated window
            Boots_Website.SeleniumDriver.Quit();
            Boots_Website.SeleniumDriver.Dispose();

        }
    }
}
