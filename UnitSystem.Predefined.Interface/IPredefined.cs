using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined.Interface
{
    /// <summary>
    /// This interface describes information provided by the
    /// <see cref="IUnitSystem"/> when <see cref="IUnitSystem.InitializePredefined()"/>
    /// it has been executed successfully.
    /// </summary>
    public interface IPredefined
    {
        /// <summary>
        /// This property contains a collection of predefined objects related to
        /// time.
        /// </summary>
        public ITime Time { get; }

        /// <summary>
        /// This property contains a collection of predefined objects related to
        /// length.
        /// </summary>
        public ILength Length { get; }

        /// <summary>
        /// This property contains a collection of predefined objects related to
        /// force.
        /// </summary>
        public IForce Force { get; }

        /// <summary>
        /// This property contains a collection of predefined objects related to
        /// prressure.
        /// </summary>
        public IPressure Pressure { get; }

        /// <summary>
        /// This property contains a collection of predefined objects related to
        /// temperature.
        /// </summary>
        public ITemperature Temperature { get; }

        /// <summary>
        /// This property contains a collection of predefined objects related to
        /// speed.
        /// </summary>
        public ISpeed Speed { get; }

        /// <summary>
        /// This property contains a collection of predefined objects related to
        /// electric charge.
        /// </summary>
        public IElectricCharge ElectricCharge { get; }

        /// <summary>
        /// The gravitational constant according to
        /// https://en.wikipedia.org/wiki/Gravitational_constant
        /// </summary>
        public PhysicalValue GravitationalConstant { get; set; }

    }
}
