using AH.UnitSystem.Interface;

namespace AH.UnitSystem.SI.Interface
{
    /// <summary>
    /// This interface models SI information provided by a <see cref="IUnitSystem"/>
    /// when it has been initialized for SI. There are properties for all SI
    /// dimensions and their units.
    /// </summary>
    public interface ISystèmeInternational
    {
        #region time
        /// <summary>
        /// The SI dimension/quantity group for time as defined in
        /// https://en.wikipedia.org/wiki/Time
        /// </summary>
        IPhysicalQuantityGroup Time { get; }

        /// <summary>
        /// This SI unit of time.
        /// </summary>
        IPhysicalUnit Second { get; }
        #endregion time

        IPhysicalQuantityGroup Length { get; }
        IPhysicalUnit Meter { get; }
        IPhysicalQuantityGroup Mass { get; }
        IPhysicalUnit Kilogram { get; }
        IPhysicalQuantityGroup ElectricCurrent { get; }
        IPhysicalUnit Ampere { get; }
        IPhysicalQuantityGroup ThermodynamicTemperature { get; }
        IPhysicalUnit Kelvin { get; }
        IPhysicalQuantityGroup AmountOfSubstance { get; }
        IPhysicalUnit Mole { get; }
        IPhysicalQuantityGroup LuminousIntensity { get; }
        IPhysicalUnit Candela { get; }

    }
}
