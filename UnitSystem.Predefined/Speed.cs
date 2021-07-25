using AH.UnitSystem.Interface;
using AH.UnitSystem.Predefined.Interface;

namespace AH.UnitSystem.Predefined
{
    class Speed : ISpeed
    {
        public IPhysicalQuantityGroup PhysicalQuantityGroup  { get; set; }
        public IPhysicalUnit Kph  { get; set; }
        public IPhysicalUnit Mph  { get; set; }
        public IPhysicalUnit Mile  { get; set; }
        public PhysicalValue SpeedOfLight  { get; set; }
    }
}
