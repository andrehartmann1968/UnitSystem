using AH.UnitSystem.Interface;
using AH.UnitSystem.Interface.UnitConverters;
using AH.UnitSystem.SI.Interface;

namespace AH.UnitSystem.SI
{
    /// <summary>
    /// This library's implementation of the <see cref="ISystèmeInternational"/>
    /// interface.
    /// </summary>
    class SystèmeInternational : ISystèmeInternational
    {
        internal SystèmeInternational(
            IPhysicalQuantityGroupRWFactory pPhysicalQuantityGroupFactory,
            IPhysicalUnitFactory pPhysicalUnitFactory,
            IIdentityUnitConverter pIdentityUnitConverter
        )
        {
            Initialize(
                pPhysicalQuantityGroupFactory,
                pPhysicalUnitFactory,
                pIdentityUnitConverter
            );
        }

        public static DimensionDescription[] DimensionDescriptions = new DimensionDescription[]
        {
            new DimensionDescription("time", "t", "T", "second", "s"),
            new DimensionDescription("length", "l", "L", "meter", "m"),
            new DimensionDescription("mass", "m", "M", "kilogram", "kg"),
            new DimensionDescription("electric current", "I", "I", "ampere", "A"),
            new DimensionDescription("thermodynamic temperature", "T", "Θ", "kelvin", "K"),
            new DimensionDescription("amount of substance", "n", "N", "mole", "mol"),
            new DimensionDescription("luminous intensity", "lv", "J", "candela", "cd"),
        };

        /// <summary>
        /// This method initializes this instance, i.e. sets it up so
        /// that it is ready for work.
        /// </summary>
        void Initialize(
            IPhysicalQuantityGroupRWFactory pPhysicalQuantityGroupFactory,
            IPhysicalUnitFactory pPhysicalUnitFactory,
            IIdentityUnitConverter pIdentityUnitConverter
        )
        {
            IPhysicalQuantityGroup MakeGroupAndUnit(int pIndex)
            {

        var dimensionDescription = DimensionDescription.DimensionDescriptions[pIndex];

                var group = pPhysicalQuantityGroupFactory.Create(
                    dimensionDescription.Name,
                    new Dimension(
                        pIndex == 0 ? 1 : 0,
                        pIndex == 1 ? 1 : 0,
                        pIndex == 2 ? 1 : 0,
                        pIndex == 3 ? 1 : 0,
                        pIndex == 4 ? 1 : 0,
                        pIndex == 5 ? 1 : 0,
                        pIndex == 6 ? 1 : 0
                    ),
                    dimensionDescription.QuantitySymbol,
                    dimensionDescription.DimensionSymbol
                );
                //Register(group);

                var unit = pPhysicalUnitFactory.Create(
                    dimensionDescription.UnitName,
                    dimensionDescription.UnitSymbol,
                    pIdentityUnitConverter,
                    group.DefaultUnit
                );
                //Register(unit);
                group.DefaultUnit = unit;
                return group;
            }

            Time = MakeGroupAndUnit(0);
            Length = MakeGroupAndUnit(1);
            Mass = MakeGroupAndUnit(2);
            ElectricCurrent = MakeGroupAndUnit(3);
            ThermodynamicTemperature = MakeGroupAndUnit(4);
            AmountOfSubstance = MakeGroupAndUnit(5);
            LuminousIntensity = MakeGroupAndUnit(6);
        }

        /// <inheritdoc cref="ISystèmeInternational.Time"/>
        public IPhysicalQuantityGroup Time { get; private set; }

        public IPhysicalUnit Second => Time.DefaultUnit;

        public IPhysicalQuantityGroup Length { get; private set; }

        public IPhysicalUnit Meter => Length.DefaultUnit;

        public IPhysicalQuantityGroup Mass { get; private set; }

        public IPhysicalUnit Kilogram => Mass.DefaultUnit;

        public IPhysicalQuantityGroup ElectricCurrent { get; private set; }

        public IPhysicalUnit Ampere => ElectricCurrent.DefaultUnit;

        public IPhysicalQuantityGroup ThermodynamicTemperature { get; private set; }

        public IPhysicalUnit Kelvin => ThermodynamicTemperature.DefaultUnit;

        public IPhysicalQuantityGroup AmountOfSubstance { get; private set; }

        public IPhysicalUnit Mole => AmountOfSubstance.DefaultUnit;

        public IPhysicalQuantityGroup LuminousIntensity { get; private set; }

        public IPhysicalUnit Candela => LuminousIntensity.DefaultUnit;
    }
}
