using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class RoadAmerica : TrackBase
{
    public RoadAmerica(DateTime date, Driver? winner = null, string name = null) : base(date, winner, name)
    {
        Name = "Road America";
    }
}