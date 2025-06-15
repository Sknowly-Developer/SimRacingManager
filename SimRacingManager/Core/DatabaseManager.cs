using Supabase;
using Supabase.Postgrest;
using Client = Supabase.Client;

namespace SimRacingManager.Core;

public class DatabaseManager
{
    private static readonly string Url = Environment.GetEnvironmentVariable("SUPABASE_URL");
    private static readonly string Key = Environment.GetEnvironmentVariable("SUPABASE_KEY");

    public static Client SupabaseClient;
    
    public static List<Championship> Championships = [];
    public static List<Driver> Drivers = [];
    public static List<Track> Tracks = [];
    public static List<Results> Results = [];
    
    /// <summary>
    /// Opens a connection to the database then keeps a reference.
    /// </summary>
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
        catch (Exception e)
        {
            Console.WriteLine($"Unable to establish a connection to the database. Exception: {e}");
        }
    }

    /// <summary>
    /// Runs all the methods beginning with Fetch, so this includes Championships, Drivers, Tracks, etc...
    /// </summary>
    public static void FetchAllData()
    {
        FetchChampionshipsTable();
        FetchDriversTable();
        FetchTracksTable();
        FetchResultsTable();
    }
    
    /// <summary>
    /// Queries all data from the Championships table.
    /// </summary>
    private static async void FetchChampionshipsTable()
    {
        try
        {
            var championshipModels = await SupabaseClient.From<Championship>().Get();
            
            foreach (var championship in championshipModels.Models)
            {
                Championships.Add(championship);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to fetch championships. Exception: {e}");
        }
    }
    
    /// <summary>
    /// Queries all data from the Drivers table.
    /// </summary>
    private static async void FetchDriversTable()
    {
        try
        {
            var driverModels = await SupabaseClient.From<Driver>().Get();
            
            foreach (var driver in driverModels.Models)
            {
                Drivers.Add(driver);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to fetch drivers. Exception: {e}");
        }
    }

    /// <summary>
    /// Queries all data from the Track table.
    /// </summary>
    private static async void FetchTracksTable()
    {
        try
        {
            var trackModels = await SupabaseClient.From<Track>().Get();

            foreach (var track in trackModels.Models)
            {
                Tracks.Add(track);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to fetch tracks. Exception: {e}");
        }
    }
    
    /// <summary>
    /// Queries all data from the Results table.
    /// </summary>
    private static async void FetchResultsTable()
    {
        try
        {
            var resultsModels = await SupabaseClient.From<Results>().Get();

            foreach (var result in resultsModels.Models)
            {
                Results.Add(result);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to fetch results. Exception: {e}");
        }
    }
    
    /// <summary>
    /// Queries all data from the Vehicles table.
    /// </summary>
    public static async Task<string?> FetchVehiclesFromChampionship(Championship championship, Guid driverGuid)
    {
        string? vehicleType = null;
        
        try
        {
            var vehiclesModels = await SupabaseClient.From<Vehicles>()
                .Filter(vehicles => vehicles.Guid, Constants.Operator.In, championship.VehiclesGuid)
                .Where(vehicles => vehicles.DriverGuid == driverGuid)
                .Get();

            foreach (var vehicle in vehiclesModels.Models)
            {
                vehicleType = vehicle.VehicleType;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to fetch vehicles. Exception: {e}");
        }

        return vehicleType;
    }

    public static async Task<int> FetchTotalPointsPerChampionship(Championship championship, Guid driverGuid)
    {
        var finalPoints = 0;
        
        try
        {
            var trackModels = await SupabaseClient.From<Track>()
                .Filter(track => track.Guid, Constants.Operator.In, championship.TracksGuid)
                .Order(track => track.Date, Constants.Ordering.Ascending)
                .Get();

            foreach (var track in trackModels.Models)
            {
                var resultsModels = await SupabaseClient.From<Results>()
                    .Filter(results => results.Guid, Constants.Operator.In, track.ResultsGuid)
                    .Where(results => results.DriverGuid == driverGuid)
                    .Get();

                foreach (var result in resultsModels.Models)
                {
                    finalPoints += result.ReturnAddAllPoints();
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unable to fetch total driver points for championship {championship.Year} {championship.Name}. Exception: {e}");
        }

        return finalPoints;
    }
}