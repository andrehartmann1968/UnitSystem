using AH.UnitSystem.Interface;
using AH.UnitSystem.Predefined.Interface;

namespace AH.UnitSystem.Predefined
{
    class Force : IForce
    {
        public IPhysicalQuantityGroup PhysicalQuantityGroup { get; set; }
        public IPhysicalUnit Newton { get; set; }
        public IPhysicalUnit Kilopond { get; set; }
    }
}
