using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

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
            var data = new RoadStatus.Core.Data();

            //Act
            var result = data.Get("A2");

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
