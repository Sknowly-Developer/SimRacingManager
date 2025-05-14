using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class OultonPark : TrackBase
{
    public OultonPark(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Oulton Park";
    }
}