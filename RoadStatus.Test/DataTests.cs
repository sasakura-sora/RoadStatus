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
            var client = new Mock<HttpClient>();
            var response = new HttpResponseMessage() { Content = new StringContent("") };
            client.Setup(c => c.GetAsync("A2")).ReturnsAsync(response);

            var data = new RoadStatus.Core.Data(client.Object);

            //Act
            var result = data.Get("A2");

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
