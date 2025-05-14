using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Sebring : TrackBase
{
    public Sebring(Status status, string name = null) : base(status, name)
    {
        Name = "Sebring";
    }
}