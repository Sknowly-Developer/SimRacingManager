using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Spielberg : TrackBase
{
    public Spielberg(Status status, string name = null) : base(status, name)
    {
        Name = "Spielberg";
    }
}