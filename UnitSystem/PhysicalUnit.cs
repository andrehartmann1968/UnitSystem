using System.Diagnostics;
using AH.UnitSystem.Interface;

namespace AH.UnitSystem
{
    [DebuggerDisplay("{" + nameof(Display) + "}")]
    class PhysicalUnit : IPhysicalUnit
    {
        internal PhysicalUnit(
            string pName,
            string pSymbol,
            IUnitConverter pConverter,
            IPhysicalUnit pSIUnit
        )
        {
            Name = pName;
            Symbol = pSymbol;
            Converter = pConverter;
            SIUnit = pSIUnit;
        }

        internal PhysicalUnit(
            string pName,
            string pSymbol,
            double pScalingFactor,
            IPhysicalQuantity pQuantity
        ) : this(
            pName,
            pSymbol, 
            new UnitConverters.ScalingUnitConverter(pScalingFactor),
            pQuantity?.SIUnit
        ) {
        }

        internal PhysicalUnit(
            string pName,
            string pSymbol,
            double pOffset,
            double pScalingFactor,
            IPhysicalQuantity pQuantity
        ) : this(
            pName,
            pSymbol,
            new UnitConverters.LinearUnitConverter(pOffset, pScalingFactor),
            pQuantity?.SIUnit
        )
        {
        }

        /// <inheritdoc cref="IPhysicalUnit.Name"/>
        public string Name { get; }
        /// <inheritdoc cref="IPhysicalUnit.Description"/>
        public string Description { get; }

        /// <inheritdoc cref="IPhysicalUnit.Symbol"/>
        public string Symbol { get; }

        /// <inheritdoc cref="IPhysicalUnit.Converter"/>
        public IUnitConverter Converter { get; }

        /// <inheritdoc cref="IPhysicalUnit.SIUnit"/>
        public IPhysicalUnit SIUnit { get; }

        /// <inheritdoc cref="IPhysicalUnit.Display"/>
        public string Display => $"{Symbol}";
    }
}
