using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Adelaide : TrackBase
{
    public Adelaide(DateTime date, string name = null) : base(date, name)
    {
        Name = "Adelaide";
    }
}