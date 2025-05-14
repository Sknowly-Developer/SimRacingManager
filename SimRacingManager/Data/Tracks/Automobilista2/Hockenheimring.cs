using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Hockenheimring : TrackBase
{
    public Hockenheimring(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Hockenheimring";
    }
}