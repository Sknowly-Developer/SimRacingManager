using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public class Championship
{
    public string Name;
    public int Year;
    public string CombinedDates;
    public int TracksCompleted;
    public Driver Winner;
    public Status Status;
    public MudBlazor.Color StatusColour;
    public Guid Guid;
    public List<Driver> Drivers;
    public List<TrackBase> Tracks;
    
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
    public void TracksCompletedCount()
    {
        if (TracksCompleted > 0) // Adding this conditional in case the method is called more than once.
        {
            return;
        }
        
        foreach (var track in Tracks)
        {
            if (track.Status == Status.Completed)
            {
                TracksCompleted += 1;
            }
        }
    }

    public void CombineDates()
    {
        List<DateTime> trackDates = new();
        
        foreach (var track in Tracks)
        {
            trackDates.Add(track.Date);
        }
        
        CombinedDates = $"{trackDates[0].Date.ToShortDateString()} to {trackDates[trackDates.Count - 1].Date.ToShortDateString()}";
    }
}