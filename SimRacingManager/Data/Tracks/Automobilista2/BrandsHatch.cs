using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data.Tracks.Automobilista2;

public class BrandsHatch : TrackBase
{
    public BrandsHatch(DateTime date, string name = null) : base(date, name)
    {
        Name = "Brands Hatch";
    }
}