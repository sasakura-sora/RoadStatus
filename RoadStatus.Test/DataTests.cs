using Moq;
using NUnit.Framework;
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

            var data = new TflClient(client, "", "");

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

            var data = new TflClient(client, "", "");

            //Act
            var result = data.Get("A233");

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        public void GivenId_BuildQuerystring_IsValid()
        {
            var data = new TflClient(null, "123", "test_key");


            var result = data.BuildQueryString();

            Assert.AreEqual("?app_id=123&app_key=test_key", result);
        }

    }
}
