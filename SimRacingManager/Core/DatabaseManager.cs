using Supabase;

namespace SimRacingManager.Core;

public class DatabaseManager
{
    private const string Url = "https://rxrohdwbxmzoeichstic.supabase.co";
    private const string Key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InJ4cm9oZHdieG16b2VpY2hzdGljIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDczMDI1MTEsImV4cCI6MjA2Mjg3ODUxMX0.ptcPOyeeS0v4FOwB9rnMthEvyfjh7Q1oA0pZjOZLOjI";

    public static Client SupabaseClient;
    private static bool _hasAlreadyBeenInitialised;
    
    public static async void Initialise()
    {
        try
        {
            // Once we have a connection, we don't need to keep overriding it.
            if (!_hasAlreadyBeenInitialised)
            {
                var options = new SupabaseOptions
                {
                    AutoConnectRealtime = true
                };

                SupabaseClient = new Client(Url, Key, options);
                await SupabaseClient.InitializeAsync();   
            }

            _hasAlreadyBeenInitialised = true;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
}