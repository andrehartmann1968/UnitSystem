namespace AH.UnitSystem.SI.Interface
{
    /// <summary>
    /// An instance of this struct describes the dimension of a physical
    /// quantity according to
    /// https://en.wikipedia.org/wiki/Dimensional_analysis#Mathematical_formulation.
    /// 
    /// The dimension is expressed in form of 7 integer numbers (positive, zero
    /// or negative) relating to the 7 base quantity groups of the SI. Each integer
    /// number is interpreted as an exponent of the quantity group.
    /// </summary>
    public readonly struct Dimension
    {
        public Dimension(
            int pTime,
            int pLength,
            int pMass,
            int pElectricCurrent = 0,
            int pThermodynamicalTemperature = 0,
            int pAmountOfSubstance = 0,
            int pLuminousIntensity = 0
        )
        {
            Time = pTime;
            Length = pLength;
            Mass = pMass;
            ElectricCurrent = pElectricCurrent;
            ThermodynamicalTemperature = pThermodynamicalTemperature;
            AmountOfSubstance = pAmountOfSubstance;
            LuminousIntensity = pLuminousIntensity;
        }
        public int Time { get; }
        public int Length { get; }
        public int Mass { get; }
        public int ElectricCurrent { get; }
        public int ThermodynamicalTemperature { get; }
        public int AmountOfSubstance { get; }
        public int LuminousIntensity { get; }
    }
}
