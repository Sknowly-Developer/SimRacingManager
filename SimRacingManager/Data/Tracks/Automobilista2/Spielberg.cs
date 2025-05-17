using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Spielberg : TrackBase
{
    public Spielberg(DateTime date, string name = null) : base(date, name)
    {
        Name = "Spielberg";
    }
}