using DomeGym.Domain;
using DomeGym.Domain.UnitTests.TestConstants;

namespace DomeGym.Domain.UnitTests.TestUtils;

public static class SessionFactory
{
    public static Session CreateSession(int maxParticipants, Guid? id = null)
    {
        return new Session(maxParticipants, trainerId: Constants.Trainer.Id, id: id ?? Constants.Session.Id);
    }
}
