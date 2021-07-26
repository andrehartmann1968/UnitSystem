using AH.UnitSystem.Interface;
using AH.UnitSystem.Interface.UnitConverters;

namespace AH.UnitSystem.UnitConverters
{
    /// <summary>
    /// A unit converter that works with a linear conversion using an offset and a scaling factor.
    /// 
    /// non-SI = SI / scaling factor - offset
    /// 
    /// Example: °C = K / 1.0 - 273.15
    /// </summary>
    class LinearUnitConverter : ILinearUnitConverter
    {
        /// <summary>
        /// </summary>
        public LinearUnitConverter(
            double pOffset,
            double pScalingFactor
        )
        {
            m_scalingFactor = pScalingFactor;
            m_Offset = pOffset;
        }

        double m_scalingFactor;
        double m_Offset;

        public double ConvertToDefault(
            double pValue
        ) => m_Offset + pValue * m_scalingFactor;
        public double ConvertFromDefault(
            double pValue
        ) => pValue / m_scalingFactor - m_Offset;
    }
}
