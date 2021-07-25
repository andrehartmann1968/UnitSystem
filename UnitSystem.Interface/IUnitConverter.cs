namespace AH.UnitSystem.Interface
{
    public interface IUnitConverter
    {
        double ConvertToSI(
            double pValue
        );
        double ConvertFromSI(
            double pValue
        );
    }
}
