using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Nurburgring : TrackBase
{
    public Nurburgring(Status status, string name = null) : base(status, name)
    {
        Name = "Nurburgring";
    }
}