namespace SimRacingManager.Core;

public class DatabaseStuff
{
    private const string Url = "https://rxrohdwbxmzoeichstic.supabase.co";
    private const string Key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InJ4cm9oZHdieG16b2VpY2hzdGljIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDczMDI1MTEsImV4cCI6MjA2Mjg3ODUxMX0.ptcPOyeeS0v4FOwB9rnMthEvyfjh7Q1oA0pZjOZLOjI";

    private Supabase.Client _supabaseClient;
    private bool _hasAlreadyBeenCalled;
    
    public static List<Driver> Drivers;
    
    /// <summary>
    /// Initialise connections and data fetching for the database.
    /// </summary>
    public void Initialise()
    {
        if (!_hasAlreadyBeenCalled) // Prevents multiple API calls
        {
            InitialiseClient();
            DriversList();   
        }
        
        _hasAlreadyBeenCalled = true;
    }
    
    private async void InitialiseClient()
    {
        var options = new Supabase.SupabaseOptions
        {
            AutoConnectRealtime = true
        };

        _supabaseClient = new Supabase.Client(Url, Key, options);
        await _supabaseClient.InitializeAsync();
    }
    
    /// <summary>
    /// Fetches all the rows in the 'drivers' table and returns them has a Driver List. 
    /// </summary>
    private async void DriversList()
    {
        var result = await _supabaseClient.From<Driver>().Get();
        Drivers = result.Models;
    }
}