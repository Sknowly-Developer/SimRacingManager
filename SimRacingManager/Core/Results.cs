using SimRacingManager.Data;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SimRacingManager.Core;

[Table("results")]
public class Results : BaseModel
{
    [PrimaryKey("uuid")]
    public Guid Guid { get; set; }
    
    [Column("position")]
    public int Position { get; set; }
    
    [Column("driver")]
    public Guid DriverGuid { get; set; }
    public Driver Driver;
    
    [Column("points")]
    public int Points { get; set; }
    public int TotalPoints;
    
    [Column("fastest_lap")]
    public string? FastestLap { get; set; }
    
    [Column("time")]
    public string? Time { get; set; }
    
    [Column("reaching_top_x_points")]
    public int? ReachingTopXPoints { get; set; }

    /// <summary>
    /// Adding up the extra points from the fastest lap and for reaching the top X if a player didn't last time. 
    /// </summary>
    public void AddAllPoints()
    {
        TotalPoints += Points;
        
        if (FastestLap != null)
        {
            TotalPoints += 1;
        }

        if (ReachingTopXPoints != null)
        {
            // Casting to an int because the value shouldn't be null if it gets through this if statement.
            TotalPoints += (int)ReachingTopXPoints;
        }
    }
    
    /// <summary>
    /// Adding all the points together per driver per track.
    /// </summary>
    /// <returns>The final amount of points.</returns>
    public int ReturnAddAllPoints()
    {
        var allPoints = 0;
        allPoints += Points;
        
        if (FastestLap != null)
        {
            allPoints += 1;
        }

        if (ReachingTopXPoints != null)
        {
            // Casting to an int because the value shouldn't be null if it gets through this if statement.
            allPoints += (int)ReachingTopXPoints;
        }

        return allPoints;
    }
    
    /// <summary>
    /// Loop through all drivers in DatabaseManager.Drivers, compare their Guids against the Driver Guid in this class and assign a Driver if they match.
    /// </summary>
    public void AssignDriver()
    {
        foreach (var driver in DatabaseManager.Drivers)
        {
            if (driver.Guid == DriverGuid)
            {
                Driver = driver;
            }
        }
    }

    /// <summary>
    /// Set the VehicleType of this Driver, so it shows within every track results page.
    /// </summary>
    public async Task<string?> AssignDriverVehicles()
    {
        string? vehicleType = null;
        
        try
        {
            vehicleType = await DatabaseManager.FetchVehiclesFromChampionship(Globals.LastSelectedChampionship, DriverGuid);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Failed to fetch vehicle type for Driver - {Driver.Name} {Driver.Surname}. Exception = {e}");
        }

        return vehicleType;
    }
}