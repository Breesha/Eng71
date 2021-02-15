using NUnit.Framework;
using CodeFromNorthwindBusiness;
using Microsoft.EntityFrameworkCore;
using CodeFromNorthwindModel;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindMoqTests
{
    //Using Fakes
    public class Tests
    {
        private CustomerService _sut;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<NorthwindContext>()
                .UseInMemoryDatabase(databaseName: "Example_DB")
            .Options;

            var context = new NorthwindContext(options);

            _sut = new CustomerService(context);

            _sut.CreateCustomer(new Customers { CustomerId = "MANDA", ContactName = "Nish Mandal", CompanyName = "Sparta Global", Country = "Uk", City = "Birmingham" });
            _sut.CreateCustomer(new Customers { CustomerId = "FRENC", ContactName = "Cathy French", CompanyName = "Sparta Global", Country = "Uk", City = "Birmingham" });
            _sut.CreateCustomer(new Customers { CustomerId = "SIMPS", ContactName = "Homer Simpson", CompanyName = "Nuclear Power Plant", Country = "USA", City = "Springfield" });
            _sut.CreateCustomer(new Customers { CustomerId = "SANCH", ContactName = "Rick Sanchez", CompanyName = "Adult Swin", Country = "USA", City = "N/A" });
        }

        [Test]
        public void GivenAnExistingCustomerID_WhenCallingGetCustomerIDMethod_ShouldReturnACustomerObject()
        {
            Assert.That(_sut.GetCustomerById("MANDA"), Is.Not.Null);
        }

        [Test]
        public void GivenAnInvalidCustomerID_WhenCallingGetCustomerIDMethod_ShouldReturnACustomerObject()
        {
            Assert.That(_sut.GetCustomerById("XYZ"), Is.Null);
        }

        [Test]
        public void GivenACustomerIDOfACustomerThatExists_WhenCallingGetCustomerIDMethod_ShouldReturnACustomerContactName()
        {
            Assert.That(_sut.GetCustomerById("MANDA").ContactName, Does.Contain("Nish"));
        }

        [Test]
        public void WhenIDeleteACustomerFromTheDatabase_ThenTheCustomerTableShouldHaveOneLessCustomer()
        {
            var customeBefore = _sut.GetCustomerList().Count();
            _sut.DeleteCustomer("MANDA");
            var customerAfter = _sut.GetCustomerList().Count();
            Assert.That(customerAfter, Is.EqualTo(customeBefore-1));
        }

        [Test]
        public void WhenICreateACustomer_ThenTheCustomerTableShouldHaveOneMoreCustomer()
        {
            var customeBefore = _sut.GetCustomerList().Count();
            _sut.CreateCustomer(new Customers {CustomerId= "FOXTO", ContactName= "Breesha Foxton", CompanyName= "Sparta Global"});
            var customerAfter = _sut.GetCustomerList().Count();
            Assert.That(customerAfter, Is.EqualTo(customeBefore + 1));
        }

        [TearDown]
        public void TearDown()
        {
            //Only using method for simplicity for example, should write it out
            _sut.DeleteCustomer("MANDA");
            _sut.DeleteCustomer("FRENC");
            _sut.DeleteCustomer("SIMPS");
            _sut.DeleteCustomer("SANCH");
            _sut.DeleteCustomer("FOXTO");
        }
    }
}