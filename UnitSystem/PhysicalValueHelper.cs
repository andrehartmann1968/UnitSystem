using AH.UnitSystem.Interface;

namespace AH.UnitSystem
{
    public static class PhysicalValueHelper
    {
        public static double ConvertToDefault(this PhysicalValue pValue)
            => pValue.Unit.Converter.ConvertToDefault(pValue.Value);
        public static PhysicalValue ConvertToDefaultValue(this PhysicalValue pValue)
            => new PhysicalValue(
                pValue.Unit.Converter.ConvertToDefault(pValue.Value),
                pValue.Unit.DefaultUnit
              );
    }
}
