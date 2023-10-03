using DomeGym.Domain.UnitTests.TestUtils;

namespace DomeGym.Domain.UnitTests;

public class SessionTests
{
    [Fact]
    public void ReserveSpot_WhenNoMoreRoom_ShouldFailReservation()
    {
        //Arrange
        var session = SessionFactory.CreateSession(maxParticipants: 1);
        var participant1 = ParticipantFactory.CreateParticipant(id: Guid.NewGuid());
        var participant2 = ParticipantFactory.CreateParticipant(id: Guid.NewGuid());
        
        //Act
        session.ReserveSpot(participant1);
        session.ReserveSpot(participant2);


        //Assert
        // participant 2 reservation failed
    }
}