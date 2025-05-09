namespace SimRacingManager.Core;

public class Championship
{
    public string Name;
    public Guid GUID;
    public List<Driver> Drivers;
    public List<Track> Tracks;
    
    public Championship(string name, List<Driver> drivers, List<Track> tracks)
    {
        Name = $"{name} Championship";
        GUID = Guid.NewGuid();
        Drivers = drivers;
        Tracks = tracks;
    }

    /// <summary>
    /// Compare the current instance GUID with another GUID.
    /// </summary>
    /// <param name="guid">GUID of the championship you want to compare.</param>
    /// <returns>A championship instance or null</returns>
    public Championship GrabInstanceFromGUID(Guid guid)
    {
        if (GUID == guid)
        { 
            return this;
        }

        return null;
    }
}