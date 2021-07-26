using AH.UnitSystem.Interface;
using AH.UnitSystem.SI.Interface;

namespace AH.UnitSystem.SI.Interface
{
    public interface IPhysicalQuantityGroupRWFactory
    {
        IPhysicalQuantityGroupRW Create(
            string pName,
            Dimension pDimension,
            string pQuantitySymbol,
            string pDimensionSymbol
        );
    }
}
