using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined.Interface
{
    public interface ILength
    {
        public IPhysicalUnit Ångström { get; }
        public IPhysicalUnit NauticalMile { get;  }
        public IPhysicalUnit Mile { get; set ; }
    }
}
