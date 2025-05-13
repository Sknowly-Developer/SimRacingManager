using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public class Championship
{
    public string Name;
    public int Year;
    public Status Status;
    public MudBlazor.Color StatusColour;
    public Guid GUID;
    public List<Driver> Drivers;
    public List<Track> Tracks;
    
    public Championship(string name, int year, Status status, List<Driver> drivers, List<Track> tracks)
    {
        Name = $"{name} Championship";
        Year = year;
        Status = status;
        GUID = Guid.NewGuid();
        Drivers = drivers;
        Tracks = tracks;
    }
}