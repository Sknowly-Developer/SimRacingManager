namespace SimRacingManager.Core;

public class Track
{
    public string Name;
    public string ImageSource;
    public List<Track>? Layouts;

    public Track(string name, string imageSource, List<Track>? layouts = null)
    {
        Name = name;
        ImageSource = imageSource;
        Layouts = layouts;
    }
}