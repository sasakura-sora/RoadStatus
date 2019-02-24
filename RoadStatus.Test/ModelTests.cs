using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RoadStatus.Test
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class ModelTests
    {
        [Test]
        public void GivenRoadModel_Exists()
        {

            var model = new RoadStatus.Core.Domain.Road();

            Assert.IsNotNull(model);
        }

        [Test]
        public void GivenDefaultModel_RoadName_IsUndefined()
        {

            var model = new RoadStatus.Core.Domain.Road();

            Assert.AreEqual(string.Empty, model.Name);
        }

        [Test]
        public void GivenNamedModel_RoadName_IsSet()
        {

            var model = new RoadStatus.Core.Domain.Road("A2");

            Assert.AreEqual("A2", model.Name);
        }
    }
}
