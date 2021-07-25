using AH.UnitSystem.Predefined.Interface;
using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined
{
    class ElectricCharge : IElectricCharge
    {
        public IPhysicalQuantityGroup PhysicalQuantityGroup { get; set; }
        public IPhysicalUnit Coulomb { get; set; }
        public PhysicalValue ElementaryCharge { get; set; }
    }
}
