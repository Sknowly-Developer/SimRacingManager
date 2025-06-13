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
    
    [Column("fastest_lap")]
    public string? FastestLap { get; set; }
    
    [Column("time")]
    public string? Time { get; set; }
    
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