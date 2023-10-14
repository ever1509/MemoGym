namespace DomeGym.Domain.UnitTests.ExtensionMethods;

public static class DateTimeExtensions
{
    public static DateTime ToDateTime(this TimeSpan timeSpan)
    {
        return DateTime.Now.Subtract(timeSpan);
    }
}