using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class DoningtonPark : TrackBase
{
    public DoningtonPark(Status status, string name = null) : base(status, name)
    {
        Name = "Donington Park";
    }
}