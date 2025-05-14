using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Adelaide : TrackBase
{
    public Adelaide(Status status, string name = null) : base(status, name)
    {
        Name = "Adelaide";
    }
}