using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class DoningtonPark : TrackBase
{
    public DoningtonPark(DateTime date, string name = null) : base(date, name)
    {
        Name = "Donington Park";
    }
}