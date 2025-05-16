using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class OultonPark : TrackBase
{
    public OultonPark(DateTime date, Driver? winner = null, string name = null) : base(date, winner, name)
    {
        Name = "Oulton Park";
    }
}