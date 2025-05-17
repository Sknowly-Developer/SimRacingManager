using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class RoadAmerica : TrackBase
{
    public RoadAmerica(DateTime date, string name = null) : base(date, name)
    {
        Name = "Road America";
    }
}