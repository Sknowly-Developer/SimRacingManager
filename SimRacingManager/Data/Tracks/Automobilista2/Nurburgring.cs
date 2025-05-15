using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Nurburgring : TrackBase
{
    public Nurburgring(DateTime date, string name = null) : base(date, name)
    {
        Name = "Nurburgring";
    }
}