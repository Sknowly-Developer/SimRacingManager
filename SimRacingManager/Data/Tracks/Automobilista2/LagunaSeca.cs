using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class LagunaSeca : TrackBase
{
    public LagunaSeca(DateTime date, string name = null) : base(date, name)
    {
        Name = "Laguna Seca";
    }
}