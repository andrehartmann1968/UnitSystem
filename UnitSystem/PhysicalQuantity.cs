using System.Collections.Generic;
using System.Diagnostics;
using AH.UnitSystem.Interface;
using System.Linq;

namespace AH.UnitSystem
{
    [DebuggerDisplay("{" + nameof(Display) + "}")]
    class PhysicalQuantity : IPhysicalQuantity
    {
        public PhysicalQuantity(
            string pName,
            IPhysicalQuantityGroup pGroup
        )
        {
            Name = pName;
            Group = pGroup;
        }

        public virtual IPhysicalUnit SIUnit
        {
            get => Group.SIUnit;
            internal set { }
        }

        public string Name { get; }

        /// <summary>
        /// This method registers a given unit to this quantity.
        /// 
        /// Will not be registered again when already registered.
        /// 
        /// Not part of the interface because it is supposed to be called only from
        /// the unit system.
        /// </summary>
        internal void RegisterUnit(
            PhysicalUnit pUnit
        )
        {
            if (pUnit == null)
                return;
            lock (m_explicitlyRegisteredPhysicalUnits)
            {
                if (m_explicitlyRegisteredPhysicalUnits.Contains(pUnit))
                    return;
                m_explicitlyRegisteredPhysicalUnits.Enqueue(pUnit);
            }
        }

        /// <summary>
        /// This is the group that the quantity belongs to.
        /// </summary>
        public IPhysicalQuantityGroup Group { get; protected set; }

        public string Display => $"{Name} [{SIUnit.Display}]";

        /// <summary>
        /// This collection contains the units that are explicitly registered with this
        /// quantity. The units are in the order in which they were registered.
        /// 
        /// Note that there are also implicitly registered units, such as the
        /// <see cref="SIUnit"/>.
        /// </summary>
        readonly Queue<PhysicalUnit> m_explicitlyRegisteredPhysicalUnits = new Queue<PhysicalUnit>();

        /// <inheritdoc cref="IPhysicalQuantity.AvailableUnits"/>
        public IEnumerable<IPhysicalUnit> AvailableUnits
            => (SIUnit != null ? new[] { SIUnit } : new IPhysicalUnit[0])
                   .Union(m_explicitlyRegisteredPhysicalUnits)
                   .Distinct();
    }
}
