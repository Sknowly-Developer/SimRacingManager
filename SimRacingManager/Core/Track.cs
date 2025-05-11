namespace SimRacingManager.Core;

public class Track
{
    public string Name;
    public List<Track>? Layouts;

    public Track(string name, List<Track>? layouts = null)
    {
        Name = name;
        Layouts = layouts;
    }
}