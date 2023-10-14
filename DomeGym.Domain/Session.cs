namespace DomeGym.Domain;
public class Session
{
    private readonly Guid _sessionId;
    private readonly Guid _trainerId;
    private readonly List<Guid> _participants = new();
    private readonly DateTime _date;
    private readonly TimeOnly _startTime;
    private readonly TimeOnly _endTime;

    private readonly int _maxParticipants;

    public Session(int maxParticipants, Guid trainerId, Guid? id = null)
    {
        _maxParticipants = maxParticipants;
        _sessionId = id ?? Guid.NewGuid();
        _trainerId = trainerId;
    }

    public Session(DateTime date, TimeOnly startTime, TimeOnly endTime)
    {
        _date = date;
        _startTime = startTime;
        _endTime = endTime;
    }

    public void ReserveSpot(Participant participant)
    {
        if (_participants.Count >= _maxParticipants)
        {
            throw new Exception("I cannot have more reservations for participants");
        }
        _participants.Add(participant.Id);
    }

    public void CancelReservation(Participant participant, IDateTimeProvider dateTimeProvider)
    {
        if (IsTooCloseToSession(dateTimeProvider.UtcNow))
        {
            throw new Exception("Cannot cancel reservation too close to session");
        }
    }

    private bool IsTooCloseToSession(DateTime utcNow)
    {
        const int MinHours = 24;
        var dateTime = Convert.ToDateTime(_startTime);
        return (dateTime - utcNow).TotalHours < MinHours;
    }
}