using SimRacingManager.Core;
using SimRacingManager.Data.Tracks.Automobilista2;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data;

public static class Championships
{
    private static Championship Y2025Q1 = new("Quarter 1", 2025, Status.Completed,
        [
            Drivers.Adam, 
            Drivers.Damien, 
            Drivers.Harvey, 
            Drivers.Lee, 
            Drivers.Matthew, 
            Drivers.Trent],
        [
            new BrandsHatch(new DateTime(2025, 2, 5)),
            new DoningtonPark(new DateTime(2025, 2, 12)),
            new OultonPark(new DateTime(2025, 2, 19)),
            new Kyalami(new DateTime(2025, 2, 26)),
            new Interlagos(new DateTime(2025, 3, 5)),
            new Adelaide(new DateTime(2025, 3, 19)),
            new Bathurst(new DateTime(2025, 4, 3))
        ],
        Drivers.Trent);

    private static Championship Y2025Q2 = new("Quarter 2", 2025, Status.Ongoing,
        [
            Drivers.Adam, 
            Drivers.Damien, 
            Drivers.Harvey, 
            Drivers.Lee, 
            Drivers.Matthew, 
            Drivers.Trent],
        [
            new RoadAmerica(new DateTime(2025, 4, 16)),
            new WatkinsGlen(new DateTime(2025, 4, 23)),
            new Virginia(new DateTime(2025, 4, 30)),
            new Sebring(new DateTime(2025, 5, 7)),
            new LagunaSeca(new DateTime(2025, 5, 21)),
            new Spielberg(new DateTime(2025, 5, 28)),
            new Jerez(new DateTime(2025, 6, 4)),
            new Nurburgring(new DateTime(2025, 6, 11)),
            new Cascais(new DateTime(2025, 6, 18)),
            new Hockenheimring(new DateTime(2025, 6, 25))
        ]);

    public static List<Championship> ChampionshipsList = [Y2025Q2, Y2025Q1];
}