using Moq;
using NUnit.Framework;
using RoadStatus.Core;
using RoadStatus.Core.Data;
using RoadStatus.Core.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RoadStatus.Test
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class RoadServiceTests
    {
        [Test]
        public void GetRoad_WithData_ReturnsRoad()
        {
            var data = new Mock<ITflClient>();

            var service = new RoadService(data.Object);

            var road = service.GetStatus("A2");

            Assert.IsNotNull(road);
        }

        [Test]
        public void GetRoad_NoData_ReturnsRoad()
        {
            var data = new Mock<ITflClient>();

            data.Setup(d => d.Get("A2")).Returns((RoadData)null);

            var service = new RoadService(data.Object);

            var road = service.GetStatus("A2");

            Assert.IsNull(road);
        }

    }
}
