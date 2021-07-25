using System.Collections.Generic;

namespace AH.UnitSystem.Interface
{
    /// <summary>
    /// This interface describes the unit system as designed by this library.
    /// 
    /// A unit system manages SI units, custom units for an application domain and
    /// constants of nature.
    /// </summary>
    public interface IUnitSystem
    {
        ///// <summary>
        ///// This property provides access to the standards defined in the SI system.
        ///// It will only be non-null when <see cref="InitializeSI()"/> has been
        ///// executed successfully.
        ///// </summary>
        //public ISystèmeInternational SI { get; }

        ///// <summary>
        ///// This property provides access to the predefined definitions.
        ///// It will only be non-null when <see cref="InitializePredefined()"/> has been
        ///// executed successfully.
        ///// </summary>
        //public IPredefined Predefined { get; }

        ///// <summary>
        ///// This method initializes the SI definitions in this instance. After successful
        ///// initialization, <see cref="SI"/> will be non-null.
        ///// </summary>
        //void InitializeSI();
        ///// <summary>
        ///// This method initializes the predefined definitions in this instance. After successful
        ///// initialization, <see cref="Predefined"/> will be non-null.
        ///// </summary>
        //void InitializePredefined();

        /// <summary>
        /// This method registers the given unit with the given group.
        /// </summary>
        void Register(
            IPhysicalQuantity pQuantity,
            IPhysicalUnit pUnit
        );

        ///// <summary>
        ///// This method creates a new physical value of this physical quantity with the given value
        ///// in the given unit. The unit must be a registered unit with the quantity. A unit conversion
        ///// to the underlying SI will be performed.
        ///// </summary>
        //PhysicalValue CreatePhysicalValue(
        //    double pValue,
        //    IPhysicalUnit pUnit
        //);

        /// <summary>
        /// This method creates a new unit got the given quantity group.
        /// The unit is registered with the quantity group and returned
        /// to the caller.
        /// </summary>
        IPhysicalUnit CreateAndRegisterUnit(
            IPhysicalQuantity pGroup,
            string pName,
            string pSymbol,
            double pConversionFactorToSI
        );

        ///// <summary>
        ///// This method registers a new unit with the unit system. The
        ///// instance created is returned by the method.
        ///// </summary>
        //IPhysicalUnit RegisterUnit(
        //    IPhysicalQuantity pQuantity,
        //    string pName,
        //    string pSymbol
        //);

        //void RegisterUnit(
        //    IPhysicalQuantity pQuantity,
        //    IPhysicalUnit pUnit
        //);

        /// <summary>
        /// This method registers a new physical quantity with the unit system. The
        /// instance created is returned by the method.
        /// </summary>
        /// <param name="pUnits">
        /// The units applicable to the new physical quantity. They must be units of the
        /// group.
        /// </param>
        IPhysicalQuantity CreateAndRegisterPhysicalQuantity(
            IPhysicalQuantityGroup pGroup,
            string pName,
            IEnumerable<IPhysicalUnit> pUnits = null
        );

        ///// <summary>
        ///// This method collects and returns all registered units for the given quantity.
        ///// It does not return the SI unit. That unit is available via the
        ///// <see cref="IPhysicalQuantity.SIUnit"/> property.
        ///// </summary>
        //IReadOnlyCollection<IPhysicalUnit> GetRegisteredPhysicalUnits(
        //    IPhysicalQuantity pQuantity
        //);
    }
}
