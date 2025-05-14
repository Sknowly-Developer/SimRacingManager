using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Cascais : TrackBase
{
    public Cascais(Status status, string name = null) : base(status, name)
    {
        Name = "Cascais";
    }
}