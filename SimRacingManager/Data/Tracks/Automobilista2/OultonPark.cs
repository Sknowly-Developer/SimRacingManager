using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class OultonPark : TrackBase
{
    public OultonPark(Status status, string name = null) : base(status, name)
    {
        Name = "Oulton Park";
    }
}