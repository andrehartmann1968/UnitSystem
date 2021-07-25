using AH.UnitSystem.Interface;
using AH.UnitSystem.Predefined.Interface;

namespace AH.UnitSystem.Predefined
{
    class Temperature : ITemperature
    {
        public IPhysicalUnit Celsius { get; set; }
        public IPhysicalUnit Fahrenheit { get; set; }
        public IPhysicalUnit Réaumur { get; set; }
    }
}
