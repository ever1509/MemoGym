namespace DomeGym.Domain.UnitTests.TestConstants;

public static partial class Constants
{
    public static class Session
    {
        public static readonly Guid Id = Guid.NewGuid();
        public static readonly DateTime Date = DateTime.UtcNow;
        public static readonly TimeOnly StartTime = TimeOnly.MinValue;
        public static readonly TimeOnly EndTime = TimeOnly.MaxValue;
    }
}