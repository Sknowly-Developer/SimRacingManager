using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Interlagos : TrackBase
{
    public Interlagos(DateTime date, string name = null) : base(date, name)
    {
        Name = "Interlagos";
    }
}