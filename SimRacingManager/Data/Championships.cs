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
            new BrandsHatch(Status.Completed, new DateTime(2025, 2, 5)),
            new DoningtonPark(Status.Completed, new DateTime(2025, 2, 12)),
            new OultonPark(Status.Completed, new DateTime(2025, 2, 19)),
            new Kyalami(Status.Completed, new DateTime(2025, 2, 26)),
            new Interlagos(Status.Completed, new DateTime(2025, 3, 5)),
            new Adelaide(Status.Completed, new DateTime(2025, 3, 19)),
            new Bathurst(Status.Completed, new DateTime(2025, 4, 3))
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
            new RoadAmerica(Status.Completed, new DateTime(2025, 4, 16)),
            new WatkinsGlen(Status.Completed, new DateTime(2025, 4, 23)),
            new Virginia(Status.Completed, new DateTime(2025, 4, 30)),
            new Sebring(Status.Completed, new DateTime(2025, 5, 7)),
            new LagunaSeca(Status.Next, new DateTime(2025, 5, 21)),
            new Spielberg(Status.Upcoming, new DateTime(2025, 5, 28)),
            new Jerez(Status.Upcoming, new DateTime(2025, 6, 4)),
            new Nurburgring(Status.Upcoming, new DateTime(2025, 6, 11)),
            new Cascais(Status.Upcoming, new DateTime(2025, 6, 18)),
            new Hockenheimring(Status.Upcoming, new DateTime(2025, 6, 25))
        ]);

    public static List<Championship> ChampionshipsList = [Y2025Q1, Y2025Q2];
}