using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined.Interface
{
    public interface ISpeed
    {
        public IPhysicalQuantityGroup PhysicalQuantityGroup { get;  }
        public IPhysicalUnit Kph { get;  }
        public IPhysicalUnit Mph { get;  }
        public IPhysicalUnit Mile { get;  }

        /// <summary>
        /// The vacuum speed of light according to
        /// https://de.wikipedia.org/wiki/Physikalische_Konstante
        /// </summary>
        public PhysicalValue SpeedOfLight { get;  }

    }
}
