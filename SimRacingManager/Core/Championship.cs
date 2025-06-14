using MudBlazor;
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
    
    [Column("drivers")]
    public Guid[]? DriversGuid { get; set; }
    public List<Driver> Drivers = [];
    
    [Column("tracks")]
    public Guid[]? TracksGuid { get; set; }
    public List<Track> Tracks = [];
    
    [Column("car_class")]
    public string? CarClass { get; set; }
    
    [Column("vehicles")]
    public Guid[]? VehiclesGuid { get; set; }
    
    //
    
    public Track? Next;
    public string CombinedDates;
    public Status Status;
    public Color StatusColour;
    private Dictionary<Status, Color> _statusColourDictionary = [];
    public int TracksCompleted;
    public string TimeRemainingNextTrack;

    public void Initialise()
    {
        _statusColourDictionary.Clear();

        _statusColourDictionary.Add(Status.Completed, Color.Error);
        _statusColourDictionary.Add(Status.Ongoing, Color.Success);
        _statusColourDictionary.Add(Status.Upcoming, Color.Warning);

        SetStatus();
        SetStatusColour();
    }

    private void SetStatus()
    {
        if (TracksGuid == null)
        {
            Status = Status.Upcoming;
        }
        else if (DateTime.Today < Tracks[0].Date)
        {
            Status = Status.Upcoming;
        }
        else if (DateTime.Today < Tracks[Tracks.Count - 1].Date)
        {
            Status = Status.Ongoing;
        }
    }
    
    /// <summary>
    /// Set the StatusColour field to whatever Colour value that was returned from the Dictionary.
    /// </summary>
    public void SetStatusColour()
    {
        foreach (var colour in _statusColourDictionary)
        {
            if (colour.Key == Status)
            {
                StatusColour = colour.Value;   
            }
        }
    }
    
    /// <summary>
    /// See if the Winner Guid from a championship matches a Driver Guid. If so, then assign a Driver object to the Winner field.
    /// </summary>
    public static void AssignWinner(List<Championship> championships)
    {
        foreach (var championship in championships)
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
        CombinedDates = $"{Tracks[0].Date.ToShortDateString()} to {Tracks[Tracks.Count - 1].Date.ToShortDateString()}";
    }

    /// <summary>
    /// Grab a reference to the Track that has the status 'Next' and store it.
    /// </summary>
    public void NextRace()
    {
        List<int> testingList = [];
        
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