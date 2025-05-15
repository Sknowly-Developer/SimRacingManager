using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Bathurst : TrackBase
{
    public Bathurst(DateTime date, string name = null) : base(date, name)
    {
        Name = "Bathurst";
    }
}