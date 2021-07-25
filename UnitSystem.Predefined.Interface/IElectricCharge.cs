using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined.Interface
{
    /// <summary>
    /// This interface describes a collection of predefined objects related
    /// to electric charge.
    /// </summary>
    public interface IElectricCharge
    {
        /// <summary>
        /// The physical quantity group for electric charge
        /// according to https://en.wikipedia.org/wiki/Electric_charge.
        /// </summary>
        public IPhysicalQuantityGroup PhysicalQuantityGroup { get; }

        /// <summary>
        /// The SI derived unit Coulomb according to
        /// https://en.wikipedia.org/wiki/Coulomb.
        /// </summary>
        public IPhysicalUnit Coulomb { get; }

        /// <summary>
        /// The elementary charge (the electric charge carried by a single proton)
        /// according to https://en.wikipedia.org/wiki/Elementary_charge.
        /// </summary>
        public PhysicalValue ElementaryCharge { get; }

    }
}
