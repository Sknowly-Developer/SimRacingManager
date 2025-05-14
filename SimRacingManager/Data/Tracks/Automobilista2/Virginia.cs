using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Virginia : TrackBase
{
    public Virginia(Status status, string name = null) : base(status, name)
    {
        Name = "Virginia";
    }
}