using AH.UnitSystem.Interface;

namespace AH.UnitSystem.UnitConverters
{
    /// <summary>
    /// A unit converter that works with a scaling factor.
    /// 
    /// non-SI = SI / scaling factor
    /// 
    /// Example: min = sec / 60.0
    /// </summary>
    class ScalingUnitConverter : IUnitConverter
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

        public double ConvertToSI(
            double pValue
        ) => pValue * m_scalingFactor;
        public double ConvertFromSI(
            double pValue
        ) => pValue / m_scalingFactor;

        internal static readonly ScalingUnitConverter Identity
            = new ScalingUnitConverter(1.0);
    }
}
