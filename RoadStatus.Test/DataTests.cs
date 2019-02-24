using Moq;
using NUnit.Framework;
using RoadStatus.Core;
using RoadStatus.Core.Data;
using System.Diagnostics.CodeAnalysis;

namespace RoadStatus.Test
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void GivenId_BuildQuerystring_IsValid()
        {
            var config = new Mock<IConfig>();
            config.Setup(c => c.AppId()).Returns("123");
            config.Setup(c => c.DeveloperId()).Returns("test_key");

            var data = new TflClient(config.Object);

            var result = data.BuildQueryString();

            Assert.AreEqual("?app_id=123&app_key=test_key", result);
        }

    }
}
