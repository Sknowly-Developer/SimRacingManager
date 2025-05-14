using SimRacingManager.Core;
using SimRacingManager.Data.Tracks.Automobilista2;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data;

public static class Championships
{
    private static Championship Y2025Q1 = new("Quarter 1", 2025, Status.Completed, 
        [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Matthew, Drivers.Trent], 
        [new BrandsHatch(Status.Completed), new DoningtonPark(Status.Completed), new OultonPark(Status.Completed), new Kyalami(Status.Completed), new Interlagos(Status.Completed), new Adelaide(Status.Completed), new Bathurst(Status.Completed)], 
        Drivers.Trent);
    
    private static Championship Y2025Q2 = new("Quarter 2", 2025, Status.Ongoing, 
        [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Matthew, Drivers.Trent], 
        [new RoadAmerica(Status.Completed), new WatkinsGlen(Status.Completed), new Virginia(Status.Completed), new Sebring(Status.Completed), new LagunaSeca(Status.Upcoming), new Spielberg(Status.Upcoming), new Jerez(Status.Upcoming), new Nurburgring(Status.Upcoming), new Cascais(Status.Upcoming), new Hockenheimring(Status.Upcoming)]);

    public static List<Championship> ChampionshipsList = [Y2025Q1, Y2025Q2];
}