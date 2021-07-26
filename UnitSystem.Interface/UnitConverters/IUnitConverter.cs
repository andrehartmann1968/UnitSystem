namespace AH.UnitSystem.Interface.UnitConverters
{
    public interface IUnitConverter
    {
        double ConvertToDefault(
            double pValue
        );
        double ConvertFromDefault(
            double pValue
        );
    }
}
