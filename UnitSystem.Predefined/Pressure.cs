using AH.UnitSystem.Interface;
using AH.UnitSystem.Predefined.Interface;

namespace AH.UnitSystem.Predefined
{
    class Pressure : IPressure
    {
        public IPhysicalQuantityGroup PhysicalQuantityGroup  { get; set; }
        public IPhysicalUnit Pascal  { get; set; }
        public IPhysicalUnit HectoPascal  { get; set; }
        public IPhysicalUnit KiloPascal  { get; set; }
        public IPhysicalUnit Atmosphere  { get; set; }
    }
}
