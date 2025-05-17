using SimRacingManager.Enumerations;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SimRacingManager.Core;

[Table("championships")]
public class Championship : BaseModel
{
    [PrimaryKey("uuid")]
    public Guid Guid { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("year")]
    public int Year { get; set; }
    
    [Column("winner")]
    public Guid? WinnerGuid { get; set; }
    public Driver? Winner;
    
    
    
    
    public TrackBase? Next;
    public string CombinedDates;
    public Status Status;
    public List<Driver> Drivers;
    public List<TrackBase> Tracks;
    public MudBlazor.Color StatusColour;
    public int TracksCompleted;
    public string TimeRemainingNextTrack;

    /// <summary>
    /// See if the Winner Guid from a championship matches a Driver Guid. If so, then assign a Driver object to the Winner field.
    /// </summary>
    public static void AssignChampionshipDriver()
    {
        foreach (var championship in DatabaseManager.Championships)
        {
            foreach (var driver in DatabaseManager.Drivers)
            {
                if (championship.WinnerGuid == driver.Guid)
                {
                    championship.Winner = driver;
                }   
            }
        }
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
        List<int> testingList = new();
        
        foreach (var track in Tracks)
        {
            if (track.Status != Status.Completed)
            {
                var daysRemainingUntilNextTrack = track.Date - DateTime.Today;
                testingList.Add(daysRemainingUntilNextTrack.Days);
            }
        }

        if (testingList.Count == 0)
        {
            Next = null;
            return;
        }
        
        var minimumDaysOnList = testingList.Min();
        
        foreach (var track in Tracks)
        {
            var daysRemainingUntilNextTrack = track.Date - DateTime.Today;
            if (daysRemainingUntilNextTrack.Days == minimumDaysOnList)
            {
                track.Status = Status.Next;
                Next = track;
            }
        }
        
        var daysRemaining = Next.Date - DateTime.Today;
        TimeRemainingNextTrack = daysRemaining.Days.ToString();
    }
}