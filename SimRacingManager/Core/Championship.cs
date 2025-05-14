using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public class Championship
{
    public string Name;
    public int Year;
    public Status Status;
    public MudBlazor.Color StatusColour;
    public Guid Guid;
    public List<Driver> Drivers;
    public List<TrackBase> Tracks;
    public Driver Winner;
    
    public Championship(string name, int year, Status status, List<Driver> drivers, List<TrackBase> tracks, Driver winner = null)
    {
        Name = $"{name} Championship";
        Year = year;
        Status = status;
        Guid = Guid.NewGuid();
        Drivers = drivers;
        Tracks = tracks;
        Winner = winner;
    }
}