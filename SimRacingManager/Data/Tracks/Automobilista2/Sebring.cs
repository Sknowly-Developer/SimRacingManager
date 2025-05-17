using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class Sebring : TrackBase
{
    public Sebring(DateTime date, string name = null) : base(date, name)
    {
        Name = "Sebring";
    }
}