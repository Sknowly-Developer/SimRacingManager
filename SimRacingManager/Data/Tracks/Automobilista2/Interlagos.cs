using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Interlagos : TrackBase
{
    public Interlagos(Status status, string name = null) : base(status, name)
    {
        Name = "Interlagos";
    }
}