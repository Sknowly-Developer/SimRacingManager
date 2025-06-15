using SimRacingManager.Core;

namespace SimRacingManager.Data;

public static class Globals
{
    public static bool HasDatabaseManagerBeenInitialised;
    public static Championship? LastSelectedChampionship; // This should never be null.
}