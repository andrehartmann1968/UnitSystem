namespace AH.UnitSystem.SI
{
    /// <summary>
    /// This class defines the description of a dimension of the SI.
    /// </summary>
    class DimensionDescription
    {
        public DimensionDescription(
           string pName,
           string pQuantitySymbol,
           string pDimensionSymbol,
           string pUnitName,
           string pUnitSymbol
        )
        {
            Name = pName;
            QuantitySymbol = pQuantitySymbol;
            DimensionSymbol = pDimensionSymbol;
            UnitName = pUnitName;
            UnitSymbol = pUnitSymbol;
        }

        public string Name { get; }
        public string QuantitySymbol { get; }
        public string DimensionSymbol { get; }
        public string UnitName { get; }
        public string UnitSymbol { get; }

        public static DimensionDescription[] DimensionDescriptions = new DimensionDescription[]
{
            new DimensionDescription("time", "t", "T", "second", "s"),
            new DimensionDescription("length", "l", "L", "meter", "m"),
            new DimensionDescription("mass", "m", "M", "kilogram", "kg"),
            new DimensionDescription("electric current", "I", "I", "ampere", "A"),
            new DimensionDescription("thermodynamic temperature", "T", "Θ", "kelvin", "K"),
            new DimensionDescription("amount of substance", "n", "N", "mole", "mol"),
            new DimensionDescription("luminous intensity", "lv", "J", "candela", "cd"),
};

    }
}