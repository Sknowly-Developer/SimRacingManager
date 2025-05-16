using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Spielberg : TrackBase
{
    public Spielberg(DateTime date, Driver? winner = null, string name = null) : base(date, winner, name)
    {
        Name = "Spielberg";
    }
}