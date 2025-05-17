using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Kyalami : TrackBase
{
    public Kyalami(DateTime date, string name = null) : base(date, name)
    {
        Name = "Kyalami";
    }
}