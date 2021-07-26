using AH.UnitSystem.Interface;
using AH.UnitSystem.SI.Interface;

namespace AH.UnitSystem
{
    /// <summary>
    /// This class provides factory methods for the clients of this library.
    /// That way, the actual constructors and implementing types are hidden.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// This method creates and returns a new instance of
        /// <see cref="IUnitSystem"/>.
        /// </summary>
        public static IUnitSystem NewUnitSystem()
            => new UnitSystem.UnitSystem(null);

        /// <summary>
        /// This method creates and returns a new instance of
        /// <see cref="IUnitSystem"/>.
        /// </summary>
        public static IUnitSystem NewUnitSystem(
            ISystèmeInternational pSystèmeInternational
        ) => new UnitSystem.UnitSystem(pSystèmeInternational);
    }
}
