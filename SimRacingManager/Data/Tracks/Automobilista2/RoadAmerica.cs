using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class RoadAmerica : TrackBase
{
    public RoadAmerica(Status status, string name = null) : base(status, name)
    {
        Name = "Road America";
    }
}