using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class BrandsHatch : TrackBase
{
    public BrandsHatch(Status status, string name = null) : base(status, name)
    {
        Name = "Brands Hatch";
    }
}