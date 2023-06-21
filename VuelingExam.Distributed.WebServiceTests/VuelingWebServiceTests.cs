using Microsoft.VisualStudio.TestTools.UnitTesting;
using VuelingExam.Distributed.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using Moq;
using VuelingExam.Application.Service.Contracts;
using log4net;

namespace VuelingExam.Distributed.WebService.Tests
{
    [TestClass()]
    public class VuelingWebServiceTests
    {
        [TestMethod()]
        public void FizzBuzzTest()
        {

            using (var moq = AutoMock.GetLoose())
            {
                // Arrange
                var expected = new List<string>() { "1", "2", "Fizz" }; // Aquí va la salida esperada.
                var mockFizzBuzzAppService = moq.Mock<IFizzBuzzAppService>();
                var mockLog = moq.Mock<ILog>();

                mockFizzBuzzAppService
                    .Setup(s => s.FizzBuzzGenerate(It.IsAny<int>(), It.IsAny<int>()))
                    .Returns(expected);

                var service = new VuelingWebService(mockFizzBuzzAppService.Object, mockLog.Object);

                // Act
                var actual = service.FizzBuzz("1");

                // Assert
                Assert.AreEqual(expected, actual);
                mockFizzBuzzAppService.Verify(s => s.FizzBuzzGenerate(It.IsAny<int>(), It.IsAny<int>()), Times.Once());
            }
        }
    }
}