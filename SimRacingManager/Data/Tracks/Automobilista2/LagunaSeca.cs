using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class LagunaSeca : TrackBase
{
    public LagunaSeca(Status status, string name = null) : base(status, name)
    {
        Name = "Laguna Seca";
    }
}