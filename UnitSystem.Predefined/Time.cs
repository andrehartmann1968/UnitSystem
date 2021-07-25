using AH.UnitSystem.Interface;
using AH.UnitSystem.Predefined.Interface;

namespace AH.UnitSystem.Predefined
{
    class Time : ITime
    {
        public IPhysicalUnit MilliSecond => InternalMilliSecond;
        internal IPhysicalUnit InternalMilliSecond { get; set; }

        public IPhysicalUnit MicroSecond { get; }
        public IPhysicalUnit NanoSecond { get; }
        public IPhysicalUnit Minute { get; }
        public IPhysicalUnit Hour { get; }
        public IPhysicalUnit Day { get; }
        public IPhysicalUnit Week { get; }

    }
}
