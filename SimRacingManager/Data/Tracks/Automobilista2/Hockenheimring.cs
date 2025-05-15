using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Hockenheimring : TrackBase
{
    public Hockenheimring(DateTime date, string name = null) : base(date, name)
    {
        Name = "Hockenheimring";
    }
}