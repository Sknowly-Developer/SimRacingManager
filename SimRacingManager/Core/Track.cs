using SimRacingManager.Enumerations;

namespace SimRacingManager.Core;

public class Track
{
    public string Name;
    public Status Status = Status.Upcoming;
    public MudBlazor.Color StatusColour;
    public List<Track>? Layouts;

    public Track(string name, List<Track>? layouts = null)
    {
        Name = name;
        Layouts = layouts;
    }
}