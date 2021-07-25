namespace AH.UnitSystem.UnitSystem
{
    partial class UnitSystem
    {
        //public void InitializePredefined()
        //{
        //    if (m_predefinedInitialized)
        //        return;

        //    if (!m_siInitialized)
        //        InitializeSI();

        //    #region time
        //    m_predefined.InternalTime.InternalMilliSecond = new PhysicalUnit("millisecond", "ms", 1e-3, SI.Time);
        //    m_predefined.Time.MicroSecond = new PhysicalUnit("microsecond", "μs", 1e-6, SI.Time);
        //    m_predefined.Time.NanoSecond = new PhysicalUnit("nanosecond", "ns", 1e-9, SI.Time);
        //    m_predefined.Time.Minute = new PhysicalUnit("minute", "min", 60.0, SI.Time);
        //    m_predefined.Time.Hour = new PhysicalUnit("hour", "h", 60.0 * 60.0, SI.Time);
        //    m_predefined.Time.Day = new PhysicalUnit("day", "s", 24.0 * 60.0 * 60.0, SI.Time);
        //    m_predefined.Time.Week = new PhysicalUnit("week", "w", 7.0 * 24.0 * 60.0 * 60.0, SI.Time);
        //    #endregion time

        //    #region length
        //    m_predefined.Length.Ångström = new PhysicalUnit("Ångström", "Å", 1e-10, SI.Length);
        //    m_predefined.Length.Mile = new PhysicalUnit("mile", "mi", 1609.344, SI.Length);
        //    m_predefined.Length.NauticalMile = new PhysicalUnit("nautical mile", "NM", 1852, SI.Length);
        //    #endregion length

        //    #region temperature
        //    m_predefined.Temperature.Celsius = RegisterUnit(
        //        SI.ThermodynamicTemperature,
        //        "Celsius", "°C",
        //        273.15, 1.0
        //    );
        //    m_predefined.Temperature.Fahrenheit = RegisterUnit(
        //        SI.ThermodynamicTemperature,
        //        "Fahrenheit", "°F",
        //        -5.0 / 9.0 * 32.0 + 273.15,
        //        5.0 / 9.0
        //    );
        //    m_predefined.Temperature.Réaumur = RegisterUnit(
        //        SI.ThermodynamicTemperature,
        //        "Réaumur", "°R",
        //        273.15,
        //        5.0 / 4.0
        //    );
        //    #endregion temperature

        //    #region electric charge
        //    var charge = CreateAndRegisterPhysicalQuantityGroup(
        //        "electric charge", new Dimension(1, 0, 0, 1, 0, 0, 0), "Q"
        //    );
        //    m_predefined.ElectricCharge.Coulomb = CreateAndRegisterUnit(
        //        charge,
        //        "Coulomb",
        //        "C",
        //        1.0
        //    );
        //    m_predefined.ElectricCharge.PhysicalQuantityGroup = charge;
        //    m_predefined.ElectricCharge.ElementaryCharge = new UnitSystemInterface.PhysicalValue(
        //        1.602176634e-19, m_predefined.ElectricCharge.Coulomb);
        //    #endregion electric charge

        //    #region speed
        //    var speed = CreateAndRegisterPhysicalQuantityGroup(
        //        "speed", new Dimension(-1, 1, 0, 0, 0, 0, 0), "v"
        //    );
        //    m_predefined.Speed.PhysicalQuantityGroup = speed;

        //    m_predefined.Speed.Kph = CreateAndRegisterUnit(
        //        speed,
        //        "kilometers per hour",
        //        "km/h",
        //        1000.0 / 60 / 60
        //    );
        //    m_predefined.Speed.Mph = CreateAndRegisterUnit(
        //        speed,
        //        "miles per hour",
        //        "mph",
        //        1609.344 / 60 / 60
        //    );
        //    m_predefined.Speed.SpeedOfLight = new UnitSystemInterface.PhysicalValue(
        //        299792458, speed.SIUnit);
        //    #endregion speed

        //    #region force
        //    var force = CreateAndRegisterPhysicalQuantityGroup(
        //        "force", new Dimension(-2, 1, 1, 0, 0, 0, 0), "F"
        //    );
        //    m_predefined.Force.PhysicalQuantityGroup = force;
        //    m_predefined.Force.Newton = CreateAndRegisterUnit(
        //        force,
        //        "Newton", "N",
        //        1.0
        //    );
        //    m_predefined.Force.Kilopond = CreateAndRegisterUnit(
        //        force,
        //        "kilopond",
        //        "kp",
        //        9.806650
        //    );
        //    #endregion force

        //    #region pressure
        //    var pressure = CreateAndRegisterPhysicalQuantityGroup(
        //        "pressure", new Dimension(-2, -1, 1, 0, 0, 0, 0), "P"
        //    );
        //    m_predefined.Pressure.PhysicalQuantityGroup = pressure;
        //    m_predefined.Pressure.Pascal = CreateAndRegisterUnit(
        //        pressure,
        //        "Pascal", "Pa",
        //        1.0
        //    );
        //    m_predefined.Pressure.HectoPascal = CreateAndRegisterUnit(
        //        pressure,
        //        "HectoPascal", "hPa",
        //        100.0
        //    );
        //    m_predefined.Pressure.KiloPascal = CreateAndRegisterUnit(
        //        pressure,
        //        "KiloPascal", "kPa",
        //        1000.0
        //    );
        //    m_predefined.Pressure.Atmosphere = CreateAndRegisterUnit(
        //        pressure,
        //        "atmosphere", "atm",
        //        101325
        //    );
        //    #endregion pressure

        //    m_predefined.GravitationalConstant = new UnitSystemInterface.PhysicalValue(
        //        6.67430e-11, GenerateUnit(new Dimension(-2, 3, -1)));

        //    m_predefinedInitialized = true;
        //}
    }
}
