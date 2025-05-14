using MudBlazor;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public abstract class TrackBase
{
    public string Name;
    public DateTime Date;
    public Status Status;
    public Color StatusColour;
    private Dictionary<Status, Color> _statusColourDictionary = new();
    
    protected TrackBase(DateTime date, Status status, string name = null)
    {
        Date = date;
        Status = status;
        Name = name;
    }

    public void Initialize()
    {
        // Initialize gets called multiple times, clear the dictionary to avoid duplicate keys. 
        _statusColourDictionary.Clear();
        
        // Add the dictionary keys and values.
        _statusColourDictionary.Add(Status.Completed, Color.Error);
        _statusColourDictionary.Add(Status.Ongoing, Color.Success);
        _statusColourDictionary.Add(Status.Upcoming, Color.Warning);

        SetStatusColour();
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