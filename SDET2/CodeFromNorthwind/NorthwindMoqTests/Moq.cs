using System;
using CodeFromNorthwindBusiness;
using CodeFromNorthwindModel;
using NUnit.Framework;
using Moq;

namespace NorthwindMoqTests
{
    class Moq
    {
        private CRUDManager _sut;

        //// USING MOQ AS A DUMMY
        [Ignore("This will fail")]
        [Test]
        public void BeAbleToBeConstructed()
        {
            //Arrange and Act
            _sut = new CRUDManager(null);
            //Assert
            Assert.That(_sut, Is.InstanceOf<CRUDManager>());
        }

        [Test]
        public void BeAbleToBeConstructeUsingMoq()
        {
            //Construct a mock instance of Type ICutomerService
            var mockCustomerService = new Mock<ICustomerService>();

            _sut = new CRUDManager(mockCustomerService.Object);

            Assert.That(_sut, Is.InstanceOf<CRUDManager>());
        }

        //// USING MOQS AS STUBS
        [Test]
        public void GetCustomer_ReturnDesiredName()
        {
            //Construct a mock instance of Type ICutomerService
            var mockCustomerService = new Mock<ICustomerService>();
            var exampleCustomer = new Customers { ContactName="Nish Mandal"};
            mockCustomerService.Setup(c => c.GetCustomerById("MANDA")).Returns(exampleCustomer);

            _sut = new CRUDManager(mockCustomerService.Object);
            var result = _sut.RetrieveSelectedCustomer("MANDA").ContactName;
            Assert.That(result, Is.EqualTo("Nish Mandal"));
        }

        [Test]
        public void DeleteCustomerMethod_IsCalled_WithCorrectParameters()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            _sut = new CRUDManager(mockCustomerService.Object);
            //Act (invoke mock)
            _sut.DeleteCustomer("MANDA");
            mockCustomerService.Verify(x => x.DeleteCustomer("MANDA"));
            mockCustomerService.Verify(x => x.DeleteCustomer("MANDA"), Times.Exactly(1));
        }

        [Test]
        public void CustomerDeleteMethod_IsNotCalled_WhenInvokingCRUDManagerCreateMethod()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            _sut = new CRUDManager(mockCustomerService.Object);
            //Act (invoke mock)
            _sut.CreateCustomer("MANDA", "Nish Mandal", "Spart Global");
            mockCustomerService.Verify(x => x.DeleteCustomer(It.IsAny<string>()), Times.Never);
        }


        ////Strict and Loose Behaviour
        [Test]
        public void GetCustomerInCRUDManager_CallsTheCorrectMethodWithCorrectParameters_OfICustomerServiceSTRICT()
        {
            //Construct a mock instance of Type ICutomerService
            var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Strict);
            mockCustomerService.Setup(c => c.GetCustomerById("MANDA")).Returns(It.IsAny<Customers>);
            _sut = new CRUDManager(mockCustomerService.Object);
            _sut.RetrieveSelectedCustomer("MANDA");
        }

        [Test]
        public void GetCustomerInCRUDManager_CallsTheCorrectMethodWithCorrectParameters_OfICustomerServiceLOOSE()
        {
            //Construct a mock instance of Type ICutomerService
            var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Loose);
            mockCustomerService.Setup(c => c.GetCustomerById("MANDA")).Returns(It.IsAny<Customers>);
            _sut = new CRUDManager(mockCustomerService.Object);
            _sut.RetrieveSelectedCustomer("FRENC");
        }
    }
}
