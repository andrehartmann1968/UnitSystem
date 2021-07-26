using System;
using System.Collections.Generic;
using System.Linq;
using AH.UnitSystem.Interface;
using AH.UnitSystem.SI.Interface;

namespace AH.UnitSystem.UnitSystem
{
    partial class UnitSystem : IUnitSystem
    {
        /// <summary>
        /// Creates a new instance with the given SI. SI may be null.
        /// </summary>
        public UnitSystem(
            ISystèmeInternational pSystèmeInternational
        )
        {
            m_si = pSystèmeInternational;
        }

        readonly ISystèmeInternational m_si;
         //public ISystèmeInternational SI => m_siInitialized ? m_si : null;
        //readonly SI.SystèmeInternational m_si = new SI.SystèmeInternational();
        //bool m_siInitialized = false;

        //public IPredefined Predefined => m_predefinedInitialized ? m_predefined : null;
        //readonly Predefined.Predefined m_predefined = new Predefined.Predefined();
        //bool m_predefinedInitialized = false;

        //public IReadOnlyCollection<IPhysicalUnit> GetRegisteredPhysicalUnits(
        //    IPhysicalQuantity pQuantity
        //)
        //{
        //    var units = new Queue<IPhysicalUnit>();
        //    if (pQuantity != null)
        //    {
        //        lock (RegisteredUnits)
        //        {
        //            if (RegisteredUnits.TryGetValue(pQuantity, out var unts))
        //                foreach (var u in unts)
        //                    units.Enqueue(u);
        //        }
        //    }
        //    return units;
        //}
        public IPhysicalQuantityGroup CreateAndRegisterPhysicalQuantityGroup(
            string pName,
            Dimension pDimension,
            string pQuantitySymbol,
            string pDimensionSymbol = null
        )
        {
            var physicalQuantityGroup = new PhysicalQuantityGroup(
                pName, pDimension, pQuantitySymbol, pDimensionSymbol
            )
            {
                DefaultUnit = GenerateUnit(pDimension)
            };
            Register(physicalQuantityGroup);
            return physicalQuantityGroup;
        }

        PhysicalUnit GenerateUnit(
    Dimension pDimension
)
        {
            var numerators = new List<string>();
            var denominators = new List<string>();

            void Incorporate(
                int pExponent,
                IPhysicalQuantityGroup pGroup
            )
            {
                if (pExponent > 1)
                {
                    numerators.Add($"{pGroup.DefaultUnit.Symbol}^{pExponent}");
                }
                else if (pExponent > 0)
                {
                    numerators.Add(pGroup.DefaultUnit.Symbol);
                }
                else if (pExponent < -1)
                {
                    denominators.Add($"{pGroup.DefaultUnit.Symbol}^{-pExponent}");
                }
                else if (pExponent < 0)
                {
                    denominators.Add(pGroup.DefaultUnit.Symbol);
                }
            }

            //The order in which we incorporate below is significant. We want to
            //see the following units:
            //pressure: kg/m/s^2
            //force: kg*m/s^2
            //charge: A*s
            Incorporate(pDimension.ElectricCurrent, m_si.ElectricCurrent);
            Incorporate(pDimension.Mass, m_si.Mass);
            Incorporate(pDimension.Length, m_si.Length);
            Incorporate(pDimension.Time, m_si.Time);
            Incorporate(pDimension.ThermodynamicalTemperature, m_si.ThermodynamicTemperature);
            Incorporate(pDimension.AmountOfSubstance, m_si.AmountOfSubstance);
            Incorporate(pDimension.LuminousIntensity, m_si.LuminousIntensity);

            var numerator = numerators.Any() ? string.Join("*", numerators) : "1";
            var denominator = denominators.Any() ? string.Join("/", denominators) : "";
            var unitString = string.IsNullOrEmpty(denominator) ? numerator : $"{numerator}/{denominator}";
            return new PhysicalUnit(
                unitString,
                unitString,
                UnitConverters.ScalingUnitConverter.Identity,
                null
            );
        }
        public IPhysicalQuantity CreateAndRegisterPhysicalQuantity(
            IPhysicalQuantityGroup pGroup,
            string pName,
            IEnumerable<IPhysicalUnit> pUnits = null
        )
        {
            var physicalQuantity = new PhysicalQuantity(
                pName,
                pGroup
            );
            Register(physicalQuantity);
            if (pUnits != null)
                foreach (var u in pUnits)
                    Register(physicalQuantity, u);
            return physicalQuantity;
        }

        /// <inheritdoc/>
        public IPhysicalUnit CreateAndRegisterUnit(
            IPhysicalQuantity pGroup,
            string pName,
            string pSymbol,
            double pConversionFactorToSI
        )
        {
            var physicalUnit = new PhysicalUnit(
                pName,
                pSymbol,
                pConversionFactorToSI,
                pGroup
            );
            Register(physicalUnit);
            Register(pGroup, physicalUnit);
            return physicalUnit;
        }

        public IPhysicalUnit RegisterUnit(
            IPhysicalQuantity pQuantity,
            string pName,
            string pSymbol
        )
        {
            var physicalUnit = new PhysicalUnit(
                pName, pSymbol,
                null,
                pQuantity?.DefaultUnit
            );
            Register(pQuantity, physicalUnit);
            return physicalUnit;
        }

