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
    
    [Column("results")]
    public Guid? ResultsGuid { get; set; }
    public Results Result;
    
    //
    
    public Status Status = Status.Next;
    public Color StatusColour;
    private Dictionary<Status, Color> _statusColourDictionary = [];
    
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
}