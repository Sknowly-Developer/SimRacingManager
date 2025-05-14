using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Jerez : TrackBase
{
    public Jerez(Status status, string name = null) : base(status, name)
    {
        Name = "Jerez";
    }
}