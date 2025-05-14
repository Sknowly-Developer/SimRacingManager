using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class WatkinsGlen : TrackBase
{
    public WatkinsGlen(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Watkins Glen";
    }
}