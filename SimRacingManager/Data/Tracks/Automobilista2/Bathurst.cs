using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Bathurst : TrackBase
{
    public Bathurst(Status status, string name = null) : base(status, name)
    {
        Name = "Bathurst";
    }
}