namespace AH.UnitSystem.Interface
{
    /// <summary>
    /// This interface describes a physical unit such as Ångström or gallon.
    /// </summary>
    public interface IPhysicalUnit
    {
        /// <summary>
        /// The name of the unit. This implementation does not currently support
        /// multilingual operations (localisations, cultures).
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The description of the unit.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The unit symbol.  This implementation does not currently support
        /// multilingual operations (localisations, cultures).
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// The underlying SI unit. It may come from a quantity that was
        /// available at the time when this instance was created or it may
        /// be assigned directly for units without quantities or it may be
        /// null, in which case this unit is treated like an SI unit.
        /// </summary>
        IPhysicalUnit SIUnit { get; }

        /// <summary>
        /// The converter that can be used to convert values between this
        /// unit and the underlying SI unit. The converter may be null
        /// when a conversion is not wanted, not possible or when this
        /// instance is an SI unit.
        /// </summary>
        IUnitConverter Converter { get; }

        /// <summary>
        /// This property returns a string representation of this instance that
        /// can be used for logging, debugging, trouble-shooting.
        /// </summary>
        string Display { get; }
    }
}
