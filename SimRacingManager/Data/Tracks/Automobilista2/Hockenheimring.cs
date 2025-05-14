using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Hockenheimring : TrackBase
{
    public Hockenheimring(Status status, string name = null) : base(status, name)
    {
        Name = "Hockenheimring";
    }
}