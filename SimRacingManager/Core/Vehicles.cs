using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SimRacingManager.Core;

[Table("vehicles")]
public class Vehicles : BaseModel
{
    [PrimaryKey("uuid")]
    public Guid Guid { get; set; }
    
    [Column("driver")]
    public Guid DriverGuid { get; set; }
    
    [Column("type")]
    public string? VehicleType { get; set; }
}