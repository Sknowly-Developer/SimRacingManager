using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Cascais : TrackBase
{
    public Cascais(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Cascais";
    }
}