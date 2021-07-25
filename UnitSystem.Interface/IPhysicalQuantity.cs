using System.Collections.Generic;

namespace AH.UnitSystem.Interface
{
    /// <summary>
    /// This interface describes a physical quantity PQ such as weight, mass,
    /// distance, length, wavelength, frequency.
    /// 
    /// Every PQ belongs to a physical quantity group PQC, from which it
    /// inherits its standard unit <see cref="SIUnit"/>.
    /// </summary>
    public interface IPhysicalQuantity
    {
        /// <summary>
        /// This is the name of the physical quantity. It is assigned when
        /// the quantity is created and does not change throughout its lifetime.
        /// Inside a unit system the name must be unique, i.e. there cannot be
        /// two quantities with the same name registered to the same unit
        /// system.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The underlying SI unit of this quantity; inherited from the PQG.
        /// </summary>
        IPhysicalUnit SIUnit { get; }

        /// <summary>
        /// The PQG that this PQ belongs to. In case the instance represents
        /// a PQG, the value in this property may be null or this.
        /// </summary>
        IPhysicalQuantityGroup Group { get; }

        /// <summary>
        /// This property returns an enumerable that can be used to enumerate the
        /// available units of the group. Available units are the <see cref="SIUnit"/>
        /// and the registered units.
        /// </summary>
        IEnumerable<IPhysicalUnit> AvailableUnits { get; }

    }
}