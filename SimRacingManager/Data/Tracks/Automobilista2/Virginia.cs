using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Virginia : TrackBase
{
    public Virginia(DateTime date, string name = null) : base(date, name)
    {
        Name = "Virginia";
    }
}