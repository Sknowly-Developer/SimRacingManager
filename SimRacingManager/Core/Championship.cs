using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public class Championship
{
    public int Year;
    public string Name;
    public TrackBase Next;
    public string CombinedDates;
    public Driver Winner;
    public Status Status;
    
    public List<Driver> Drivers;
    public List<TrackBase> Tracks;
    
    public Guid Guid;
    public MudBlazor.Color StatusColour;
    public int TracksCompleted;
    public string TimeRemainingNextTrack;
    
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

    /// <summary>
    /// Loop through all track dates, grab the first and last indexes - and combine them into a string.
    /// </summary>
    public void CombineDates()
    {
        List<DateTime> trackDates = new();
        
        foreach (var track in Tracks)
        {
            trackDates.Add(track.Date);
        }
        
        CombinedDates = $"{trackDates[0].Date.ToShortDateString()} to {trackDates[trackDates.Count - 1].Date.ToShortDateString()}";
    }

    /// <summary>
    /// Grab a reference to the Track that has the status 'Next' and store it.
    /// </summary>
    public void NextRace()
    {
        foreach (var track in Tracks)
        {
            if (track.Status == Status.Next)
            {
                Next = track;
            }
        }

        if (Next == null)
        {
            return;
        }
        
        TimeSpan daysRemaining = Next.Date - DateTime.Today;
        TimeRemainingNextTrack = daysRemaining.Days.ToString();
    }
}