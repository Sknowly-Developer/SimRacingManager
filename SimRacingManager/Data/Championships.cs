using SimRacingManager.Core;
using SimRacingManager.Data.Tracks;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Data;

public static class Championships
{
    private static Championship Y2025Q1 = new("Quarter 1", 2025, Status.Completed, [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Matthew, Drivers.Trent], [new RoadAmerica(Status.Ongoing)]);
    private static Championship Y2025Q2 = new("Quarter 2", 2025, Status.Ongoing, [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Matthew, Drivers.Trent], [new RoadAmerica(Status.Completed)]);
    private static Championship Y2025Q3 = new("Quarter 3", 2025, Status.Upcoming, [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Matthew, Drivers.Trent], []);

    public static List<Championship> ChampionshipsList = [Y2025Q1, Y2025Q2, Y2025Q3];
}