using Moq;
using NUnit.Framework;
using RoadStatus.Core;
using RoadStatus.Core.Data;
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

            var data = new TflClient(client, null);

            //Act
            var result = data.Get("A2");

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void GivenBadUrl_ReturnsNull()
        {
            //Arrange
            var client = new HttpClient();

            var data = new TflClient(client, null);

            //Act
            var result = data.Get("A233");

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        public void GivenId_BuildQuerystring_IsValid()
        {
            var config = new Mock<IConfig>();
            config.Setup(c => c.AppId()).Returns("123");
            config.Setup(c => c.DeveloperId()).Returns("test_key");

            var data = new TflClient(null, config.Object);


            var result = data.BuildQueryString();

            Assert.AreEqual("?app_id=123&app_key=test_key", result);
        }

    }
}
