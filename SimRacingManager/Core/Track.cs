using MudBlazor;
using SimRacingManager.Enumerations;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SimRacingManager.Core;

[Table("tracks")]
public class Track : BaseModel
{
    [PrimaryKey("uuid")]
    public Guid Guid { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("date")]
    public DateTime Date { get; set; }
    
    [Column("countdown")]
    public string Countdown { get; set; }
    
    [Column("results")]
    public Guid[]? ResultsGuid { get; set; }
    
    //
    
    public Status Status = Status.Next;
    public Color StatusColour;
    private Dictionary<Status, Color> _statusColourDictionary = [];
    public Championship ChampionshipInstance;
    
    public void Initialize()
    {
        // Initialize gets called multiple times, clear the dictionary to avoid duplicate keys. 
        _statusColourDictionary.Clear();
        
        // Add the dictionary keys and values.
        _statusColourDictionary.Add(Status.Completed, Color.Error);
        _statusColourDictionary.Add(Status.Next, Color.Success);
        _statusColourDictionary.Add(Status.Upcoming, Color.Warning);

        SetStatus();
        SetStatusColour();
        SetCountdownTimer();
    }

    /// <summary>
    /// Automatically determine the status of the Track based on the dates.
    /// </summary>
    private void SetStatus()
    {
        var dateComparison = DateTime.Compare(Date, DateTime.Today);
        
        switch (dateComparison)
        {
            case <0:
                Status = Status.Completed;
                break;
            case >0:
                Status = Status.Upcoming;
                break;
        }
    }
    
    /// <summary>
    /// Set the StatusColour field to whatever Colour value that was returned from the Dictionary.
    /// </summary>
    private void SetStatusColour()
    {
        foreach (var colour in _statusColourDictionary)
        {
            if (colour.Key == Status)
            {
                StatusColour = colour.Value;   
            }
        }
    }

    private void SetCountdownTimer()
    {
        var daysRemaining = Date - DateTime.Now; 
        Countdown = GetRemainingNextTrack();
        return;

        string GetRemainingNextTrack()
        {
            if (daysRemaining.Days > 1) return daysRemaining.Days + " Days";
            if (daysRemaining is { Days: < 1, Hours: > 1 }) return daysRemaining.Hours + " Hours";
            if (daysRemaining is { Hours: < 1, Minutes: > 1 }) return daysRemaining.Minutes + " Minutes";
            if (daysRemaining is { Minutes: < 1, Seconds: > 1 }) return daysRemaining.Seconds + " Seconds";
            return "";
        }
    }
}