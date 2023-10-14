namespace DomeGym.Domain.UnitTests.TestUtils.Services;

public class TestDateTimeProvider : IDateTimeProvider
{
    private DateTime? _fixedDateTime;
    public TestDateTimeProvider(DateTime? fixedDateTime = null)
    {
        _fixedDateTime = fixedDateTime;
    }

    public DateTime UtcNow => _fixedDateTime ?? DateTime.UtcNow;
}