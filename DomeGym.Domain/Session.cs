namespace DomeGym.Domain;

public class Session
{
    private readonly Guid _sessionId;
    private readonly Guid _trainerId;
    private readonly List<Guid> _participants = new();

    private readonly int _maxParticipants;

    public Session(int maxParticipants, Guid trainerId, Guid? id = null)
    {
        _maxParticipants = maxParticipants;
        _sessionId = id ?? Guid.NewGuid();
        _trainerId = trainerId;
    }

    public void ReserveSpot(Participant participant)
    {
        _participants.Add(participant.GetParticipantId());
    }
}