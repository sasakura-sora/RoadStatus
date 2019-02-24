using Moq;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace RoadStatus.Test
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void GivenURL_ReturnsData()
        {
            //Arrange
            var client = new HttpClient();

            var data = new RoadStatus.Core.Data(client);

            //Act
            var result = data.Get("A2");

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
