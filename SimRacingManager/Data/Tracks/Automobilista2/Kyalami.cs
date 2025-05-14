using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Kyalami : TrackBase
{
    public Kyalami(Status status, string name = null) : base(status, name)
    {
        Name = "Kyalami";
    }
}