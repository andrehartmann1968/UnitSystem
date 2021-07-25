using AH.UnitSystem.Interface;

namespace AH.UnitSystem.Predefined.Interface
{
    public interface ITime
    {
        IPhysicalUnit MilliSecond { get;  }
        IPhysicalUnit MicroSecond { get;  }
        IPhysicalUnit NanoSecond { get;  }
        IPhysicalUnit Minute { get;  }
        IPhysicalUnit Hour { get;  }
        IPhysicalUnit Day { get;  }
        IPhysicalUnit Week { get;  }
    }
}
