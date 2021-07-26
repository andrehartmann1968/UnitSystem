using AH.UnitSystem.Interface.UnitConverters;

namespace AH.UnitSystem.UnitConverters
{
    /// <summary>
    /// A unit converter that works with a scaling factor.
    /// 
    /// non-SI = SI / scaling factor
    /// 
    /// Example: min = sec / 60.0
    /// </summary>
    class ScalingUnitConverter : IScalingUnitConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pScalingFactor">
        /// The scaling factor is the factor used to convert the amount of 1.0 of the non-SI unit
        /// into the underlying SI unit.
        /// </param>
        public ScalingUnitConverter(
            double pScalingFactor
        )
        {
            m_scalingFactor = pScalingFactor;
        }

        double m_scalingFactor;

        public double ConvertToDefault(
            double pValue
        ) => pValue * m_scalingFactor;
        public double ConvertFromDefault(
            double pValue
        ) => pValue / m_scalingFactor;

        internal static readonly ScalingUnitConverter Identity
            = new ScalingUnitConverter(1.0);
    }
}
