using SimRacingManager.Core;

namespace SimRacingManager.Data;

public static class Championships
{
    public static Championship Y2025Q1 = new("Quarter 1", 2025, [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Trent, Drivers.Matthew], [Tracks.RoadAmerica]);
    public static Championship Y2025Q2 = new("Quarter 2", 2025, [Drivers.Adam, Drivers.Damien, Drivers.Harvey, Drivers.Lee, Drivers.Trent, Drivers.Matthew], [Tracks.RoadAmerica, Tracks.WatkinsGlen, Tracks.VirginiaInternationalRaceway, Tracks.Sebring]);
}