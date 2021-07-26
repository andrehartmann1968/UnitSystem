using AH.UnitSystem.Interface;
using AH.UnitSystem.Interface.UnitConverters;
using AH.UnitSystem.SI.Interface;

namespace AH.UnitSystem.SI
{
    /// <summary>
    /// This class provides factory methods for the clients of this library.
    /// That way, the actual constructors and implementing types are hidden.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// This method creates and returns a new instance of
        /// <see cref="ISystèmeInternational"/>.
        /// </summary>
        public static ISystèmeInternational NewSI(
            IPhysicalQuantityGroupRWFactory pPhysicalQuantityGroupFactory,
            IPhysicalUnitFactory pPhysicalUnitFactory,
            IIdentityUnitConverter pIdentityUnitConverter
        ) => new SystèmeInternational(
                pPhysicalQuantityGroupFactory,
                pPhysicalUnitFactory,
                pIdentityUnitConverter
            );
    }
}
