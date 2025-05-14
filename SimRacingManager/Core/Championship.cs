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
    public int TrackCompleted;
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

    /// <summary>
    /// Loop through all the tracks and count which ones have been completed.
    /// </summary>
    public void TracksCompleted()
    {
        if (TrackCompleted > 0) // Adding this conditional in case the method is called more than once.
        {
            return;
        }
        
        foreach (var track in Tracks)
        {
            if (track.Status == Status.Completed)
            {
                TrackCompleted += 1;
            }
        }
    }
}