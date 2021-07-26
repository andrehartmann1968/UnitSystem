using AH.UnitSystem.SI.Interface;
using NUnit.Framework;

namespace AH.UnitSystem.Tests.UnitSystem
{
    [TestFixture]
    class UnitSystemTests
    {
        [TestCase(null)]
        public void InstantiationTests(
            ISystèmeInternational pSI
        )
        {
            var us = pSI == null ?
                Factory.NewUnitSystem()
                : Factory.NewUnitSystem(pSI);
        }

    }
}
