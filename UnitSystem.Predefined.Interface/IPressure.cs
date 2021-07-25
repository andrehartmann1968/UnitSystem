using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined.Interface
{
    public interface IPressure
    {
        public IPhysicalQuantityGroup PhysicalQuantityGroup { get;  }
        public IPhysicalUnit Pascal { get;  }
        public IPhysicalUnit HectoPascal { get;  }
        public IPhysicalUnit KiloPascal { get;  }
        public IPhysicalUnit Atmosphere { get;  }

    }
}
