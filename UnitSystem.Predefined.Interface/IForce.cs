using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined.Interface
{
    public interface IForce
    {
        public IPhysicalQuantityGroup PhysicalQuantityGroup { get;  }
        public IPhysicalUnit Newton { get;  }
        public IPhysicalUnit Kilopond { get;  }

    }
}
