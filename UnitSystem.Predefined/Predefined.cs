using AH.UnitSystem.Interface;
using AH.UnitSystem.Predefined.Interface;

namespace AH.UnitSystem.Predefined
{
    class Predefined : IPredefined
    {
        public Predefined()
        {

        }

        public ITime Time => InternalTime;
        internal Time InternalTime { get; } = new Time();

        public ILength Length { get; }
        = new Length();

        public IForce Force { get; }
        = new Force();

        public IPressure Pressure { get; }
        = new Pressure();

        public ITemperature Temperature { get; }
        = new Temperature();

        public ISpeed Speed { get; }
        = new Speed();
        public IElectricCharge ElectricCharge { get; }
        = new ElectricCharge();

        public PhysicalValue GravitationalConstant { get; set;}
    }
}
