using Supabase;

namespace SimRacingManager.Core;

public class DatabaseManager
{
    private const string Url = "https://rxrohdwbxmzoeichstic.supabase.co";
    private const string Key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InJ4cm9oZHdieG16b2VpY2hzdGljIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDczMDI1MTEsImV4cCI6MjA2Mjg3ODUxMX0.ptcPOyeeS0v4FOwB9rnMthEvyfjh7Q1oA0pZjOZLOjI";

    public static Client SupabaseClient;
    
    public static async void Initialise()
    {
        try
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            SupabaseClient = new Client(Url, Key, options);
            await SupabaseClient.InitializeAsync();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
}