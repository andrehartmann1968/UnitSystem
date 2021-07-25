using AH.UnitSystem.Interface;
using AH.UnitSystem.Predefined.Interface;

namespace AH. UnitSystem.Predefined
{
    class Length : ILength
    {
        public IPhysicalUnit Ångström { get; set; }
        public IPhysicalUnit NauticalMile { get; set; }
        public IPhysicalUnit Mile { get; set; }
    }
}
