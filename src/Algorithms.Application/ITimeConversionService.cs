namespace Algorithms.Application
{
    public interface ITimeConversionService
    {
        string GetTimeConversion(string request);
        string GetTimeConversionV2(string request);
    }
}