        //public PhysicalValue CreatePhysicalValue(
        //    double pValue,
        //    IPhysicalUnit pUnit
        //)
        //{
        //    var converterAvailable = pUnit.Converter != null;
        //    var value = converterAvailable ? pUnit.Converter.ConvertToSI(pValue) : pValue;
        //    return new PhysicalValue(
        //        value,
        //        converterAvailable ? pUnit.SIUnit ?? pUnit : pUnit
        //    );
        //}

        IPhysicalUnit RegisterUnit(
      IPhysicalQuantityGroup pGroup,
      string pName,
      string pSymbol,
            double pOffset,
            double pScalingFactor
  )
        {
            var physicalUnit = new PhysicalUnit(
                pName, pSymbol,
                pOffset, pScalingFactor,
                pGroup
            );
            Register(physicalUnit);
            Register(pGroup, physicalUnit);
            return physicalUnit;
        }

        /// <summary>
        /// This method resolves the given quantity. Throws an exception when it does not
        /// exist.
        /// 
        /// Never returns null.
        /// </summary>
        PhysicalQuantity Resolve(
            IPhysicalQuantity pQuantity
        )
        {
            var quantityName = pQuantity?.Name;

            if (string.IsNullOrEmpty(quantityName))
                throw new UnregisteredInstanceException(pQuantity);

            lock (m_registeredPhysicalQuantities)
            {
                if (!m_registeredPhysicalQuantities.TryGetValue(quantityName, out var q))
                    throw new UnregisteredInstanceException(pQuantity);

                if (q == null)
                    throw new UnregisteredInstanceException(pQuantity);

                return q;
            }

        }

        /// <summary>
        /// This method resolves the given quantity. Throws an exception when it does not
        /// exist.
        /// 
        /// Never returns null.
        /// </summary>
        PhysicalUnit Resolve(
            IPhysicalUnit pUnit
        )
        {
            var name = pUnit?.Name;

            if (string.IsNullOrEmpty(name))
                throw new UnregisteredInstanceException(pUnit);

            lock (m_registeredPhysicalUnits)
            {
                if (!m_registeredPhysicalUnits.TryGetValue(name, out var u))
                    throw new UnregisteredInstanceException(pUnit);

                if (u == null)
                    throw new UnregisteredInstanceException(pUnit);

                return u;
            }

        }

        void Register(
            PhysicalUnit pUnit
        )
        {
            lock (m_registeredPhysicalUnits)
            {
                var name = pUnit?.Name;

                if (string.IsNullOrEmpty(name))
                    throw new ArgumentException("Unit does not have a name.");

                if (m_registeredPhysicalUnits.TryGetValue(name, out var u))
                    throw new ArgumentException("A unit with that name is already registered.");

                m_registeredPhysicalUnits[name] = pUnit;
            }
        }

        void Register(
            PhysicalQuantityGroup pGroup
        )
        {
            lock (m_registeredPhysicalQuantityGroups)
            lock (m_registeredPhysicalQuantities)
                {
                    var name = pGroup?.Name;

                if (string.IsNullOrEmpty(name))
                    throw new ArgumentException("Quantity group does not have a name.");

                    if (m_registeredPhysicalQuantityGroups.TryGetValue(name, out var g))
                        throw new ArgumentException("A quantity group with that name is already registered.");
                    if (m_registeredPhysicalQuantities.TryGetValue(name, out var q))
                        throw new ArgumentException("A quantity with that name is already registered.");

                    m_registeredPhysicalQuantityGroups[name] = pGroup;
                    m_registeredPhysicalQuantities[name] = pGroup;
                }
        }
        void Register(
            PhysicalQuantity pQuantity
        )
        {
                lock (m_registeredPhysicalQuantities)
                {
                    var name = pQuantity?.Name;

                    if (string.IsNullOrEmpty(name))
                        throw new ArgumentException("Quantity does not have a name.");

                    if (m_registeredPhysicalQuantities.TryGetValue(name, out var q))
                        throw new ArgumentException("A quantity with that name is already registered.");

                    m_registeredPhysicalQuantities[name] = pQuantity;
                }
        }

        public void Register(
            IPhysicalQuantity pQuantity,
            IPhysicalUnit pUnit
        )
        {
            lock (m_registeredPhysicalQuantities)
            lock (m_registeredPhysicalUnits)
            {
                var quantity = Resolve(pQuantity);
                var unit = Resolve(pUnit);
                quantity.RegisterUnit(unit);
            }
        }

        //bool IsRegistered(
        //    IPhysicalUnit pUnit,
        //    IPhysicalQuantity pQuantity
        //)
        //{
        //    if (pUnit == null)
        //        return false;
        //    if (pQuantity == null)
        //        return false;
        //    lock (RegisteredUnits)
        //    {
        //        if (!RegisteredUnits.TryGetValue(pQuantity, out var groupUnits))
        //            return false;
        //        return groupUnits.Contains(pUnit);
        //    }
        //}

        //Dictionary<IPhysicalQuantity, HashSet<IPhysicalUnit>> RegisteredUnits { get; }
        //         = new Dictionary<IPhysicalQuantity, HashSet<IPhysicalUnit>>();

        Dictionary<string, PhysicalQuantity> m_registeredPhysicalQuantities
            = new Dictionary<string, PhysicalQuantity>();
        Dictionary<string, IPhysicalQuantityGroup> m_registeredPhysicalQuantityGroups
            = new Dictionary<string, IPhysicalQuantityGroup>();
        Dictionary<string, PhysicalUnit> m_registeredPhysicalUnits
            = new Dictionary<string, PhysicalUnit>();
    }
}