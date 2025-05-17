using SimRacingManager.Core;
using SimRacingManager.Data.Tracks.Automobilista2;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data;

public static class Championships
{
    private static Championship Y2025Q1 = new("Quarter 1", 2025, Status.Completed,
        [
            new BrandsHatch(new DateTime(2025, 2, 5), Drivers.Harvey),
            new DoningtonPark(new DateTime(2025, 2, 12), Drivers.Trent),
            new OultonPark(new DateTime(2025, 2, 19), Drivers.Trent),
            new Kyalami(new DateTime(2025, 2, 26), Drivers.Trent),
            new Interlagos(new DateTime(2025, 3, 5), Drivers.Trent),
            new Adelaide(new DateTime(2025, 3, 19), Drivers.Lee),
            new Bathurst(new DateTime(2025, 4, 3), Drivers.Trent)
        ],
        Drivers.Trent);

    private static Championship Y2025Q2 = new("Quarter 2", 2025, Status.Ongoing,
        [
            new RoadAmerica(new DateTime(2025, 4, 16), Drivers.Trent),
            new WatkinsGlen(new DateTime(2025, 4, 23), Drivers.Harvey),
            new Virginia(new DateTime(2025, 4, 30), Drivers.Harvey),
            new Sebring(new DateTime(2025, 5, 7), Drivers.Trent),
            new LagunaSeca(new DateTime(2025, 5, 21)),
            new Spielberg(new DateTime(2025, 5, 28)),
            new Jerez(new DateTime(2025, 6, 4)),
            new Nurburgring(new DateTime(2025, 6, 11)),
            new Cascais(new DateTime(2025, 6, 18)),
            new Hockenheimring(new DateTime(2025, 6, 25))
        ]);

    public static List<Championship> ChampionshipsList = [Y2025Q2, Y2025Q1];
}