using DomeGym.Domain.Common;

namespace DomeGym.Domain;

public class Participant : Entity
{
    private readonly Guid _userId;
    private readonly List<Guid> _sessionIds;

    public Participant(Guid userId, Guid? id = null) :base(id ?? Guid.NewGuid())
    {
        _userId = userId;
    }
}