using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Adelaide : TrackBase
{
    public Adelaide(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Adelaide";
    }
}