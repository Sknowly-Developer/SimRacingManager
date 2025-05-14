using MudBlazor;
using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public abstract class TrackBase
{
    public string Name;
    public Status Status;
    public Color StatusColour;
    public Dictionary<Status, Color> _statusColourDictionary = new();
    
    public TrackBase(string name, Status status)
    {
        Name = name;
        Status = status;
    }

    public void Initialize()
    {
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

    /// <summary>
    /// Updates the status of the track, whether it has been completed, ongoing or upcoming.
    /// </summary>
    /// <param name="status">The status enumeration value</param>
    private void UpdateStatus(Status status)
    {
        Status = status;
        SetStatusColour();
    }
}