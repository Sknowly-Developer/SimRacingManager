using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks;

public class RoadAmerica : TrackBase
{
    public RoadAmerica(Status status, string name = null) : base(name, status)
    {
        Name = "Road America";
    }
}