using NUnit.Framework;

namespace AH.UnitSystem.SI.Tests
{
    [TestFixture]
    public class SystèmeInternationalTests
    {
        [Test]
        public void InstantiationTests()
        {
            var @is = Factory.NewSI();
        }
    }
}
