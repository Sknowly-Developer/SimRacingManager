using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Jerez : TrackBase
{
    public Jerez(DateTime date, string name = null) : base(date, name)
    {
        Name = "Jerez";
    }
}