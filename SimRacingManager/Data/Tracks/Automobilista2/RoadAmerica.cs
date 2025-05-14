using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class RoadAmerica : TrackBase
{
    public RoadAmerica(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Road America";
    }
}