using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class WatkinsGlen : TrackBase
{
    public WatkinsGlen(Status status, string name = null) : base(status, name)
    {
        Name = "Watkins Glen";
    }
}