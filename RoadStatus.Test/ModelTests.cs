using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace RoadStatus.Test
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class ModelTests
    {
        [Test]
        public void GivenRoadModel_Exists()
        {
            var model = new Core.Domain.Road();

            Assert.IsNotNull(model);
        }

        [Test]
        public void GivenDefaultModel_RoadName_IsUndefined()
        {
            var model = new Core.Domain.Road();

            Assert.AreEqual(string.Empty, model.Name);
        }

        [Test]
        public void GivenNamedModel_RoadName_IsSet()
        {
            const string Name = "A2";

            var model = new Core.Domain.Road(Name, "", "");

            Assert.AreEqual(Name, model.Name);
        }

        [Test]
        public void GivenDefaultModel_RoadStatus_IsUndefined()
        {
            var model = new Core.Domain.Road();

            Assert.AreEqual(string.Empty, model.Status);
        }

        [Test]
        public void GivenNamedModel_RoadStatus_IsSet()
        {
            const string Status = "Good";

            var model = new Core.Domain.Road("", Status, "");

            Assert.AreEqual(Status, model.Status);
        }


        [Test]
        public void GivenDefaultModel_RoadDescription_IsUndefined()
        {
            var model = new Core.Domain.Road();

            Assert.AreEqual(string.Empty, model.Description);
        }

        [Test]
        public void GivenNamedModel_RoadDescription_IsSet()
        {
            const string Description = "No Exceptional Delays";

            var model = new Core.Domain.Road("", "", Description);

            Assert.AreEqual(Description, model.Description);
        }
    }
}
