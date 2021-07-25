using AH.UnitSystem.Interface;
using AH.UnitSystem.SI.Interface;

namespace AH.UnitSystem.SI
{
    class SystèmeInternational : ISystèmeInternational
    {
        public IPhysicalQuantityGroup Time { get; set; }

        public IPhysicalUnit Second => Time.SIUnit;

        public IPhysicalQuantityGroup Length { get; set; }

        public IPhysicalUnit Meter => Length.SIUnit;

        public IPhysicalQuantityGroup Mass { get; set; }

        public IPhysicalUnit Kilogram => Mass.SIUnit;

        public IPhysicalQuantityGroup ElectricCurrent { get; set; }

        public IPhysicalUnit Ampere => ElectricCurrent.SIUnit;

        public IPhysicalQuantityGroup ThermodynamicTemperature { get; set; }

        public IPhysicalUnit Kelvin => ThermodynamicTemperature.SIUnit;

        public IPhysicalQuantityGroup AmountOfSubstance { get; set; }

        public IPhysicalUnit Mole => AmountOfSubstance.SIUnit;

        public IPhysicalQuantityGroup LuminousIntensity { get; set; }

        public IPhysicalUnit Candela => LuminousIntensity.SIUnit;
    }
}
