using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Kyalami : TrackBase
{
    public Kyalami(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Kyalami";
    }
}