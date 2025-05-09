namespace SimRacingManager;

public class Championship
{
    public string Name;
    public Guid GUID;
    
    public Championship(string name)
    {
        Name = $"{name} Championship";
        GUID = Guid.NewGuid();
    }

    public Championship GrabInstanceFromGUID(Guid guid)
    {
        if (GUID == guid)
        { 
            return this;
        }

        return null;
    }
}