using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class WatkinsGlen : TrackBase
{
    public WatkinsGlen(DateTime date, string name = null) : base(date, name)
    {
        Name = "Watkins Glen";
    }
}