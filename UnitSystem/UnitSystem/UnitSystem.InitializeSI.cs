namespace AH.UnitSystem.UnitSystem
{
    partial class UnitSystem
    {
        //public void InitializeSI()
        //{
        //    if (m_siInitialized)
        //        return;

        //    PhysicalQuantityGroup MakeGroupAndUnit(int pIndex)
        //    {
        //        var dimensionDescription = DimensionDescription.DimensionDescriptions[pIndex];

        //        var group = new PhysicalQuantityGroup(
        //            dimensionDescription.Name,
        //            new Dimension(
        //                pIndex == 0 ? 1 : 0,
        //                pIndex == 1 ? 1 : 0,
        //                pIndex == 2 ? 1 : 0,
        //                pIndex == 3 ? 1 : 0,
        //                pIndex == 4 ? 1 : 0,
        //                pIndex == 5 ? 1 : 0,
        //                pIndex == 6 ? 1 : 0
        //            ),
        //            dimensionDescription.QuantitySymbol,
        //            dimensionDescription.DimensionSymbol
        //        );
        //        Register(group);

        //        var unit = new PhysicalUnit(
        //            dimensionDescription.UnitName,
        //            dimensionDescription.UnitSymbol,
        //            UnitConverters.ScalingUnitConverter.Identity,
        //            group.SIUnit
        //        );
        //        Register(unit);
        //        group.SIUnit = unit;
        //        return group;
        //    }

        //    m_si.Time = MakeGroupAndUnit(0);
        //    m_si.Length = MakeGroupAndUnit(1);
        //    m_si.Mass = MakeGroupAndUnit(2);
        //    m_si.ElectricCurrent = MakeGroupAndUnit(3);
        //    m_si.ThermodynamicTemperature = MakeGroupAndUnit(4);
        //    m_si.AmountOfSubstance = MakeGroupAndUnit(5);
        //    m_si.LuminousIntensity = MakeGroupAndUnit(6);
        //    m_siInitialized = true;
        //}

    }
}
