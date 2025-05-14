using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class DoningtonPark : TrackBase
{
    public DoningtonPark(Status status, DateTime date, string name = null) : base(date, status, name)
    {
        Name = "Donington Park";
    }
}