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
    public List<TrackBase> Tracks;
    
    public Championship(string name, int year, Status status, List<Driver> drivers, List<TrackBase> tracks)
    {
        Name = $"{name} Championship";
        Year = year;
        Status = status;
        GUID = Guid.NewGuid();
        Drivers = drivers;
        Tracks = tracks;
    }
}