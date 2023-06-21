using Microsoft.VisualStudio.TestTools.UnitTesting;
using VuelingExam.Infrastucture.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using Moq;
using VuelingExam.Infrastucture.Utils.Contracts;

namespace VuelingExam.Infrastucture.Repository.Implementations.Tests
{
    [TestClass()]
    public class FizzBuzzRepositoryTests
    {
        [TestMethod()]
        public void AddToListTest()
        {
            using (var mock = AutoMock.GetStrict())
            {
                var result = new List<string> { "Fizz", "Buzz" };
                var writeListMock = mock.Mock<IWriteList>();
                writeListMock.Setup(wl => wl.WriteListToFile(result));

                var repository = mock.Create<FizzBuzzRepository>();

                // Act
                repository.AddToList(result);

                // Assert
                writeListMock.Verify(wl => wl.WriteListToFile(result), Times.Once);
            }
        }
    }
}