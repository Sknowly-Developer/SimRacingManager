using MudBlazor;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public abstract class TrackBase
{
    public string Name;
    public DateTime Date;
    public Status Status = Status.Upcoming;
    public Color StatusColour;
    private Dictionary<Status, Color> _statusColourDictionary = new();
    
    protected TrackBase(DateTime date, string name = null)
    {
        Date = date;
        Name = name;
    }

    public void Initialize()
    {
        // Initialize gets called multiple times, clear the dictionary to avoid duplicate keys. 
        _statusColourDictionary.Clear();
        
        // Add the dictionary keys and values.
        _statusColourDictionary.Add(Status.Completed, Color.Error);
        _statusColourDictionary.Add(Status.Next, Color.Success);
        _statusColourDictionary.Add(Status.Upcoming, Color.Warning);

        SetStatus();
    }

    /// <summary>
    /// Automatically determine the status of the Track based on the dates.
    /// </summary>
    private void SetStatus()
    {
        var test = DateTime.Compare(Date, DateTime.Today);
        
        switch (test)
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
}