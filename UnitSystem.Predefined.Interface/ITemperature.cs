using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined.Interface
{
    public interface ITemperature
    {
        public IPhysicalUnit Celsius { get;  }
        public IPhysicalUnit Fahrenheit { get;  }
        public IPhysicalUnit Réaumur { get;  }

    }
}
