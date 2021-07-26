using AH.UnitSystem.Interface;
using AH.UnitSystem.Interface.UnitConverters;

namespace AH.UnitSystem.SI.Interface
{
    public interface IPhysicalUnitFactory
    {
        IPhysicalUnit Create(
            string pName,
            string pSymbol,
            IUnitConverter pConverter,
            IPhysicalUnit pDefaultUnit
        );
    }
}
