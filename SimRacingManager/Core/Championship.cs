using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public class Championship
{
    public string Name;
    public int Year;
    public DateTime StartingDate;
    public DateTime EndDate;
    public string CombinedDates;
    public int TracksCompleted;
    public Driver Winner;
    public Status Status;
    public MudBlazor.Color StatusColour;
    public Guid Guid;
    public List<Driver> Drivers;
    public List<TrackBase> Tracks;
    
    public Championship(string name, int year, DateTime startingDate, DateTime endDate, Status status, List<Driver> drivers, List<TrackBase> tracks, Driver winner = null)
    {
        Name = $"{name} Championship";
        Year = year;
        StartingDate = startingDate;
        EndDate = endDate;
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
        CombinedDates = $"{StartingDate.ToShortDateString()} to {EndDate.Date.ToShortDateString()}";
    }
}