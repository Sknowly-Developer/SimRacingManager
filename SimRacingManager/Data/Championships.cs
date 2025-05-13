using SimRacingManager.Core;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data;

public static class Championships
{
    private static Championship Y2025Q1 = new("Quarter 1", 2025, Status.Completed, [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Matthew, Drivers.Trent], [Tracks.RoadAmerica]);
    private static Championship Y2025Q2 = new("Quarter 2", 2025, Status.Ongoing, [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Matthew, Drivers.Trent], [Tracks.RoadAmerica, Tracks.WatkinsGlen, Tracks.VirginiaInternationalRaceway, Tracks.Sebring]);
    private static Championship Y2025Q3 = new("Quarter 3", 2025, Status.Upcoming, [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Matthew, Drivers.Trent], [Tracks.Sebring]);

    public static List<Championship> ChampionshipsList = [Y2025Q1, Y2025Q2, Y2025Q3];
}