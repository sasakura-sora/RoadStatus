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

            data.Setup(d => d.Get("A2")).Returns(new RoadData { id = "A2" });
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

        [Test]
        public void GetRoad_WithData_SetsName()
        {
            var data = new Mock<ITflClient>();

            const string name = "A4";

            data.Setup(d => d.Get(name)).Returns(new RoadData { displayName = name });
            var service = new RoadService(data.Object);

            var road = service.GetStatus(name);

            Assert.AreEqual(name, road.Name);
        }

        [Test]
        public void GetRoad_WithData_SetsStatus()
        {
            var data = new Mock<ITflClient>();

            const string name = "A4";

            data.Setup(d => d.Get(name)).Returns(new RoadData { displayName = name, statusSeverity = "Bad" });
            var service = new RoadService(data.Object);

            var road = service.GetStatus(name);

            Assert.AreEqual("Bad", road.Status);
        }

        [Test]
        public void GetRoad_WithData_SetsDescription()
        {
            var data = new Mock<ITflClient>();

            const string name = "A4";

            data.Setup(d => d.Get(name)).Returns(new RoadData { displayName = name, statusSeverityDescription = "Lots of delays" });
            var service = new RoadService(data.Object);

            var road = service.GetStatus(name);

            Assert.AreEqual("Lots of delays", road.Description);
        }
    }
}
