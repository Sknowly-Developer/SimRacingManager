using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Interlagos : TrackBase
{
    public Interlagos(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Interlagos";
    }
}