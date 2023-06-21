using Microsoft.VisualStudio.TestTools.UnitTesting;
using VuelingExam.Application.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using Moq;
using VuelingExam.Infrastucture.Repository.Contracts;

namespace VuelingExam.Application.Service.Implementation.Tests
{
    [TestClass()]
    public class FizzBuzzAppServiceTests
    {
        [TestMethod()]
        public void FizzBuzzGenerateTest()
        {
            using (var moq = AutoMock.GetLoose())
            {
                // Arrange
                var start = 1;
                var limit = 5;

                var expectedResult = new List<string> { "1", "2", "fizz", "4", "buzz" };

                moq.Mock<IFizzBuzzRepository>().Setup(repo => repo.AddToList(It.IsAny<List<string>>()));

                var fizzBuzzService = moq.Create<FizzBuzzAppService>();

                // Act
                var result = fizzBuzzService.FizzBuzzGenerate(start, limit);

                // Assert
                CollectionAssert.AreEqual(expectedResult, result);
                moq.Mock<IFizzBuzzRepository>().Verify(repo => repo.AddToList(It.IsAny<List<string>>()), Times.Once);
            }
        }
    }
}