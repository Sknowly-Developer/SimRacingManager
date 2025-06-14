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
}