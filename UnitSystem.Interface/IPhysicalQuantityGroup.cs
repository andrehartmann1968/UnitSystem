namespace AH.UnitSystem.Interface
{
    /// <summary>
    /// This interface describes a physical quantity group (PQG) such as
    /// length, time, mass, force, pressure. It is a generalisation of a
    /// physical quantity (PQ). Every physical quantity belongs to a
    /// quantity group.
    /// 
    /// Examples:
    /// PQG             PQ
    /// length [m]      distance [in, yd, m, km, NM, AU, ly]
    ///                 altitude [m, km, ft]
    ///                 pressure altitude [m, ft, FL]
    ///                 elevation [m]
    ///             
    /// time [s]        time [s, min, h, d, w]
    ///                 duration  [s, min, h, d, w]
    ///             
    /// force [N]       thrust [N, kN]
    ///                 drag  [N, kN]
    ///                 pull  [N, kN]
    ///             
    /// pressure [Pa]   air pressure [hPa, kPa, atm]
    /// 
    /// mass [kg]       stellar mass [kg, solar masses]
    ///                 aircraft weight [kg, lb]
    /// </summary>
    public interface IPhysicalQuantityGroup : IPhysicalQuantity
    {
        ///// <summary>
        ///// This is the name of the physical quantity group. It is assigned when
        ///// the group is created and does not change throughout its lifetime.
        ///// Inside a unit system the name must be unique, i.e. there cannot be
        ///// two quantity groups with the same name registered to the same unit
        ///// system.
        ///// </summary>
        //new string Name { get; }
    }
}
