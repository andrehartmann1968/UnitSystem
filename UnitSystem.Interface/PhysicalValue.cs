using System.Diagnostics;

namespace AH.UnitSystem.Interface
{
    /// <summary>
    /// This struct represents a physical value in the underlying SI unit
    /// of the given physical quantity.
    /// </summary>
    [DebuggerDisplay("{" + nameof(Display) + "}")]
    public struct PhysicalValue
    {
        public PhysicalValue(
            double pValue,
            IPhysicalUnit pUnit
        )
        {
            Unit = pUnit;
            Value = pValue;
        }

        public double Value { get; }
        public IPhysicalUnit Unit { get; }

        public string Display => $"{Value}{Unit.Symbol}";

        /// <summary>
        /// A value that can be used to represent NaN.
        /// </summary>
        public static readonly PhysicalValue NaN = new PhysicalValue(double.NaN, null);

        public static bool operator ==(PhysicalValue v1, PhysicalValue v2)
            => v1.Equals(v2);
        public static bool operator !=(PhysicalValue v1, PhysicalValue v2)
            => !v1.Equals(v2);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is PhysicalValue v && Equals(v);
        }

        public bool Equals(PhysicalValue v)
        {
            if (Value != v.Value)
                return false;
            if (Unit != v.Unit)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 13;
                hashCode = (hashCode * 397) ^ Value.GetHashCode();
                hashCode = (hashCode * 397) ^ (Unit?.GetHashCode() ?? 1);
                return hashCode;
            }
        }
    }
}
