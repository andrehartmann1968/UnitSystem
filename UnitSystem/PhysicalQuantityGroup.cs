using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AH.UnitSystem.Interface;
using AH.UnitSystem.SI.Interface;

namespace AH.UnitSystem
{
    [DebuggerDisplay("{" + nameof(Name) + "} [{" + nameof(SIUnit) + "}]")]
    class PhysicalQuantityGroup : PhysicalQuantity, IPhysicalQuantityGroup
    {
        internal PhysicalQuantityGroup(
            string pName,
            Dimension pDimension,
            string pQuantitySymbol,
            string pDimensionSymbol = null
        ):base(pName, null)
        {
            Dimension = pDimension;
            QuantitySymbol = pQuantitySymbol;
            DimensionSymbol = pDimensionSymbol ?? pQuantitySymbol;
            Group = this;
        }

        public Dimension Dimension { get; }
        public string QuantitySymbol { get; }
        public string DimensionSymbol { get; }
        public override IPhysicalUnit SIUnit { get; internal set; }
    }
}
