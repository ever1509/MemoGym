namespace DomeGym.Domain.Common;

public abstract class ValueObject
{
    public abstract IEnumerable<object?> GetEqualityComponents();
}