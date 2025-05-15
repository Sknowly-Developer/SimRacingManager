using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class OultonPark : TrackBase
{
    public OultonPark(DateTime date, string name = null) : base(date, name)
    {
        Name = "Oulton Park";
    }
}